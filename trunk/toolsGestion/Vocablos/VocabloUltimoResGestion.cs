using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Compara según el resultado de la ultima gestion de la cuenta 
    /// dentro del sistema.
    /// </summary>
    public class VocabloUltimoResGestion : Vocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo para el objeto definido.
        /// </summary>
        public override bool Evaluar(object unObj, string unCriterio, string unValor) {
            _dt = null;

             string select =
                "select par_nombre as resultado" + 
                "  from parametro " +
                " where par_id = " +
                "(select g.ges_resultado " +
                "   from gestion g " +
                "  where g.ges_cuenta         = '" + unObj + "' " +
                "    and g.ges_estado         = '" + _finalizada + "' " +
                "    and g.ges_fechacierre    > convert(datetime, '1753-01-01 00:00:000', 121)  " +
	            "    and g.ges_fechabaja      = convert(datetime, '1753-01-01 00:00:000', 121) " +
	            "    and g.ges_fechaanulacion = convert(datetime, '1753-01-01 00:00:000', 121) " +
	            "    and g.ges_fechacierre    =  " +
                "(select max(f.ges_fechacierre) " +
                "   from gestion f " +
                "  where f.ges_cuenta         = '" + unObj + "' " +
                "    and f.ges_estado         = '" + _finalizada + "' " +
                "    and f.ges_fechacierre    > convert(datetime, '1753-01-01 00:00:000', 121)  " +
	            "    and f.ges_fechabaja      = convert(datetime, '1753-01-01 00:00:000', 121) " +
	            "    and f.ges_fechaanulacion = convert(datetime, '1753-01-01 00:00:000', 121))) ";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0
                    && Comparar(_dt.Rows[0]["resultado"].ToString(), unCriterio, unValor));
        }
    }
}