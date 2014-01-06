using System.Collections.Generic;
using System.Reflection;
using scioBaseLibrary;
using sgmpro.interfases;

namespace sgmpro.dominio.configuracion {
    /// <summary>
    /// Clase que devuelve la clase vocablo indicada
    /// </summary>
    public class VocabloFactory {
        private static readonly IDictionary<string, IVocablo> _lista;
        private const string ENSAMBLADO = "toolsGestion";
        private const string LIBRERIA = "VocabloLibrary";

        /// <summary>
        /// Bloque de construcción estática.
        /// </summary>
        static VocabloFactory() {
            _lista = ((IVocabloLibrary) Assembly
                        .LoadFrom(Sistema.Controlador.AppPath + "\\" + ENSAMBLADO + ".dll")
                        .CreateInstance(ENSAMBLADO + "." + LIBRERIA))
                        .getVocablos();
        }

        /// <summary>
        /// Devuelve la clase que implemeta IVocablo de acuerdo
        /// al nombre pasado por parámetro, utilizando reflexión
        /// </summary>
        /// <param name="unTipoVocablo">
        /// Nombre de la clase del Vocablo deseado (un IVocablo).
        /// </param>
        /// <returns>
        /// Instancia de la clase que implementa IVocablo para el 
        /// vocablo solicitado.
        /// </returns>
        public static IVocablo Build(string unTipoVocablo) {
            return _lista[unTipoVocablo];
        }

        /// <summary>
        /// Devuelve una colección con los nombres de todos los 
        /// Vocablos registrados en la librería utilizada.
        /// </summary>
        public static IList<string> GetTodos() {
            List<string> items = new List<string>();
            foreach (string key in _lista.Keys)
                items.Add(key);
            return items;
        }
    }
}