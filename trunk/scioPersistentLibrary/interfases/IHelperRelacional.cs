﻿///////////////////////////////////////////////////////////
//  IHelperORM.cs
//  Implementation of the Interface IHelperORM
//  Generated by Enterprise Architect
//  Created on:      10-Ene-2010 08:11:10 a.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
namespace scioPersistentLibrary.interfases {
    /// <summary>
    /// Esta interfaz permite generar clases que 'ayuden' a la clase EsquemaRelacional
    /// permitiendo incluir en el proyecto especifico los agregados para el manejo de
    /// las tablas relacionales, para los casos en que los accesos a datos deban hacerse 
    /// directamente via consultas relacionales.
    /// </summary>
    public interface IHelperRelacional {
        /// <summary>
        /// Este método debería devolver el prefijo para campos de la tabla,
        /// de manera de que el nomreb de cada campo de la tabla, en la base 
        /// de datos, se pueda armar con este prefijo + guinbajo + el nombre 
        /// del atributo dentro de la clase.
        /// </summary>
        string getPrefijo(string tabla);

        /// <summary>
        /// Este método debería devolver la lista de campos del select, con
        /// todos los campos y los nombres que se desean mostrar en un listado.
        /// </summary>
        string getSelectString(string tabla);      
    }
}