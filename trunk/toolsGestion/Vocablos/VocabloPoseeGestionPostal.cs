using scioPersistentLibrary;
using sgmpro.dominio.configuracion;
using sgmpro.enums;

namespace toolsGestion.Vocablos {
    internal class VocabloPoseeGestionPostal : Vocablo {
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
                "select g.ges_id as resultado" +
                "  from gestion g" +
                " where g.ges_cuenta         = '" + unObj + "'" +
                "   and g.ges_estado         in ('" + _finalizada + "','" + _enproceso + "')" +
                "   and g.ges_resultado      = '" + _postal + "'" +
                "   and g.ges_fechacierre    > convert(datetime, '1753-01-01 00:00:000', 121)" +
                "   and g.ges_fechabaja      = convert(datetime, '1753-01-01 00:00:000', 121)" +
                "   and g.ges_fechaanulacion = convert(datetime, '1753-01-01 00:00:000', 121)";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (unValor.Equals((_dt != null && _dt.Rows.Count > 0) ? ESiNo.SI : ESiNo.NO));
        }
    }
}