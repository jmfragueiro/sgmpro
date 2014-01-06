///////////////////////////////////////////////////////////
//  FatalErrorException.cs
//  Implementation of the Class FatalErrorException
//  Generated by Enterprise Architect
//  Created on:      14-abr-2009 19:39:46
//  Original author: Fito
///////////////////////////////////////////////////////////
namespace scioBaseLibrary.excepciones {
    /// <summary>
    /// Esta clase de excepci�n debe utilizarse para representar todos
    /// los errores asociados a un problema de con la aplicaci�n misma,
    /// y que resulta en un error fatal para el sistema, es decir que se
    /// deber�a terminar el sistema a raiz del problema.
    /// </summary>
    public class FatalErrorException : SistemaErrorException {
        public FatalErrorException(string mensaje) : base(mensaje) {}
        public FatalErrorException(string mensaje, string extra) : base(mensaje, extra) {}
    }
}