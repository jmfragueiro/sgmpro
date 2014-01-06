﻿///////////////////////////////////////////////////////////
//  IControladorListable.cs
//  Implementation of the Interface IControladorListable
//  Generated by Enterprise Architect
//  Created on:      15-Abr-2009 07:11:10 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using scioBaseLibrary.interfases;
using scioControlLibrary.enums;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.interfases;

namespace scioControlLibrary.interfaces {
    /// <summary>
    /// Interfase que hereda de IControladorCasoUso y representa el comportamiento 
    /// deseable de una clase que gestiona y controla algún tipo de lista de objetos 
    /// de una entidad vía un listado y que permite la edición ABMV (agregar, borrar, 
    /// modificar, mostrar) sobre las instancias listadas, como así también (opcional)
    /// mostrar un preview de cada instancia al seleccionarla del listado.
    /// </summary>
    public interface IControladorListable<T> : IControladorCasoUso where T : EntidadIdentificada<T> {
        /// <summary>
        /// Esta propiedad es la que debe contener a los elementos Order 
        /// (de NHibernate), por los cuales cual se desearía ordenar la 
        /// lista.
        /// </summary>
        IList<IOrdenConsulta> Ordenamiento { get; set; }
        /// <summary>
        /// Esta propiedad es la que debe contener al arreglo de criterios
        /// de filtro para la lista. Los criterios se forman con.
        /// </summary>
        IList<ICriterioConsulta> Filtros { get; set; }
        /// <summary>
        /// La lista de columnas que no deberán mostrarse en el listado.
        /// </summary>
        List<string> ColsInvisibles { get; set; }
        /// <summary>
        /// El modo en que se debe ejecutar (o se encuentra ejecutando la 
        /// vista asociada al controlador).
        /// </summary>
        EModoVentana ModoVista { get; set; }
        /// <summary>
        /// El modo en que debe trabajarse el listado de elementos, como
        /// si debe generarse directamente el datatable desde un select
        /// o bien desde un list de objetos.
        /// </summary>
        EModoListado ModoListado { get; set; }
        /// <summary>
        /// Esta propiedad es la que debe contener el objeto que actúa como
        /// master (y como filtro base), en caso de que exista uno cuando se 
        /// trata de un listado que actúa como detail de un master (por eje: 
        /// el listado de contactos de una persona que se lista al mostrarse 
        /// la persona). Si el listado no es detail, y si no tiene un master 
        /// entonces no contienen nada (null).
        /// </summary>
        IEntidadIdentificable ObjetoMaster { get; set; }
        /// <summary>
        /// Esta propiedad es la que debe contener al IControladorEditable,
        /// es decir a la interfaz de manejo ABMV para un elemento, en caso 
        /// de que exista uno, cuando un listado puede decantar en un panel 
        /// de edición (via un listEdit, listAdd, etc.).
        /// </summary>
        IControladorEditable<T> ControlEditable { get; set; }
        /// <summary>
        /// La cuenta de la cantidad de registros contenidos en el objeto
        /// datasource del listado (basado en ultima búsqueda -listList-).
        /// </summary>
        long Cuenta { get; set; }

        /// <summary>
        /// Este método es el encargado de generar, y devolver, un panel
        /// de listado listo para mostrar y utilizar dentro de cualquier 
        /// ventana, lo que implicaría crear el panel propiamente dicho, 
        /// setear el Modo de Vista del controlador (que afecta al propio 
        /// panel) y finalmente refrescar los datos que este posee para
        /// desplegar un listado actualizado.
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        /// <returns>
        /// Un panel de listado listo para usar (ggg).
        /// </returns>
        PanelListABMV<T> getPanelListado(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de generar y devolver un criterio
        /// de filtro (en este caso de NHibernate) que permita asociar al 
        /// propio listado al su master (ObjetoMaster) que ha sido seteado 
        /// para el listado (en caso de tomarse al listado como un detail).
        /// </summary>
        /// <returns>
        /// Un criterio de filtro de NHibernate.
        /// </returns>
        ICriterioConsulta getFiltroMaster();

        /// <summary>
        /// Este método es el encargado de ejecutar las operaciones que
        /// sean necesarias al momento de cambiarse la fila actual dentro 
        /// del listado.
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void alActualizarFila(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de manejar el cambio en la selección
        /// de las filas dentro del listado (por ejemplo: puede ser llamado
        /// por un panel de listado al cambiar la selección dentro del mismo).
        /// Debe lanzar VistaErrorException si tiene problemas.
        /// </summary>
        /// <param name="seleccion">
        /// La colección de filas seleccionadas en el listado.
        /// </param>
        void alActualizarSeleccion(DataGridViewSelectedRowCollection seleccion);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de abrir
        /// el panel de listado.
        /// </summary>
        void listOpen(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Listar
        /// todos los elementos del tipo del objeto pertinente (esto puede 
        /// ser, por ejemplo, generar un binding source desde la base de
        /// persistencia con todas las instancias de dicha entidad) que 
        /// pueda ser activada desde la interfaz pertinente. Debe trabajar 
        /// sobre la lista de objetos del tipo de la entidad en cuestión.
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        /// <returns>
        /// Un binding source asociado a la lista de objetos a listar.
        /// </returns>
        BindingSource listList(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Ver
        /// un elemento desde el listado. Debe trabajar sobre el tipo
        /// de objeto del tipo de la entidad en cuestión, dependiendo
        /// de sus métodos (y lanzando sus excepciones).
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void listView(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Agregar
        /// un elemento desde el listado. Debe trabajar sobre el tipo
        /// de objeto del tipo de la entidad en cuestión, dependiendo
        /// de sus métodos (y lanzando sus excepciones).
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void listAdd(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Editar
        /// un elemento desde el listado. Debe trabajar sobre el tipo
        /// de objeto del tipo de la entidad en cuestión, dependiendo
        /// de sus métodos (y lanzando sus excepciones).
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void listEdit(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Borrar
        /// un elemento desde el listado. Debe trabajar sobre el tipo
        /// de objeto del tipo de la entidad en cuestión, dependiendo
        /// de sus métodos (y lanzando sus excepciones).
        /// </summary>
        /// <param name="parametros">
        /// Un vararg que acepta parametros que puedan necesitarse.
        /// </param>
        void listRemove(params object[] parametros);

        /// <summary>
        /// Este método es el encargado de gestionar la acción de Ayuda.
        /// </summary>
        void listHelp();

        /// <summary>
        /// Este método es el encargado de gestionar la acción de cerrar
        /// el control de usuario.
        /// </summary>
        void listClose(params object[] parametros);

        /// <summary>
        /// Este método debería retornar un objeto del tipo que maneja el 
        /// controlador a partir de una fila de datos de la tabla que se
        /// muestra en el listado. Es por si se utiliza un BindingSource
        /// asociado a un DataTable en lugar de a un IList.
        /// </summary>
        /// <param name="row">
        /// La fila de datos deseada como origen del objeto.
        /// </param>
        /// <returns>
        /// El objeto del tipo correcto generado a partir de la fila.
        /// </returns>
        T getObjectFromDataRow(DataRow row);
    }
}