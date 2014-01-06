﻿///////////////////////////////////////////////////////////
//  CriterioConsulta.cs
//  Implementation of the Class CriterioConsulta
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using NHibernate.Criterion;
using scioPersistentLibrary.interfases;

namespace scioPersistentLibrary.criterios {
    /// <summary>
    /// Esta es la clase base de la jerarquía que implementa, vía la interfase
    /// ICriterioConsulta, el concepto de un criterio de consulta abstraído de 
    /// la capa de peristencia real del sistema, permitiendo hacia abajo utilizar 
    /// distintos mecanismos.
    /// </summary>
    public abstract class CriterioConsulta : ICriterioConsulta {
        #region Implementation of ICriterioConsulta
        public virtual string getCriterioSQL() {
            return getCriterioSQL(null);
        }

        public abstract string getCriterioSQL(string prefijo);

        public abstract ICriterion getCriterioNH();
        #endregion
    }
}