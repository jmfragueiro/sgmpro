///////////////////////////////////////////////////////////
//  PanelAbmvGestion.cs
//  Implementación del panel ABMV para la entidad Gestion
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.gestion;

namespace cuAbmGestion {
    public partial class PanelAbmvGestion : PanelABMV<Gestion> {
        private static readonly Parametro _pendiente = Parametros.GetByClave("ESTADOGESTION.PENDIENTE");
        /// <summary>
        /// La ventana de selección para la persona contactada.
        /// </summary>
        protected WinSelect<Persona> _ws;
        /// <summary>
        /// La ventana de selección para el contacto utilizado.
        /// </summary>
        protected WinSelect<Contacto> _wsc;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvGestion(IControladorEditable<Gestion> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                cargarControles();
                cargarDatos();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboTipo();
            cargarComboResultado();

            btnReimprimir.Visible =
                (_objeto.Tipo.Equals(Parametros.GetByClave("TIPOGESTION.POSTAL"))
                 || _objeto.Tipo.Equals(Parametros.GetByClave("TIPOGESTION.TERRENO")))
                && (_controlador.ModoVista == EModoVentana.GESTION
                    || _controlador.ModoVista == EModoVentana.EDIT);
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // primero verifica si debe establecer la fecha de inicio
                if (_objeto.FechaInicio == Fechas.FechaNull && _controlador.ModoVista >= EModoVentana.ADD)
                    _objeto.FechaInicio = (_objeto.FechaCierre == Fechas.FechaNull)
                                              ? DateTime.Now
                                              : _objeto.FechaCierre;

                // Texto
                ctrlTxtDescripcion.Text = _objeto.ResultadoDesc;
                // Fechas
                txtFechaInicio.Text = (_objeto.FechaInicio <= Fechas.FechaNull)
                                          ? ""
                                          : _objeto.FechaInicio.ToString();
                txtFechaCierre.Text = (_objeto.FechaCierre <= Fechas.FechaNull)
                                          ? ""
                                          : _objeto.FechaCierre.ToString();
                ctrlFechaRes.Value = (_objeto.ResultadoFecha <= Fechas.FechaNull)
                                         ? DateTime.Now
                                         : _objeto.ResultadoFecha;
                ctrlTxtResFecha.Text = ctrlFechaRes.Value.ToString();
                // Clases
                if (_objeto.Estado != null)
                    txtEstado.Text = _objeto.Estado.Nombre;
                if (_objeto.Contactado != null) {
                    txtPersona.Tag = _objeto.Contactado;
                    txtPersona.Text = txtPersona.Tag.ToString();
                }
                if (_objeto.Contacto != null) {
                    txtContacto.Tag = _objeto.Contacto;
                    txtContacto.Text = txtContacto.Tag.ToString();
                }
                if (_objeto.Usuario != null) {
                    txtUsuario.Tag = _objeto.Usuario;
                    txtUsuario.Text = txtUsuario.Tag.ToString();
                }
                if (_objeto.Lista != null) {
                    txtLista.Tag = _objeto.Lista;
                    txtLista.Text = txtLista.Tag.ToString();
                }
                if (_objeto.Cuenta != null) {
                    txtCuenta.Tag = _objeto.Cuenta;
                    txtCuenta.Text = txtCuenta.Tag.ToString();
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return (!(ctrlTxtDescripcion.Text == _objeto.ResultadoDesc
                          && txtPersona.Tag == _objeto.Contactado
                          && (ctrlFechaRes.Value == _objeto.ResultadoFecha || ctrlFechaRes.Visible == false)
                          && txtContacto.Tag == _objeto.Contacto
                          && _objeto.Tipo.Equals(ctrlTxtComboTipo.SelectedItem)));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Contactado = (Persona)txtPersona.Tag;
                _objeto.Contacto = (Contacto)txtContacto.Tag;
                _objeto.ResultadoDesc = ctrlTxtDescripcion.Text;
                _objeto.Resultado = (Parametro)ctrlTxtComboResultado.SelectedItem;
                _objeto.ResultadoFecha = (_objeto.Resultado.Valorstring != null) ? ctrlFechaRes.Value : Fechas.FechaNull;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// Aqui verifica que si la cuenta no esta elegible, entonces se 
        /// avisa para asegurar si no se carga una gestion con un resultado 
        /// igual al que ya tenia la ultima gestion para dicha cuenta.
        /// </summary>
        public override void guardarDatos() {
            refrescarDatos();
            if (_objeto.Cuenta.FechaElegible.Date > DateTime.Today
                && !_objeto.Cuenta.getGestionRealizadaAnteriorSinRefresh(0).Resultado
                    .Equals(_objeto.Resultado)) {
                    if (Sistema.Controlador.mostrar("PREGUNTA-MODIFICAR-NOELEGIBLE", ENivelMensaje.PREGUNTA, null, false)
                        == DialogResult.No)
                        throw new DataErrorException("DATO-RESULTADO-MODIFICAR", 
                            _objeto.Cuenta.getGestionRealizadaAnteriorSinRefresh(0).Resultado.ToString());
            }
            _controlador.save();
            Sistema.Controlador.mostrar("DATA-SAVEOK", ENivelMensaje.INFORMACION, null, false);
        }
        #endregion panelabmv

        #region controles
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void setEditable() {
            base.setEditable();

            ctrlTxtComboTipo.ReadOnly = (_objeto.Tipo != null);
            ctrlTxtComboResultado.ReadOnly = (_objeto.Resultado != null && !_objeto.Estado.Equals(_pendiente));
            ctrlTxtDescripcion.ReadOnly = false;
            ctrlTxtResFecha.ReadOnly = false;
            ctrlFechaRes.Enabled = true;
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void setNoEditable() {
            base.setNoEditable();

            ctrlTxtComboTipo.ReadOnly = true;
            ctrlTxtComboResultado.ReadOnly = true;
            ctrlTxtDescripcion.ReadOnly = true;
            ctrlTxtResFecha.ReadOnly = true;
            ctrlFechaRes.Enabled = false;
        }

        /// <summary>
        /// Este método carga el combo de tipos de resultados.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipo() {
            ctrlTxtComboTipo.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "TIPOGESTION"))) {
                    ctrlTxtComboTipo.Items.Add(p);

                    if (_objeto.Tipo != null && _objeto.Tipo.Equals(p))
                        ctrlTxtComboTipo.SelectedItem = p;
                }

