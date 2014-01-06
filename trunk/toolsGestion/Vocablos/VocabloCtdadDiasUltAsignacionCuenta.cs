using System;
using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Cantidad de dias que pasaron desde la ultima asignacion de una cuenta.
    /// </summary>
    public class VocabloCtdadDiasUltAsignacionCuenta : Vocablo {
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
                "select isnull(min(convert(int,(getdate()-cta_fechaasignacion))),-999) as resultado" +
                "  from cuenta" +
                " where cta_id = '" + unObj + "'";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 &&
                    Comparar(((int)_dt.Rows[0]["resultado"]),
                        unCriterio,
                        Convert.ToInt64(unValor)));
        }
    }
}