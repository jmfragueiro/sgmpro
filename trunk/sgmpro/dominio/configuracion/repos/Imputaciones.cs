﻿///////////////////////////////////////////////////////////
//  Deudas.cs
//  Implementation of the Class Deudas
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:55:00 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using System.Collections.Generic;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.orden;

namespace sgmpro.dominio.configuracion.repos {
    /// <summary>
    /// Esta clase representa al Repositorio de persistencia
    /// de Nhibernate para la entidad Imputación (de un pago)
    /// del sistema.
    /// </summary>
    public class Imputaciones : RepositorioPersistente<Imputacion> {
        /// <summary>
        /// Este método devuelve un listado las imputaciones de un
        /// pago determinado sobre las deudas.
        /// </summary>
        /// <param name="pago">
        /// El pago del que se desean las imputaciones.
        /// </param>
        /// <returns>
        /// El listado de imputaciones del pago deseado.
        /// </returns>
        public static IList<Imputacion> GetByPago(Pago pago) {
            return GetByCriteria(
                true,
                new[] {Criterios.Igual("Pago", pago)},
                new[] {Orden.Asc("Fecha")});
        }
    }
}