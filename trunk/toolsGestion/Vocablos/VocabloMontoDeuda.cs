using System;
using scioPersistentLibrary.acceso;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    /// <summary>
    /// Obtiene el monto actual de la deuda y realiza
    /// las comparaciones que se indiquen para ello.
    /// </summary>
    public class VocabloMontoDeuda : Vocablo {
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
            return Comparar(
                RepositorioGenerico<Cuenta>.GetById((Guid) unObj).getMontoSaldoTotalActual(),
                unCriterio,
                Convert.ToDouble(unValor));
        }
    }
}