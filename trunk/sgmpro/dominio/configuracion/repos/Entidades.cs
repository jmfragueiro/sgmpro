///////////////////////////////////////////////////////////
//  Entidades.cs
//  Implementation of the Class Entidades
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:55:00 p.m.
//  Original author: Fernando
///////////////////////////////////////////////////////////
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.criterios;

namespace sgmpro.dominio.configuracion.repos {
    /// <summary>
    /// Esta clase representa al Repositorio de persistencia
    /// de Nhibernate para la entidad Entidad del sistema.
    /// </summary>
    public class Entidades : RepositorioPersistente<Entidad> {
        /// <summary>
        /// Este m�todo devuelve una Entidad seg�n su codigo.
        /// </summary>
        /// <param name="codigo">
        /// El codigo de la entidad deseada.
        /// </param>
        /// <returns>
        /// La entidad que coincide con el codigo proporcionado.
        /// </returns>
        public static Entidad GetByCodigo(string codigo) {
            return GetUniqueByCriteria(false, new[] {Criterios.Igual("Codigo", codigo)});
        }
    }
}