                if (ctrlTxtComboTipo.SelectedItem == null && ctrlTxtComboTipo.Items.Count >= 1)
                    ctrlTxtComboTipo.SelectedItem = ctrlTxtComboTipo.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método carga el combo de tipos de resultados.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboResultado() {
            ctrlTxtComboResultado.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLikeDescNombre(ETipoParametro.GESTION, "RESULTADOGESTION"))) {
                    ctrlTxtComboResultado.Items.Add(p);

                    if (_objeto.Resultado != null && _objeto.Resultado.Equals(p))
                        ctrlTxtComboResultado.SelectedItem = p;
                }

                if (ctrlTxtComboResultado.SelectedItem == null && ctrlTxtComboResultado.Items.Count >= 1)
                    ctrlTxtComboResultado.SelectedItem = ctrlTxtComboResultado.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion controles

        #region interface
        /// <summary>
        /// Este método responde al botón Ver Persona. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerPersona_Click(object sender, EventArgs e) {
            try {
                if (txtPersona.Tag != null)
                    CUCaller.CallCU("cuAbmPersona", this, new[] {EModoVentana.VIEW, txtPersona.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Buscar Persona. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindPersona_Click(object sender, EventArgs e) {
            try {
                if (_ws == null)
                    _ws = new WinSelect<Persona>("cuAbmPersona.CUListPersonas");

                // setea filtros especificos para esta ventana
                _ws.getControlador().Filtros.Clear();
                if (_objeto.Cuenta.Titular != null && _objeto.Cuenta.Garante != null)
                    _ws.getControlador().Filtros.Add(
                        Criterios.Or(
                            Criterios.Igual("Id", _objeto.Cuenta.Titular.Id),
                            Criterios.Igual("Id", _objeto.Cuenta.Garante.Id)));
                else if (_objeto.Cuenta.Titular != null)
                    _ws.getControlador().Filtros.Add(Criterios.Igual("Id", _objeto.Cuenta.Titular.Id));
                else if (_objeto.Cuenta.Garante != null)
                    _ws.getControlador().Filtros.Add(Criterios.Igual("Id", _objeto.Cuenta.Garante.Id));

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    txtPersona.Tag = _ws.Seleccion;
                    txtPersona.Text = txtPersona.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Contacto. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerContacto_Click(object sender, EventArgs e) {
            try {
                if (txtContacto.Tag != null)
                    CUCaller.CallCU("cuAbmContacto", this, new[] {EModoVentana.VIEW, txtContacto.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Buscar Contacto. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindContacto_Click(object sender, EventArgs e) {
            try {
                if (txtPersona.Tag == null) {
                    Sistema.Controlador.mostrar("ERROR-PERSONA-MUSTHAVE", ENivelMensaje.ERROR, null, false);
                    return;
                }

                if (_wsc == null)
                    _wsc = new WinSelect<Contacto>("cuAbmContacto.CUListContactos");

                _wsc.getControlador().ObjetoMaster = (Persona)txtPersona.Tag;
                _wsc.ShowDialog();

                if (_wsc.Seleccion != null) {
                    txtContacto.Tag = _wsc.Seleccion;
                    txtContacto.Text = txtContacto.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Cuenta. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerCuenta_Click(object sender, EventArgs e) {
            try {
                if (txtCuenta.Tag != null)
                    CUCaller.CallCU("cuAbmCuenta", this, new[] {EModoVentana.VIEW, txtCuenta.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Agregar Contacto. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlAddContacto_Click(object sender, EventArgs e) {
            try {
                if (txtPersona.Tag is Persona)
                    CUCaller.CallCU(
                        "cuAbmContacto",
                        this,
                        new object[] {EModoVentana.ADD, new Contacto {Persona = (Persona)txtPersona.Tag}});
                else
                    throw new AppErrorException("ERROR-ADD-WITHOUT-MASTER");
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al cambio de fecha del resultado desde el 
        /// datetimepicker. Debería 'mostrar' cualquier error que ocurriese 
        /// y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFechaRes_ValueChanged(object sender, EventArgs e) {
            string fecha = (ctrlFechaRes.Value <= Fechas.FechaNull)
                               ? ""
                               : ctrlFechaRes.Value.ToString();

            if (!ctrlTxtResFecha.Text.Equals(fecha))
                ctrlTxtResFecha.Text = fecha;
        }

        /// <summary>
        /// Este método responde al cambio de fecha del resultado desde el 
        /// propio campo. Debería 'mostrar' cualquier error que ocurriese y 
        /// no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtResFecha_Validated(object sender, EventArgs e) {
            DateTime fecha = Convert.ToDateTime(ctrlTxtResFecha.Text);
            if (ctrlFechaRes.Value != fecha)
                ctrlFechaRes.Value = fecha;
        }

        /// <summary>
        /// Este método responde al cambio del tipo de resultado de la gestion
        /// para verificar si debe o no mostrar una fecha asociada. Debería 
        /// 'mostrar' cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtComboResultado_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlTxtComboResultado.SelectedItem != null) {
                Parametro tipores = (Parametro)ctrlTxtComboResultado.SelectedItem;
                if (tipores.Valorstring != null && !tipores.Valorstring.Equals("")) {
                    label12.Visible = true;
                    label12.Text = tipores.Valorstring;
                    ctrlFechaRes.Value = DateTime.Now;
                    ctrlFechaRes.Visible = true;
                    ctrlTxtResFecha.Visible = true;
                } else {
                    label12.Visible = false;
                    ctrlFechaRes.Visible = false;
                    ctrlFechaRes.Value = Fechas.FechaNull;
                    ctrlTxtResFecha.Text = "";
                    ctrlTxtResFecha.Visible = false;
                }
            }
        }

        /// <summary>
        /// Este método responde a la presión del botón Reimprimir Documento
        /// para reimprimir el documento asociado. Debería 'mostrar' cualquier 
        /// error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnReimprimir_Click(object sender, EventArgs e) {
            CUCaller.CallCU(
                "cuGenerarInformes.CUGenerarCarta",
                ParentForm,
                new object[] {EModoVentana.VIEW, _objeto});
        }
        # endregion interfase
    }
}