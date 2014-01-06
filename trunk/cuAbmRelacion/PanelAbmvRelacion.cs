///////////////////////////////////////////////////////////
//  PanelAbmvRelacion.cs
//  Implementación del panel ABMV para la entidad Relacion
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
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

namespace cuAbmRelacion {
    public partial class PanelAbmvRelacion : PanelABMV<Relacion> {
        protected WinSelect<Persona> _ws;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvRelacion(IControladorEditable<Relacion> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panleabmv
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
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtComentario.Text = _objeto.Comentario;
                // Fechas
                fechaUMod.Text = (_objeto.FechaUMod <= Fechas.FechaNull)
                                     ? ""
                                     : _objeto.FechaUMod.ToString();
                // Clases
                if (_objeto.Origen != null) {
                    txtOrigen.Tag = _objeto.Origen;
                    txtOrigen.Text = txtOrigen.Tag.ToString();
                }
                if (_objeto.Destino != null) {
                    txtDestino.Tag = _objeto.Destino;
                    txtDestino.Text = txtDestino.Tag.ToString();
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
                return
                    !(ctrlTxtComentario.Text == (_objeto.Comentario ?? "")
                      && txtDestino.Tag == _objeto.Destino
                      && txtOrigen.Tag == _objeto.Origen
                      && ctrlTxtComboTipo.SelectedItem == (_objeto.Tipo ?? ctrlTxtComboTipo.SelectedItem));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Tipo = (Parametro) ctrlTxtComboTipo.SelectedItem;
                _objeto.Origen = (Persona) txtOrigen.Tag;
                _objeto.Destino = (Persona) txtDestino.Tag;
                _objeto.Comentario = ctrlTxtComentario.Text;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region controles
        /// <summary>
        /// Este método carga el combo de tipos de relación.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipo() {
            ctrlTxtComboTipo.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "TIPORELACION"))) {
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
        #endregion

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
        private void ctrlVerDestino_Click(object sender, EventArgs e) {
            try {
                if (txtDestino.Tag != null)
                    CUCaller.CallCU("cuAbmPersona", this, new[] {EModoVentana.VIEW, txtDestino.Tag});
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
        private void ctrlFindDestino_Click(object sender, EventArgs e) {
            try {
                if (_ws == null)
                    _ws = new WinSelect<Persona>("cuAbmPersona.CUListPersonas");

                _ws.getControlador().Filtros.Clear();
                if (txtOrigen.Tag != null)
                    _ws.getControlador().Filtros.Add(Criterios.Distinto("Id", ((Persona) txtOrigen.Tag).Id));

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    txtDestino.Tag = _ws.Seleccion;
                    txtDestino.Text = txtDestino.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Origen. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerOrigen_Click(object sender, EventArgs e) {
            try {
                if (txtOrigen.Tag != null)
                    CUCaller.CallCU("cuAbmPersona", this, new[] {EModoVentana.VIEW, txtOrigen.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Buscar Origen. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindOrigen_Click(object sender, EventArgs e) {
            try {
                if (_ws == null)
                    _ws = new WinSelect<Persona>("cuAbmPersona.CUListPersonas");

                _ws.getControlador().Filtros.Clear();
                if (txtDestino.Tag != null)
                    _ws.getControlador().Filtros.Add(Criterios.Distinto("Id", ((Persona) txtDestino.Tag).Id));

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    txtOrigen.Tag = _ws.Seleccion;
                    txtOrigen.Text = txtOrigen.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }
        #endregion interface
    }
}