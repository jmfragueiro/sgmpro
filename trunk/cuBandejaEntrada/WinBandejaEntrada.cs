﻿///////////////////////////////////////////////////////////
//  WinTreeConfig.cs
//  Implementation of the Class WinTreeConfig.
//  Generated by Fito
//  Created on:      13-abr-2009 17:23:41
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuBandejaEntrada {
    public partial class WinBandejaEntrada : Form {
        private TreeNode _nodoPrevio;
        private int _imagenSPrevia, _imagenNsPrevia;
        /// <summary>
        /// Este atributo es el controlador para el arbol de la ventana.
        /// </summary>
        private readonly IControladorTree _controladorTree;
        /// <summary>
        /// Este atributo es el controlador para el listado/preview de la 
        /// ventana y para gestionar las operaciones ABMV sobre la entidad.
        /// </summary>
        private IControladorListTree _controladorListado;
        /// <summary>
        /// Este atributo referencia a los paneles que se utilizan.
        /// </summary>
        private UserControl[] _paneles;

        /// <summary>
        /// Contructor que llama al constructor por defecto y luego
        /// asocia el controlador para el arbol de la ventana.
        /// </summary>
        public WinBandejaEntrada(IControladorTree controlTree) {
            if (controlTree == null)
                throw new VistaErrorException("VISTA-NOREADY");

            try {
                _controladorTree = controlTree;
                InitializeComponent();
                Icon = controlTree.getIcono();
            } catch (Exception e) {
                Sistema.Controlador.mostrar("TREE-NOK", ENivelMensaje.ERROR, e.ToString(), false);
                throw new VistaErrorException("TREE-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método devuelve el controlador asociado a la instancia.
        /// </summary>
        /// <returns>
        /// El controlador asociado a la ventana.
        /// </returns>
        public IControladorTree getControlador() {
            return _controladorTree;
        }

        /// <summary>
        /// Este método retorna el nodo actualmente seleccionado dentro 
        /// del listado.
        /// </summary>
        /// <returns>
        /// Un TreeNode que es el nodo actualmente seleccionado dentro 
        /// del listado.
        /// </returns>
        public TreeNode getNodoSeleccionado() {
            return treeView1.SelectedNode;
        }

        /// <summary>
        /// Este método es el encargado de actualizar la ventana
        /// para mostrar a la derecha lo que se corresponda con el
        /// item del árbol seleccionado.
        /// </summary>
        public void actualizarListado() {
            try {
                Cursor = Cursors.WaitCursor;
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("UPDATE-LISTPANEL"));

                if (_controladorListado != null) {
                    _paneles = _controladorListado.getPanelesTree();

                    if (_paneles.Length == 2) {
                        splitContainer3.SuspendLayout();

                        splitContainer3.Panel1.Controls.Clear();
                        splitContainer3.Panel1.Controls.Add(_paneles[0]);
                        _paneles[0].Dock = DockStyle.Fill;

                        splitContainer3.Panel2.Controls.Clear();
                        splitContainer3.Panel2.Controls.Add(_paneles[1]);
                        _paneles[1].Dock = DockStyle.Fill;

                        splitContainer3.ResumeLayout(false);
                        splitContainer3.PerformLayout();
                    }
                }

                _controladorTree.alActualizarListado(treeView1.SelectedNode);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("TREE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
                Cursor = Cursors.Default;
            }
        }

        #region helpers
        public void setSesiones(long sesiones) {
            lblSesiones.Text = string.Format("Cantidad de Sesiones: {0,5}", sesiones);
        }

        public void setGestiones(long gestiones) {
            lblGestiones.Text = string.Format("Cantidad de Gestiones: {0,5}", gestiones);
        }

        public void setTiempoGestion(TimeSpan tg) {
            lblTiempoGestion.Text = string.Format("Tiempo de Gestión: {0,5}:{1,2}:{2,2}", tg.Hours, tg.Minutes, tg.Seconds);
        }

        public void setTiempoInactivo(TimeSpan tg) {
            lblTiempoInactivo.Text = string.Format("Tiempo de Inactividad: {0,5}:{1,2}:{2,2}", tg.Hours, tg.Minutes, tg.Seconds);
        }
        #endregion helpers

        #region interfase
        /// <summary>
        /// Este método se ejecuta cuando se hace doble-click (y enter?)
        /// sobre un item del árbol de opciones de la ventana. Debería 
        /// 'mostrar' cualquier error que pudiese ocurrir y no propagar 
        /// ninguna excepción. Cada nodo del árbol que puede lanzar un
        /// caso de uso debería tener, en su atributo Tag, un texto con
        /// el nombre de dicho caso (aplicando el esquema dll.caso-de-uso
        /// de ser necesario) y si se desea pasar algún parametro (solo 
        /// puede ser una cadena), se puede pasar separando el mismo por
        /// dos puntos ':', por ejemplo: 
        ///     TAG: cuAbmGestion.cuListGestiones:TELEFONICA
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            TreeNode nodo = e.Node;

            // Si el nodo seleccionado no tiene info extra se vuelve
            if (nodo == null || nodo.Tag == null)
                return;

            // Se separa la cadena asociada al nodo seleccionado
            string[] textosNodo = nodo.Tag.ToString().Split(':');
            if (textosNodo[0] != null && textosNodo[0].StartsWith("cu"))
                try {
                    // Se obtiene cualquier cadena extra para pasar al listado
                    string llamado = (textosNodo.Length > 1)
                                         ? textosNodo[1]
                                         : "";

                    // Se avisa al controlador que se está por ejecutar un nodo
                    _controladorTree.alEjecutarNodo(nodo);

                    // Por las dudas avisa que va a ocultar los paneles que ya existan
                    if (_controladorListado != null)
                        _controladorListado.alOcultar();

                    // Se lanza el caso de uso de control del listado
                    _controladorListado =
                        (IControladorListTree)
                        (CUCaller.CallCU(textosNodo[0], this, new object[] {EModoVentana.FULL, llamado}));

                    // Actualiza la imagen del seleccionado
                    if (_nodoPrevio != null) {
                        _nodoPrevio.SelectedImageIndex = _imagenSPrevia;
                        _nodoPrevio.ImageIndex = _imagenNsPrevia;
                    }
                    _imagenSPrevia = nodo.SelectedImageIndex;
                    _imagenNsPrevia = nodo.ImageIndex;
                    _nodoPrevio = nodo;
                    nodo.SelectedImageIndex = _controladorTree.getImagenSeleccionado();
                    nodo.ImageIndex = _controladorTree.getImagenSeleccionado();
                    treeView1.Refresh();

                    // Se actualizan los paneles asociados al nodo actual
                    actualizarListado();

                    // Por las dudas avisa que acaba de mostrar los paneles
                    _controladorListado.alMostrar();
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("TREE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                }
        }

        /// <summary>
        /// Este método responde al evento Load de la ventana. Debería 
        /// 'mostrar' cualquier error que pudiese ocurrir y no propagar 
        /// ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void WinTreeConfig_Load(object sender, EventArgs e) {
            try {
                // esto es para refrescar los valores
                Sistema.Controlador.SecurityService.getSesion().iniciarActividad();
                Sistema.Controlador.SecurityService.getSesion().iniciarInactividad();

                // ahora si inicia la ventana
                Text = _controladorTree.getTitulo();
                _controladorTree.cargarTree(treeView1);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("TREE-NOK", ENivelMensaje.ERROR, e.ToString(), false);
                throw new VistaErrorException("TREE-NOK", ex.ToString());
            }
        }

        /// <summary>
        /// Se ejecuta despues de seleccionar un nodo y setea la ayuda en el panel.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param> 
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            string[] textos = treeView1.SelectedNode.Tag.ToString().Split(':');
            txtAyuda.Text = (treeView1.SelectedNode != null)
                                ? textos[(textos.Length - 1)]
                                : String.Empty;
        }

        /// <summary>
        /// Este método responde al cierre de la ventana. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void WinBandejaEntrada_FormClosing(object sender, FormClosingEventArgs e) {
            // Por las dudas avisa que va a ocultar los paneles que ya existan
            if (_controladorListado != null)
                _controladorListado.alOcultar();
        }

        /// <summary>
        /// Este método es un atajo al doble click.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            treeView1_NodeMouseDoubleClick(sender, e);
        }

        /// <summary>
        /// Este método se lanza cuando se muestra por primera ves la ventana. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void WinTreeConfig_Shown(object sender, EventArgs e) {
            treeView1.ExpandAll();
        }
        #endregion interfase
    }
}