using System;
using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Cantidad de dias que pasaron desde la ultima gestion de una cuenta.
    /// </summary>
    public class VocabloCtdadDiasUltGestion : Vocablo {
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
                "select isnull(min(convert(int,(getdate()-ges_fechacierre))),-999) as resultado" +
                "  from gestion " +
                " where ges_cuenta      = '" + unObj + "'" +
                "   and ges_estado      =  '" + _finalizada + "'" +
                "   and ges_fechacierre > convert(datetime, '1753-01-01 00:00:000', 121)";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0 &&
                    Comparar(((int)_dt.Rows[0]["resultado"]),
                        unCriterio,
                        Convert.ToInt64(unValor)));
        }
    }
}