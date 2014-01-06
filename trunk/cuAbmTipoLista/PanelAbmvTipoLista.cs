///////////////////////////////////////////////////////////
//  PanelAbmvTipoLista.cs
//  Implementación del panel ABMV para la entidad 
//  TipoListaGestion de la aplicación.
//  Generated Manualmente
//  Created on:      01-sep-2009 12:00:00
//  Original author: Fernando
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
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.enums;
using scioSecureLibrary.dominio;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmTipoLista {
    public partial class PanelAbmvTipoLista : PanelABMV<TipoListaGestion> {
        protected WinSelect<Perfil> _ws;
        private readonly CUListSetEntidad _listEntidades;
        private readonly CUListSetEstrategia _listEstrategias;
        private IVistaPanelList _panelEntidades, _panelEstrategias;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvTipoLista(IControladorEditable<TipoListaGestion> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listEntidades = new CUListSetEntidad {
                    Disponibles = RepositorioGenerico<Entidad>.GetAliveAll(),
                    Padre = this
                };

                _listEstrategias = new CUListSetEstrategia {
                    Disponibles = RepositorioGenerico<Estrategia>.GetAliveAll(),
                    Padre = this
                };
            } catch (Exception e) {
                Sistema.Controlador.logear("PANEL-NOK", ENivelMensaje.ERROR, e.ToString());
                throw new VistaErrorException("PANEL-NOK");
            }
        }

        #region panelabmv
        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                _listEntidades.ObjetoMaster = _listEstrategias.ObjetoMaster = _objeto;

                _listEntidades.Configurados = _objeto.ListaEntidades;
                _listEstrategias.Configurados = _objeto.ListaEstrategias;

                cargarControles();
                cargarDatos();
                cargarTabs();
            } catch (Exception e) {
                Sistema.Controlador.logear("DATA-SETNOK", ENivelMensaje.ERROR, e.ToString());
                throw new DataErrorException("DATA-SETNOK");
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Textos
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                // Numeros
                ctrlTxtMaxCuentas.Text = _objeto.MaxCuentas.ToString();
                ctrlTxtPrioridad.Text = _objeto.Prioridad.ToString();
                // Boleanos
                ctrlChkVerFE.Checked = _objeto.Elegibilidad;
                ctrlChkVerPendientes.Checked = _objeto.Pendiente;
                ctrlChkCancelacion.Checked = _objeto.Cancelacion;
                // Fechas
                txtFechaAlta.Text = (_objeto.FechaAlta <= Fechas.FechaNull)
                                        ? string.Empty
                                        : _objeto.FechaAlta.ToLongDateString();
                // Clases
                if (_objeto.Perfil != null) {
                    txtPerfil.Tag = _objeto.Perfil;
                    txtPerfil.Text = _objeto.Perfil.Nombre;
                }
            } catch (Exception e) {
                Sistema.Controlador.logear("DATA-LOADNOK", ENivelMensaje.ERROR, e.ToString());
                throw new DataErrorException("DATA-LOADNOK");
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarTabs() {
            try {
                if (_enProceso) {
                    _panelEntidades = _listEntidades.getPanelListado(_controlador.ModoVista);
                    _panelEntidades.Contenedor = this;
                    tabEntidades.Controls.Clear();
                    tabEntidades.Controls.Add((Control)_panelEntidades);
                    tabEntidades.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelEstrategias = _listEstrategias.getPanelListado(_controlador.ModoVista);
                    _panelEstrategias.Contenedor = this;
                    tabEstrategias.Controls.Clear();
                    tabEstrategias.Controls.Add((Control)_panelEstrategias);
                    tabEstrategias.Controls["PanelListSet"].Dock = DockStyle.Fill;
                } else {
                    _panelEntidades.refrescarListado(_listEntidades.ColsInvisibles);
                    _panelEstrategias.refrescarListado(_listEstrategias.ColsInvisibles);
                }

                tabEntidades.Text = string.Format("Entidades ({0})", _objeto.ListaEntidades.Count);
                tabEntidades.Refresh();

                tabEstrategias.Text = string.Format("Estrategias ({0})", _objeto.ListaEstrategias.Count);
                tabEstrategias.Refresh();
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboTipoGestion();
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtNombre.Text == (_objeto.Nombre ?? "") &&
                         ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? "") &&
                         _objeto.MaxCuentas == Convert.ToInt64(ctrlTxtMaxCuentas.Text) &&
                         _objeto.Prioridad == Convert.ToInt64(ctrlTxtPrioridad.Text) &&
                         txtPerfil.Tag == _objeto.Perfil &&
                         ctrlChkVerFE.Checked == _objeto.Elegibilidad &&
                         ctrlChkVerPendientes.Checked == _objeto.Pendiente &&
                         ctrlChkCancelacion.Checked == _objeto.Cancelacion &&
                         ctrlTxtCmbTipoGestion.SelectedItem
                         == (_objeto.TipoGestion ?? ctrlTxtCmbTipoGestion.SelectedItem));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.MaxCuentas = Convert.ToInt64(ctrlTxtMaxCuentas.Text);
                _objeto.Prioridad = Convert.ToInt64(ctrlTxtPrioridad.Text);
                _objeto.Perfil = (Perfil)txtPerfil.Tag;
                _objeto.TipoGestion = (Parametro)ctrlTxtCmbTipoGestion.SelectedItem;
                _objeto.FechaAlta = DateTime.Now;
                _objeto.Elegibilidad = ctrlChkVerFE.Checked;
                _objeto.Pendiente = ctrlChkVerPendientes.Checked;
                _objeto.Cancelacion = ctrlChkCancelacion.Checked;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region controles
        /// <summary>
        ///   Este método carga el combo de Tipos de Gestión de la cuenta.
        ///   Lanza una VistaErrorException si tiene algún problema.
        /// </summary>
        private void cargarComboTipoGestion() {
            ctrlTxtCmbTipoGestion.Items.Clear();
            try {
                foreach (Parametro parametro in
                    Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "TIPOGESTION"))
                    // solo carga los tipos marcados como "generables"
                    // (con valorbool en true dentro del parámetro).
                    if (parametro.Valorbool) {
                        ctrlTxtCmbTipoGestion.Items.Add(parametro);

                        if (_objeto != null
                            && _objeto.TipoGestion != null
                            && _objeto.TipoGestion.Equals(parametro))
                            ctrlTxtCmbTipoGestion.SelectedItem = parametro;
                    }

                if (ctrlTxtCmbTipoGestion.SelectedItem == null && ctrlTxtCmbTipoGestion.Items.Count >= 1)
                    ctrlTxtCmbTipoGestion.SelectedItem = ctrlTxtCmbTipoGestion.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion controles

        #region interfase
        /// <summary>
        ///   Este método responde al botón Ver Garante. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerPerfil_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuConfigurarUsuarios.CUAbmPerfil", this, new[] {EModoVentana.VIEW, txtPerfil.Tag});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        ///   Este método responde al botón Buscar Garante. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindPerfil_Click(object sender, EventArgs e) {
            try {
                if (_ws == null)
                    _ws = new WinSelect<Perfil>("cuConfigurarUsuarios.CUListPerfiles");

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    txtPerfil.Tag = _ws.Seleccion;
                    txtPerfil.Text = txtPerfil.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }
        #endregion interfase
    }
}