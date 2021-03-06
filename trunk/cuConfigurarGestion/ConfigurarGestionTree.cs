﻿///////////////////////////////////////////////////////////
//  ConfigurarGestionTree.cs
//  Clase de control para el tree configurar gestión.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Windows.Forms;
using cuConfigurarGestion.Properties;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary.dominio.repos;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuConfigurarGestion {
    public class ConfigurarGestionTree : IControladorTree {
        /// <summary>
        /// Atributo que contiene al árbol asociado a la instancia.
        /// </summary>
        private readonly TreeNode _tree;
        /// <summary>
        /// Lista de Imágenes para los iconitos del árbol
        /// </summary>
        private readonly ImageList _listaImagenes;

        /// <summary>
        /// Contructor de la clase que inicializa el árbol asociado
        /// y la lista de imagenes que se utilizará dentro del tree.
        /// </summary>
        public ConfigurarGestionTree() {
            _tree = NodoTrees.GetRaizByDescripcion("Datos de Gestión").getTree();
            _listaImagenes = new ImageList();
            _listaImagenes.Images.Add(Resources.world);
            _listaImagenes.Images.Add(Resources.entidad);
            _listaImagenes.Images.Add(Resources.persona);
            _listaImagenes.Images.Add(Resources.telefono);
            _listaImagenes.Images.Add(Resources.convenio);
            _listaImagenes.Images.Add(Resources.arrow_right);
        }

        #region Implementation of IControladorTree
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        /// <returns>
        /// Devuelve el nodo raiz del árbol con todas sus hojas.
        /// </returns>
        public TreeNode getTree() {
            return _tree;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        /// <returns>
        /// Devuelve la lista de imágenes asociada al árbol.
        /// </returns>
        public ImageList getImagenesTree() {
            return _listaImagenes;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public int getImagenSeleccionado() {
            return 5;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void alEjecutarNodo(TreeNode nodo) {}

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void alActualizarListado(TreeNode nodo) {}

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public EModoVentana getModoVista(TreeNode nodo) {
            return EModoVentana.LIST;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public string getTitulo() {
            return Mensaje.TextoMensaje("TITULO-CONFIG-GESTION");
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public Icon getIcono() {
            return Resources.cfggestion;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void cargarTree(TreeView vista) {
            try {
                vista.Nodes.Add(getTree());
                vista.ImageList = getImagenesTree();
            } catch (Exception e) {
                Sistema.Controlador.logear("PANEL-NOK", ENivelMensaje.ERROR, e.ToString());
                throw new VistaErrorException("TREE-NOK");
            }
        }
        #endregion
    }
}