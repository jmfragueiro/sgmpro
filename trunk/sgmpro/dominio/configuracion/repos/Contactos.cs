﻿///////////////////////////////////////////////////////////
//  Contactos.cs
//  Implementation of the Class Contactos
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:55:00 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using scioPersistentLibrary.acceso;
using scioToolLibrary;

namespace sgmpro.dominio.configuracion.repos {
    /// <summary>
    /// Esta clase representa al Repositorio de persistencia
    /// de Nhibernate para la entidad Contacto del sistema.
    /// </summary>
    public class Contactos : RepositorioPersistente<Contacto> {
        /// <summary>
        /// Este método ordena un conjunto de contactos según su fecha de 
        /// actualizacion pero en forma descendente (primero van los mas nuevos).
        /// </summary>
        /// <param name="origen">
        /// El conjunto de deudas a ordenar.
        /// </param>
        /// <returns>
        /// El conjunto de deudas ordenado por fecha de inicio (descendente).
        /// </returns>
        public static IList<Contacto> OrdenarPorFechaActDesc(IList<Contacto> origen) {
            IList<Contacto> conjunto = new List<Contacto>();
            Contacto temp = new Contacto();

            while (conjunto.Count < origen.Count) {
                DateTime piso = Fechas.FechaNull.AddYears(-99);
                foreach (Contacto obj in origen)
                    if (!conjunto.Contains(obj))
                        if (obj.FechaUMod > piso) {
                            piso = obj.FechaUMod;
                            temp = obj;
                        }
                conjunto.Add(temp);
            }

            return conjunto;
        }
    }
}