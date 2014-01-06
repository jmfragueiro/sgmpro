using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Compara según el estado de la cuenta
    /// dentro del sistema.
    /// </summary>
    public class VocabloEstadoCuenta : Vocablo {
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
                "select par_nombre as resultado" +
                "  from parametro " +
                " where par_id = (select cta_estado from cuenta where cta_id = '" + unObj + "')";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 && Comparar(_dt.Rows[0]["resultado"].ToString(), unCriterio, unValor));
        }
    }
}