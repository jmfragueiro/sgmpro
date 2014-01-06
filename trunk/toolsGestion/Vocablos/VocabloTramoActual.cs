using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Compara según el estado de la cuenta
    /// dentro del sistema.
    /// </summary>
    public class VocabloTramoActual : Vocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo para el objeto definido.
        /// Debe ser redefinido en cada clase.
        /// </summary>
        /// <param name="unObj">El objeto que se pretende Evaluar</param>
        /// <param name="unCriterio">Criterio que se evaluará (ej.<=,=,<>)</param>
        /// <param name="unValor">Valor que se comparará con el valor del Vocablo</param>
        /// <returns>Resultado de la evaluación</returns>
        public override bool Evaluar(object unObj, string unCriterio, string unValor) {
            _dt = null;

            string select = " select t.tra_nombre as resultado"
                    +"  from tramo t, producto p, cuenta c "
                    +" where c.cta_id     = '" + unObj + "'  "
                    +"   and p.pro_id         = c.cta_producto"
                    +"   and p.pro_tramostemporales = 1"
                    +"   and p.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"   and t.tra_producto   = p.pro_id "
                    +"   and t.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"   and t.tra_limite     = ("
                    +" select min(t2.tra_limite)"
                    +" from tramo t2, producto p2, cuenta c2 "
                    +" where c2.cta_id         = c.cta_id"
                    +"  and p2.pro_id         = c2.cta_producto"
                    +"  and p2.pro_tramostemporales = 1"
                    +"  and p2.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"  and t2.tra_producto   = p2.pro_id "
                    +"  and t2.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"  and getdate()-("
                    +" select min(d.deu_fechavto)"
                    +"   from deuda d"
                    +"  where d.deu_cuenta    = c2.cta_id"
                    +"    and d.deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"    and d.deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',"
                    +"	'CB1BE5FE-566D-4857-A4D2-135A87498AF4')) between 1 and t2.tra_limite)"
                    +" union select t.tra_nombre"
                    +"  from tramo t, producto p, cuenta c"
                    +" where c.cta_id     = '" + unObj + "'  "
                    +"   and p.pro_id         = c.cta_producto"
                    +"   and p.pro_tramostemporales = 0"
                    +"   and p.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"   and t.tra_producto   = p.pro_id "
                    +"   and t.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"   and t.tra_limite     = ("
                    +" select min(t2.tra_limite)"
                    +" from tramo t2, producto p2, cuenta c2 "
                    +" where c2.cta_id         = c.cta_id"
                    +"  and p2.pro_id         = c2.cta_producto"
                    +"  and p2.pro_tramostemporales = 0"
                    +"  and p2.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"  and t2.tra_producto   = p2.pro_id "
                    +"  and t2.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)"
                    +"  and ("
                    +" select count(*)"
                    +" from gestion g"
                    +" where g.ges_cuenta    = c2.cta_id"
                    +" and g.ges_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)"
                    + " and g.ges_estado    = '57528414-8189-496E-89DB-38B1390503AF') between 1 and t2.tra_limite)";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 && Comparar(_dt.Rows[0]["resultado"].ToString(), unCriterio, unValor));
        }
    }
}