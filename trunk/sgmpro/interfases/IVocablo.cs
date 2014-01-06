///////////////////////////////////////////////////////////
//  IVocablo.cs
//  Implementation of the Interface IVocablo
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:54:59 p.m.
//  Original author: Fernando
///////////////////////////////////////////////////////////
namespace sgmpro.interfases {
    /// <summary>
    /// Interfase que deben implementar las clases de Vocablos y que
    /// exponen los m�todos de evaluaci�n.
    /// </summary>
    public interface IVocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo para el objeto 
        /// definido como un booleano donde true es que pasa la eval y
        /// false es que no pasa.
        /// </summary>
        bool Evaluar(object unObj, string unCriterio, string unValor);
    }
}