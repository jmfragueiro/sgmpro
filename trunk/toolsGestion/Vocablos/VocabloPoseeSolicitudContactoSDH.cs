using System;
using scioPersistentLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    internal class VocabloPoseeSolicitudContactoSDH : Vocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo
        /// para el objeto definido.
        /// Debe ser redefinido en cada clase.
        /// </summary>
        /// <param name="unObj">El objeto que se pretende Evaluar</param>
        /// <param name="unCriterio">Criterio que se evaluará (ej.<=,=,<>)</param>
        /// <param name="unValor">Valor que se comparará con el valor del Vocablo</param>
        /// <returns>Resultado de la evaluación</returns>
        public override bool Evaluar(object unObj, string unCriterio, string unValor) {
            _dt = null;

            string select =
                "select ges_resultadofecha as resultado" +
                "  from gestion" +
                " where ges_cuenta      = '" + unObj + "'" +
                "   and ges_resultado   = '" + _solicita + "'" +
                "   and ges_estado      = '" + _finalizada + "'" +
                "   and ges_resultadofecha > convert(datetime, '1753-01-01 00:00:000', 121)" +
                "   and ges_fechabaja   = convert(datetime, '1753-01-01 00:00:000', 121)" +
                "   and ges_fechaanulacion = convert(datetime, '1753-01-01 00:00:000', 121)" +
                "   and ges_fechacierre = " +
                "        (select max(ges_fechacierre)" +
                "          from gestion" +
                "          where ges_cuenta = '" + unObj + "'" +
                "            and ges_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)" +
                "            and ges_fechaanulacion = convert(datetime, '1753-01-01 00:00:000', 121)" +
                "            and ges_estado      = '" + _finalizada + "')";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 &&
                   Comparar(((DateTime)_dt.Rows[0]["resultado"]).Date,
                       unCriterio,
                       Fechas.ToDiaHabil(DateTime.Now.AddDays(1)).Date));
        }
    }
}