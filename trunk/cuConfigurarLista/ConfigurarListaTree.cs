﻿///////////////////////////////////////////////////////////
//  ConfigurarListaTree.cs
//  Clase de control para el tree configurar Listas.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Windows.Forms;
using cuConfigurarListas.Properties;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary.dominio.repos;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuConfigurarListas {
    public class ConfigurarListaTree : IControladorTree {
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
        public ConfigurarListaTree() {
            _tree = NodoTrees.GetRaizByDescripcion("Configuración de Listas").getTree();
            _listaImagenes = new ImageList();
            _listaImagenes.Images.Add(Resources.world);
            _listaImagenes.Images.Add(Resources.tiposlistas);
            _listaImagenes.Images.Add(Resources.estrategias);
            _listaImagenes.Images.Add(Resources.vars);
            _listaImagenes.Images.Add(Resources.listas);
            _listaImagenes.Images.Add(Resources.arrow_right);
        }

        #region Implementation of IControladorTree
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public TreeNode getTree() {
            return _tree;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
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
            return Mensaje.TextoMensaje("TITULO-CONFIG-LISTA");
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public Icon getIcono() {
            return Resources.cfglista;
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