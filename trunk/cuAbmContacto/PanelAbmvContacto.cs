///////////////////////////////////////////////////////////
//  PanelAbmvContacto.cs
//  Implementación del panel ABMV para la entidad Contacto
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.enums;
using scioPersistentLibrary.orden;
using scioSecureLibrary.dominio;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmContacto {
    public partial class PanelAbmvContacto : PanelABMV<Contacto> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvContacto(IControladorEditable<Contacto> controlador) : base(controlador) {
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
            cargarComboTiposContacto();
            cargarComboProvLocCP();
            cargarComboOrigen();
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                ctrlTxtCalle.Text = _objeto.Calle;
                ctrlTxtPuerta.Text = _objeto.Puerta;
                ctrlTxtPisoDepto.Text = _objeto.PisoDepto;
                ctrlTxtIDGIS.Text = _objeto.IdGIS;
                ctrlTxtTel1.Text = _objeto.Telefono1;
                ctrlTxtTel2.Text = _objeto.Telefono2;
                ctrlTxtCelular.Text = _objeto.Celular;
                ctrlTxtFax.Text = _objeto.Fax;
                ctrlTxtEmail.Text = _objeto.Email;
                // Booleanos
                ctrlChkPrincipal.Checked = _objeto.Principal;
                // Fechas
                fechaUMod.Text = (_objeto.FechaUMod <= Fechas.FechaNull)
                                     ? ""
                                     : _objeto.FechaUMod.ToShortDateString();
                // Clases
                txtVerificadoPor.Tag = null;
                txtVerificadoPor.Text = string.Empty;
                if (_objeto.VerificadoPor != null) {
                    txtVerificadoPor.Tag = _objeto.VerificadoPor;
                    txtVerificadoPor.Text = txtVerificadoPor.Tag.ToString();
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
                return !(ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? string.Empty) &&
                      ctrlTxtCalle.Text == (_objeto.Calle ?? string.Empty) && 
                      ctrlTxtPuerta.Text == (_objeto.Puerta ?? string.Empty) &&
                      ctrlChkPrincipal.Checked == _objeto.Principal &&
                      ctrlTxtPisoDepto.Text == (_objeto.PisoDepto ?? string.Empty) &&
                      ctrlTxtTel1.Text == (_objeto.Telefono1 ?? string.Empty) &&
                      ctrlTxtIDGIS.Text == (_objeto.IdGIS ?? string.Empty) &&
                      ctrlTxtTel2.Text == (_objeto.Telefono2 ?? string.Empty) &&
                      ctrlTxtCelular.Text == (_objeto.Celular ?? string.Empty) &&
                      ctrlTxtFax.Text == (_objeto.Fax ?? string.Empty) &&
                      ctrlTxtEmail.Text == (_objeto.Email ?? string.Empty) &&
                      txtCP.Text == (_objeto.Cp ?? string.Empty) &&
                      ctrlTxtTipoContacto.SelectedItem.Equals(_objeto.Tipo) &&
                      ctrlTxtProvincia.SelectedItem.Equals(_objeto.Provincia) &&
                      ctrlTxtLocalidad.SelectedItem.Equals(_objeto.Localidad) &&
                      ctrlTxtOrigen.SelectedItem.Equals(_objeto.Origen));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Calle = ctrlTxtCalle.Text;
                _objeto.Puerta = ctrlTxtPuerta.Text;
                _objeto.PisoDepto = ctrlTxtPisoDepto.Text;
                _objeto.IdGIS = ctrlTxtIDGIS.Text;
                _objeto.Telefono1 = ctrlTxtTel1.Text;
                _objeto.Telefono2 = ctrlTxtTel2.Text;
                _objeto.Celular = ctrlTxtCelular.Text;
                _objeto.Fax = ctrlTxtFax.Text;
                _objeto.Email = ctrlTxtEmail.Text;
                _objeto.Cp = txtCP.Text;
                _objeto.Principal = ctrlChkPrincipal.Checked;
                _objeto.Tipo = (Parametro) ctrlTxtTipoContacto.SelectedItem;
                _objeto.Provincia = (Parametro) ctrlTxtProvincia.SelectedItem;
                _objeto.Localidad = (Parametro) ctrlTxtLocalidad.SelectedItem;
                _objeto.Origen = (Parametro) ctrlTxtOrigen.SelectedItem;
                _objeto.VerificadoPor = (Usuario) txtVerificadoPor.Tag;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion panelabmv

        #region controles
        /// <summary>
        /// Este método carga el combo de tipos de contacto.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTiposContacto() {
            ctrlTxtTipoContacto.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "TIPOCONTACTO"))) {
                    ctrlTxtTipoContacto.Items.Add(p);

                    if (_objeto.Tipo != null && _objeto.Tipo.Equals(p))
                        ctrlTxtTipoContacto.SelectedItem = p;
                }

                if (ctrlTxtTipoContacto.SelectedItem == null && ctrlTxtTipoContacto.Items.Count >= 1)
                    ctrlTxtTipoContacto.SelectedItem = ctrlTxtTipoContacto.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método se encarga de cargar los combos de provincia, 
        /// localidad y el campo de cp, lo que se realiza en el orden
        /// adecuado.
        /// </summary>
        private void cargarComboProvLocCP() {
            cargarComboProvincia();
            cargarComboLocalidad();
            cargarCP();
        }

        /// <summary>
        /// Este método carga el combo de provincias y establece
        /// como seleccionado el correspondiente al Contacto actual
        /// o bien el que esta primero en la lista de parámetros.
        /// Lanza una VistaErrorException si tiene algún problema.
        /// </summary>
        private void cargarComboProvincia() {
            ctrlTxtProvincia.Items.Clear();
            try {
                foreach (Parametro p in 
                        RepositorioGenerico<Parametro>.GetByCriteria(
                        true, 
                        new[] {Criterios.Like("Clave", "PROVINCIA.%")},
                        new[] {Orden.Asc("Nombre")})) {
                    ctrlTxtProvincia.Items.Add(p);

                    if (_objeto.Provincia != null && _objeto.Provincia.Equals(p))
                        ctrlTxtProvincia.SelectedItem = p;
                }

                if (ctrlTxtProvincia.SelectedItem == null && ctrlTxtProvincia.Items.Count >= 1)
                    ctrlTxtProvincia.SelectedItem = ctrlTxtProvincia.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método carga el combo de localidades de
        /// acuerdo a lo que tiene el combo de provincias.
        /// Lanza una VistaErrorException si tiene algún problema. 
        /// </summary>
        private void cargarComboLocalidad() {
            ctrlTxtLocalidad.Items.Clear();
            try {
                foreach (Parametro p in
                    RepositorioGenerico<Parametro>.GetByCriteria(
                        true, 
                        new[] {Criterios.Like("Clave", "LOCALIDAD.%"),
                               Criterios.Igual("Valorlong", ((Parametro)ctrlTxtProvincia.SelectedItem).Orden)},
                        new[] {Orden.Asc("Nombre")})) {
                    ctrlTxtLocalidad.Items.Add(p);

                    if (_objeto.Localidad != null && _objeto.Localidad.Equals(p))
                        ctrlTxtLocalidad.SelectedItem = p;
                }

                if (ctrlTxtLocalidad.SelectedItem == null && ctrlTxtLocalidad.Items.Count >= 1)
                    ctrlTxtLocalidad.SelectedItem = ctrlTxtLocalidad.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método carga el campo de código postal de
        /// acuerdo a lo que tiene el combo de Localidades.
        /// Lanza una VistaErrorException si tiene algún problema.        
        /// </summary>
        private void cargarCP() {
            try {
                if (ctrlTxtLocalidad.SelectedItem != null)
                    txtCP.Text = ((Parametro) ctrlTxtLocalidad.SelectedItem).Orden.ToString();
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método carga el combo de localidades de
        /// acuerdo a lo que tiene el combo de provincias.
        /// Lanza una VistaErrorException si tiene algún problema. 
        /// </summary>
        private void cargarComboOrigen() {
            ctrlTxtOrigen.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "ORIGENCONTACTO"))) {
                    ctrlTxtOrigen.Items.Add(p);

                    if (_objeto.Origen != null && _objeto.Origen.Equals(p))
                        ctrlTxtOrigen.SelectedItem = p;
                }

                if (ctrlTxtOrigen.SelectedItem == null && ctrlTxtOrigen.Items.Count >= 1)
                    ctrlTxtOrigen.SelectedItem = ctrlTxtOrigen.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion controles

        #region interface
        /// <summary>
        /// Este método responde al cambio de Provincia seleccionada para
        /// refrescar el listado de las Localidades válidas. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlTxtProvincia.SelectedItem != null)
                cargarComboLocalidad();
        }

        /// <summary>
        /// Este método responde al cambio de Localidad seleccionada para
        /// refrescar el número de código postal de la misma. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlLocalidad_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlTxtLocalidad.SelectedItem != null)
                cargarCP();
        }

        /// <summary>
        /// Este método responde al botón Verificar y marca como verificado 
        /// al contacto. Debería 'mostrar' cualquier error que ocurriese y 
        /// no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlBtnVerificar_Click(object sender, EventArgs e) {
            try {
                _objeto.VerificadoPor = Sistema.Controlador.SecurityService.getUsuario();
                _objeto.FechaUMod = DateTime.Now;
                ((WinABMV<Contacto>) Parent).btnSave_Click(sender, e);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }
        #endregion interface
    }
}