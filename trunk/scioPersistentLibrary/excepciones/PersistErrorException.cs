///////////////////////////////////////////////////////////
//  DBErrorException.cs
//  Implementation of the Class DBErrorException
//  Generated by Enterprise Architect
//  Created on:      14-abr-2009 19:39:46
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioToolLibrary.excepciones;

namespace scioPersistentLibrary.excepciones {
    /// <summary>
    /// Esta clase de excepci�n debe utilizarse para representar todos
    /// los errores asociados a un problema con la base de datos del 
    /// sistema, sea de conectividad, acceso, o un problema lanzado por
    /// NHibernate o el propio driver de la base.
    /// </summary>
    public class PersistErrorException : ScioErrorException {
        public PersistErrorException(string mensaje) : base(mensaje) {}
        public PersistErrorException(string mensaje, string extra) : base(mensaje, extra) {}
    }
}