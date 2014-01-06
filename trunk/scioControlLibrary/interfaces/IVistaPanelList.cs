﻿///////////////////////////////////////////////////////////
//  IPublicPanelList.cs
//  Implementation of the Interface IPublicPanelList
//  Generated by Enterprise Architect
//  Created on:      15-Abr-2009 07:11:10 p.m.
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Windows.Forms;
using scioControlLibrary.enums;

namespace scioControlLibrary.interfaces {
    /// <summary>
    /// Interfase que representa el comportamiento público generico deseable 
    /// de una clase que implementa un panel de listado de una entidad del 
    /// sistema.
    /// </summary>
    public interface IVistaPanelList {
        /// <summary>
        /// Este método es el encargado de devolver el componente visual 
        /// padre del panel (el Parent).
        /// </summary>
        IVistaContenedor Contenedor { get; set; }

        /// <summary>
        /// Este método permite acceder al control específico dentro del
        /// cual se está efectivamente mostrando el listado (por ejemplo
        /// un datagridview en C#.Net).
        /// </summary>
        /// <returns>
        /// El control de interface de usuario especifico que muestra el listado.
        /// </returns>
        object getControlListado();

        /// <summary>
        /// Este metodo debería ejecutarse al mostrar el listado.
        /// </summary>
        void alMostrar(params object[] parametros);

        /// <summary>
        /// Este metodo debería ejecutarse al ocultar el listado.
        /// </summary>
        void alOcultar(params object[] parametros);

        /// <summary>
        /// Este método refresca el listado del panel con los datos que 
        /// devuelve el método list() del controlador del listado -debe 
        /// tener datos frescos-. Además, el método permite ocultar las 
        /// columnas cuyos titulos vienen en el List nocols.
        /// </summary>
        /// <param name="nocols">
        /// La lista de nombres de columnas que no se deben mostrar.
        /// </param>
        void refrescarListado(List<string> nocols);

        /// <summary>
        /// Este método permtie establecer el valor de multiselección
        /// del panel asociado al listado actual.
        /// </summary>
        /// <param name="setear">
        /// El valor 'true' para permitir multiselección o, si no, 'false'.
        /// </param>
        void setMultiSelect(bool setear);

        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        void setModoVista();

        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        void setModoVista(EModoVentana modo);

        /// <summary>
        /// Este método retorna la colección de filas del datagridview.
        /// </summary>
        /// <returns>
        /// Una colección con todas las filas del datagridview.
        /// </returns>
        DataGridViewRowCollection getRows();

        /// <summary>
        /// Este método devuelve el objeto actual, es decir el objeto que
        /// está asociado a la fila actualmente seleccionada en la lista,
        /// pero como un Object y no como del tipo T. Asi se imlpementa
        /// la interfaz IVistaPanel. Si no hay una fila seleccionada, 
        /// entonces devuelve un null.
        /// </summary>
        /// <returns>
        /// El objeto actual para el listado como un object.
        /// </returns>
        object getObjectActual();

        /// <summary>
        /// Este método debe encargarse de aplicar los permisos que existan 
        /// para el usuario actual sobre botones de un panel de listado, para 
        /// lo cual verifica los permisos existentes para el usuario actual 
        /// contra los botones del listado (los permisos o los strings de la 
        /// propiedad Tag de cada botón). Si no hay permiso debe invisibilizar 
        /// el botón.
        /// </summary>
        /// <param name="recurso">
        /// El nombre del recurso a verificar cuando es un botón estandar.
        /// </param>
        /// <param name="contenedor">
        /// El contenedor que tiene los botones del listado.
        /// </param>
        void aplicarListPermisos(ToolStrip contenedor, string recurso);
    }
}