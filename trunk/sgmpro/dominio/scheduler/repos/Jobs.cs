﻿///////////////////////////////////////////////////////////
//  Jobs.cs
//  Implementation of the Class Jobs
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:55:00 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using scioParamLibrary.dominio.repos;
using scioBaseLibrary;
using scioToolLibrary.enums;
using System;
using scioPersistentLibrary;

namespace sgmpro.dominio.scheduler.repos {
    /// <summary>
    /// Esta clase representa al Repositorio de persistencia
    /// de Nhibernate para la entidad Job del sistema.
    /// </summary>
    public class Jobs {
        /// <summary>
        /// Obtiene una lista con los ID de los jobs que estan listos para ejecución
        /// y dentro del intervalo con centro en DateTime.Now() y establecido por el 
        /// atributo ValorLong del parametro [GESTION.INTERVALOJOBS] (en mas y menos).
        /// </summary>
        /// <returns>
        /// Retorna un datatable con un registro por id de job ejecutable, o null si 
        /// no encuentra nada.
        /// </returns>
        public static DataTable SelectIdsJobsEjecutables() {
            Sistema.Controlador.logear("JOBRUN-VERIFY", ENivelMensaje.INFORMACION, null);
            
            long diff = Parametros.GetByClave("GESTION.INTERVALOJOBS").Valorlong;
            Sistema.Controlador.logear("JOBRUN-TIMEWIN", ENivelMensaje.INFORMACION, diff + " minutos(+-).");

            DateTime minimo = DateTime.Now.AddMinutes(-diff);
            DateTime maximo = DateTime.Now.AddMinutes(diff);
            string sql = " select job_id as job ";
            sql += "  from job ";
            sql += " where job_siguiente >= '" + minimo + "'";
            sql += "   and job_siguiente <= '" + maximo + "'";
            sql += "   and job_activo     = 1";
            sql += "   and job_ejecutando = 0";
            sql += "   and job_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)";
            DataTable dt = Persistencia.EjecutarSqlSelect(sql, Persistencia.Controlador.CadenaConexion);
            Sistema.Controlador.logear("JOBRUN-COUNT", ENivelMensaje.INFORMACION, dt.Rows.Count.ToString());

            return dt;
        }

        /// <summary>
        /// Verifica si hay algun job corriendo.
        /// </summary>
        /// <returns>
        /// Retorna true si hay un job corriendo o false si no.
        /// </returns>
        public static bool HayJobCorriendo() {
            // verifica si hay algun job corriendo
            Sistema.Controlador.logear("JOBRUN-EXIST-VERIFY", ENivelMensaje.INFORMACION, null);
            const string sql = "select max(isnull(job_ejecutando, 0)) as jobexe from job";
            object[] res = Persistencia.EjecutarSqlOneRow(sql, Persistencia.Controlador.CadenaConexion);
            return (res != null && res.Length > 0 && res[0] is int && ((int)res[0] > 0));
        }
    }
}