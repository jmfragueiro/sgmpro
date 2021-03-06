﻿///////////////////////////////////////////////////////////
//  Productos.cs
//  Implementation of the Class Productos
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:55:00 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using System.Collections.Generic;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.criterios;

namespace sgmpro.dominio.configuracion.repos {
    /// <summary>
    /// Esta clase representa al Repositorio de persistencia
    /// de Nhibernate para la entidad Producto del sistema.
    /// </summary>
    public class Productos : RepositorioPersistente<Producto> {
        /// <summary>
        /// Este método devuelve un Producto según su codigo.
        /// </summary>
        /// <param name="codigo">
        /// El codigo del Producto deseado.
        /// </param>
        /// <returns>
        /// El Producto que coincide con el codigo proporcionado.
        /// </returns>
        public static Producto GetByCodigo(string codigo) {
            return GetUniqueByCriteria(true, new[] {Criterios.Igual("Codigo", codigo)});
        }

        /// <summary>
        /// Este método ordena un conjunto de Pagos según su fecha 
        /// pero en forma ascendente (primero van los mas viejos).
        /// </summary>
        /// <param name="origen">
        /// El conjunto de Pagos a ordenar.
        /// </param>
        /// <returns>
        /// El conjunto de Pagos ordenado por fecha (ascendente).
        /// </returns>
        public static IList<Tramo> OrdenarPorLimite(IList<Tramo> origen) {
            Tramo temp = new Tramo();
            IList<Tramo> conjunto = new List<Tramo>();

            while (conjunto.Count < origen.Count) {
                long piso = 999999999;
                foreach (Tramo obj in origen)
                    if (!conjunto.Contains(obj))
                        if (obj.Limite < piso) {
                            piso = obj.Limite;
                            temp = obj;
                        }
                conjunto.Add(temp);
            }

            return conjunto;
        }
    }
}