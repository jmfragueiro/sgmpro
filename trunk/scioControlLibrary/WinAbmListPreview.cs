﻿///////////////////////////////////////////////////////////
//  WinAbmJob.cs
//  Implementation of the Class WinAbmJob.
//  Generated by Fernando
//  Created on:      13-abr-2009 17:23:41
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace scioControlLibrary {
    public partial class WinAbmListPreview<T> : Form, IVistaContenedor where T : EntidadIdentificada<T> {
        /// <summary>
        /// Este atributo es el controlador para el listado/preview de la 
        /// ventana y para gestionar las operaciones ABMV sobre la entidad.
        /// </summary>
        private readonly IControladorPreview<T> _controlador;
        /// <summary>
        /// Este atributo referencia a los paneles que se utilizan.
        /// </summary>
        private UserControl[] _paneles;

        /// <summary>
        /// Constructor por default
        /// </summary>
        public WinAbmListPreview(IControladorPreview<T> controlador) {
            if (controlador == null)
                throw new VistaErrorException("VISTA-NOREADY");

            try {
                InitializeComponent();

                // Establece el controlador para la ventana
                _controlador = controlador;
                _controlador.Padre = this;

                // Establece el título y el icono de la ventana
                Icon = _controlador.getIcono();
                Text = string.Format(
                    "{0} - {1}",
                    Mensaje.TextoMensaje("TITULO-SHOW"),
                    _controlador.getTitulo());
            } catch (Exception e) {
                Sistema.Controlador.mostrar("VISTA-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                throw new VistaErrorException("VISTA-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método devuelve el controlador asociado a la instancia.
        /// </summary>
        /// <returns>
        /// El controlador asociado a la ventana.
        /// </returns>
        public IControladorPreview<T> getControlador() {
            return _controlador;
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
        private void WinAbmPagos_Load(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("UPDATE-DATAPANEL"));
            try {
                actualizarListado();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("VISTA-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                Close();
            } finally {
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Este método responde al click del botón closer de la ventnana
        /// para cerrar la misma ante una presión de ESC.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnCloser_Click(object sender, EventArgs e) {
            Close();
        }

        #region Implementation of IVistaContenedor
        /// <summary>
        /// Este método es el encargado de actualizar la ventana
        /// para mostrar a la derecha lo que se corresponda con el
        /// item del árbol seleccionado.
        /// </summary>
        public void actualizarListado() {
            try {
                Cursor = Cursors.WaitCursor;
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("UPDATE-LISTPANEL"));

                if (_controlador != null) {
                    _paneles = _controlador.getPanelesTree();

                    if (_paneles.Length == 2) {
                        splitContainer3.SuspendLayout();

                        splitContainer3.Panel1.Controls.Clear();
                        splitContainer3.Panel1.Controls.Add(_paneles[0]);
                        _paneles[0].Dock = DockStyle.Fill;
                        if (_paneles[0] is IVistaPanelList)
                            ((IVistaPanelList)_paneles[0]).Contenedor = this;

                        splitContainer3.Panel2.Controls.Clear();
                        splitContainer3.Panel2.Controls.Add(_paneles[1]);
                        _paneles[1].Dock = DockStyle.Fill;
                        if (_paneles[1] is IVistaPanelList)
                            ((IVistaPanelList)_paneles[1]).Contenedor = this;

                        splitContainer3.ResumeLayout(false);
                        splitContainer3.PerformLayout();
                    }
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("TREE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Este método es el que le dice al contenedor de una vista 
        /// que el usuario a determinado que la misma debe cerrarse.
        /// </summary>
        public void cerrar() {
            Close();
        }

        /// <summary>
        /// Implementa el método de la interface.
        /// </summary>
        public virtual void setModoVista() {}

        /// <summary>
        /// Implementa el método de la interface.
        /// </summary>
        public virtual void guardarDatos() {}

        /// <summary>
        /// Implementa el método de la interface.
        /// </summary>
        public virtual void actualizarDatos() {}
        #endregion
    }
}