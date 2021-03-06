﻿//  ETipoConector.cs
//  Implementation of the Enum ETipoConector
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:55:00 p.m.
//  Original author: Fernando
///////////////////////////////////////////////////////////
namespace sgmpro.enums {
    /// <summary>
    /// Representa una enumeracion del tipo de 
    /// conector de un predicado / Estrategia
    /// </summary>
    public class ETipoConector {
        public const string AND = " AND ";
        public const string NULL = " NULL ";
        public const string OR = " OR ";

        /// <summary>
        /// Devuelve la lista de todos los tipos.
        /// Se utiliza para cargar combos
        /// </summary>
        /// <returns></returns>
        public static object[] GetTodos() {
            return new object[] {NULL, AND, OR};
        }
    }
}