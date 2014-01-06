using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Verifica el Tipo del último pago de una cuenta.
    /// </summary>
    public class VocabloUltimoTipoPago : Vocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo para el objeto definido.
        /// </summary>
        public override bool Evaluar(object unObj, string unCriterio, string unValor) {
            _dt = null;

            string select = "select r.par_nombre as resultado" + 
                            "  from pago p, parametro r" +
                            " where r.par_id         = p.pag_tipo " +
                            "   and p.pag_cuenta     = '" + unObj + "' " + 
                            "   and p.pag_estado     = '" + _aplicado + "' " + 
                            "   and p.pag_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)" +
                            "   and p.pag_fecha      = (select max(t.pag_fecha) " +
                            "                             from pago t" +
                            "                            where t.pag_cuenta     = p.pag_cuenta" +
                            "                              and t.pag_estado     = '" + _aplicado + "' " +
                            "                              and t.pag_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121))";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 && Comparar(_dt.Rows[0]["resultado"].ToString(), unCriterio, unValor));
        }
    }
}