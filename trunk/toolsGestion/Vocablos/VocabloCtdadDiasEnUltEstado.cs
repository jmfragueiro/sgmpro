using System;
using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Cantidad de dias que pasaron desde la entrada al último estado de una cuenta.
    /// </summary>
    public class VocabloCtdadDiasEnUltEstado : Vocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo para el objeto definido.
        /// </summary>
        public override bool Evaluar(object unObj, string unCriterio, string unValor) {
            _dt = null;

            string select =
                "select isnull(convert(int,(getdate()-max(esc_fechainicio))),-999) as resultado" +
                "  from estadocuenta " +
                " where esc_cuenta     = '" + unObj + "' " +
                "   and esc_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 &&
                    Comparar(((int)_dt.Rows[0]["resultado"]),
                        unCriterio,
                        Convert.ToInt64(unValor)));
        }
    }
}