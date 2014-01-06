using sgmpro.dominio.configuracion;

namespace sgmpro.interfases {
    /// <summary>
    /// Interfase que debe implementar las clases
    /// que representen los distintos pasos de un Job
    /// Todos los pasos de un job se ejecutan en un orden
    /// pero tienen una misma programación.
    /// Por ej. Job A, programado para los viernes a las 22 hs (Frecuencia)
    /// Ejecuta el Paso 1 despues el Paso 2.
    /// </summary>
    public interface IStepJob {
        /// <summary>
        /// Método principal
        /// </summary>
        ListaGestion ejecutarPaso(params object[] parametros);
    }
}