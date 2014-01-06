using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio.repos;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuListaGestion {
    public partial class PanelListListas : PanelListABMV<ListaGestion> {
        /// <summary>
        /// Constructor de la clase que primero ejecuta la inicialización
        /// por defecto y luego asigna el controlador y panel asociado al 
        /// listado (para agregar, mostrar, editar o borrar). Debería lanzar 
        /// una VistaErrorExcetion si hay un problema.
        /// </summary>
        /// <param name="controlador">
        /// El objeto controlador de la ventana.
        /// </param>
        public PanelListListas(IControladorListable<ListaGestion> controlador) : base(controlador) {}

        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        public override void setModoVista() {
            setModoVista(_controlador.ModoVista);
        }

        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        public override void setModoVista(EModoVentana modo) {
            switch (modo) {
                case EModoVentana.EDIT:
                case EModoVentana.FULL:
                case EModoVentana.LIST:
                case EModoVentana.GESTION:
                    setGestionable();
                    break;
                default:
                    setReadOnly();
                    break;
            }
        }

        /// <summary>
        /// Este método muestra solo el botón de agregar de la toolbar para
        /// dejar al listado en un modo de Agregable (solamente con add).
        /// </summary>
        protected void setGestionable() {
            base.setReadOnly();
            try {
                toolStrip1.Items["btnGestion"].Visible = true;
                toolStrip1.Items["btnCartas"].Visible = true;
                toolStrip1.Items["btnRemove"].Visible = true;
            } catch (Exception e) {
                Sistema.Controlador.logear("VISTA-NOK", ENivelMensaje.ERROR, e.ToString());
                throw new VistaErrorException("VISTA-NOK");
            }
        }

        #region interface
        /// <summary>
        /// Este método responde al botón Gestion. Debería 'mostrar' cualquier
        /// error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected virtual void btnGestion_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);
            else if (getObjetoActual().FechaBaja != Fechas.FechaNull)
                Sistema.Controlador.mostrar("ROW-NOTALIVE", ENivelMensaje.ERROR, null, false);
            else
                try {
                    CUCaller.CallCU("cuListaGestion.CUCargaResultado", this, new object[] {getObjetoActual()});
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("ACTION-GESTION-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                } finally {
                    refrescarListado(_controlador.ColsInvisibles);

                    if (_controlador.Padre is PanelABMV<ListaGestion>)
                        ((PanelABMV<ListaGestion>) _controlador.Padre).cargarTabs();
                    else if (_controlador.Padre is WinTreeConfig)
                        ((WinTreeConfig) _controlador.Padre).getControlador()
                            .alActualizarListado(((WinTreeConfig) _controlador.Padre).getNodoSeleccionado());
                }
        }

        /// <summary>
        /// Este método responde al botón Gestion. Debería 'mostrar' cualquier
        /// error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected virtual void btnCartas_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);
            else if (getObjetoActual().FechaBaja != Fechas.FechaNull)
                Sistema.Controlador.mostrar("ROW-NOTALIVE", ENivelMensaje.ERROR, null, false);
            else if (getObjetoActual().TipoLista.TipoGestion != Parametros.GetByClave("TIPOGESTION.POSTAL")
                     && getObjetoActual().TipoLista.TipoGestion != Parametros.GetByClave("TIPOGESTION.TERRENO"))
                Sistema.Controlador.mostrar("ERROR-LISTA-TIPO-INCORRECTO", ENivelMensaje.ERROR, null, true);
            else
                try {
                    CUCaller.CallCU("cuGenerarInformes.CUGenerarCarta", _controlador.Padre,
                                    new object[] {EModoVentana.VIEW, getObjetoActual()});
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("ACTION-GESTION-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                } finally {
                    refrescarListado(_controlador.ColsInvisibles);

                    if (_controlador.Padre is PanelABMV<ListaGestion>)
                        ((PanelABMV<ListaGestion>) _controlador.Padre).cargarTabs();
                    else if (_controlador.Padre is WinTreeConfig)
                        ((WinTreeConfig) _controlador.Padre).getControlador()
                            .alActualizarListado(((WinTreeConfig) _controlador.Padre).getNodoSeleccionado());
                }
        }

        /// <summary>
        /// Este método responde al botón Remove y actualiza el listado 
        /// (y los tabs si es detail) luego de finalizada su operación.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected override void btnRemove_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);
            else
                try {
                    if (Sistema.Controlador.mostrar("PREGUNTA-BAJAR-OBJETO", ENivelMensaje.PREGUNTA, null, false)
                        == DialogResult.Yes) {
                        getObjetoActual().delete();
                        Sistema.Controlador.mostrar("DATA-DELOK", ENivelMensaje.INFORMACION, null, false);
                    }
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("ACTION-DEL-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                } finally {
                    postAccion();
                }
        }

        /// <summary>
        /// Este método responde al botón Gestion. Debería 'mostrar' cualquier
        /// error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected virtual void btnListado_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);
            else if (getObjetoActual().FechaBaja != Fechas.FechaNull)
                Sistema.Controlador.mostrar("ROW-NOTALIVE", ENivelMensaje.ERROR, null, false);
            else
                try {
                    CUCaller.CallCU("cuGenerarInformes.CUListadoGestionesGeneradas", null,
                                    new object[] {((ListaGestion) getObjectActual()).Id, ((ListaGestion) getObjectActual()).Id});
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("ACTION-GESTION-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                } finally {
                    refrescarListado(_controlador.ColsInvisibles);

                    if (_controlador.Padre is PanelABMV<ListaGestion>)
                        ((PanelABMV<ListaGestion>) _controlador.Padre).cargarTabs();
                    else if (_controlador.Padre is WinTreeConfig)
                        ((WinTreeConfig) _controlador.Padre).getControlador()
                            .alActualizarListado(((WinTreeConfig) _controlador.Padre).getNodoSeleccionado());
                }
        }
        #endregion interface
    }
}