﻿///////////////////////////////////////////////////////////
//  IControladorEditable.cs
//  Implementation of the Interface IControladorEditable
//  Generated by Enterprise Architect
//  Created on:      15-Abr-2009 07:11:10 p.m.
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System.Drawing;
using scioBaseLibrary.interfases;
using scioControlLibrary.enums;
using scioPersistentLibrary.acceso;

namespace scioControlLibrary.interfaces {
    /// <summary>
    /// Interfase que representa el comportamiento deseable de una clase
    /// que gestiona y controla algún tipo de interfaz de usuario y que 
    /// permite la edición ABMV (agregar, borrar, modificar, ver) de una 
    /// entidad del sistema dentro de un panel tipo (generico).
    /// </summary>
    public interface IControladorEditable<T> : IControladorCasoUso where T : EntidadIdentificada<T> {
        /// <summary>
        /// El panel que representa a la interfaz de usuario que se controla.
        /// </summary>
        PanelABMV<T> PanelEdicion { get; set; }
        /// <summary>
        /// El modo en que se debe ejecutar (o se encuentra ejecutando la 
        /// vista asociada al controlador).
        /// </summary>
        EModoVentana ModoVista { get; set; }
        /// <summary>
        /// Esta propiedad es la que debe contener al objeto específico
        /// que se está gestionando via la interfaz de usuario pertinente.
        /// </summary>
        T ObjetoEnEdicion { get; set; }

        /// <summary>
        /// Este método es el encargado de generar y devolver un panel
        /// de edición listo para utilizar dentro de cualquier ventana,
        /// lo que implica crear el panel propiamente dicho, asignarle
        /// el objeto en edición actual y setear el Modo de Vista del 
        /// controlador (lo que debe afectar al modo del propio panel).
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        /// <returns>
        /// Un panel de edición listo para usar (ggg).
        /// </returns>
        PanelABMV<T> getPanelEdicion(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de instanciar un panel de edición 
        /// de la jerarquia de PanelABMV, y debiera sobrepasarse para cada 
        /// caso particular.
        /// </summary>
        /// <returns>
        /// Una instancia de un panel de edición ABMV.
        /// </returns>
        PanelABMV<T> crearPanelEdicion();

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Agregar
        /// un elemento (esto puede ser, por ejemplo, hacer persistente a
        /// una instancia de un objeto entidad) que pueda ser activada de
        /// la ui pertinente. Debería trabajar sobre el objeto en edición.
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void add(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Editar
        /// un elemento (esto puede ser, por ejemplo, mostrar sus datos 
        /// en la propia interfaz o una nueva y permitir la edicion de los
        /// mismos) que pueda ser activada de la interfaz pertinente. Debe 
        /// trabajar sobre el objeto en edición. 
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void edit(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Borrar
        /// un elemento (esto puede ser, por ejemplo, eliminar de la base
        /// de persistencia a una instancia de un objeto entidad) que pueda 
        /// ser activada de la interfaz pertinente. Debe trabajar sobre el 
        /// objeto en edición. 
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void remove(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de guardar
        /// las modificaciones sobre un elemento (esto puede ser, por ejem,
        /// en la base de persistencia) que pueda ser activada de la interfaz 
        /// pertinente. Debe trabajar sobre el objeto en edición. 
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void save(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Ayuda para
        /// el panel en particular.
        /// </summary>
        void help();

        /// <summary>
        /// Este método se debe encargar de verificar los datos ingresados
        /// o editados en el panel, antes de guardarlos, para asegurar su 
        /// validez. Además debería mostrar un mensaje en caso de un error. 
        /// Debería lanzar una DataErrorExcetion si algún dato no es válido.
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void verify(params object[] parametros);

        /// <summary>
        /// Este método se debe encargar del cierre del controlador.
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void close(params object[] parametros);

        /// <summary>
        /// Este método debería devolver el titulo para la ventana que
        /// contiene al panel.
        /// </summary>
        /// <returns>
        /// Una cadena con el título de la ventana contenedora.
        /// </returns>
        string getTitulo();

        /// <summary>
        /// Este método debería devolver el icono para la ventana que
        /// contiene al panel.
        /// </summary>
        /// <returns>
        /// Un objeto que representa al icono para la ventana contenedora.
        /// </returns>
        Icon getIcono();
    }
}