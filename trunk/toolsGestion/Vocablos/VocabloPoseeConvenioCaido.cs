using System;
using scioPersistentLibrary;
using sgmpro.dominio.configuracion;
using sgmpro.enums;

namespace toolsGestion.Vocablos {
    public class VocabloPoseeConvenioCaido : Vocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo
        /// para el objeto definido.
        /// Debe ser redefinido en cada clase.
        /// </summary>
        /// <param name="unObj">El objeto que se pretende Evaluar</param>
        /// <param name="unCriterio">Criterio que se evaluar� (ej.<=,=,<>)</param>
        /// <param name="unValor">Valor que se comparar� con el valor del Vocablo</param>
        /// <returns>Resultado de la evaluaci�n</returns>
        public override bool Evaluar(object unObj, string unCriterio, string unValor) {
            _dt = null;

            string select =
                "select count(cvn_id) as resultado" +
                "  from convenio" +
                " where cvn_cuenta = '" + unObj + "'" +
                "   and cvn_fechabaja > convert(datetime, '1753-01-01 00:00:000', 121)";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 &&
                    unValor.Equals((((int)_dt.Rows[0]["resultado"]) > 0)
                                       ? ESiNo.SI
                                       : ESiNo.NO));
        }
    }
}