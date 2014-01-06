///////////////////////////////////////////////////////////
//  EClaseParametro.cs
//  Implementation of the Class EClaseParametro
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
namespace scioPersistentLibrary.enums {
    /// <summary>
    /// Enumeraci�n que contiene las distintas clases de par�metros
    /// que pueden existir dentro del sistema. La clase de un par�metro
    /// es un valor que permite clasificar los valores dependiendo de 
    /// si pueden ser ABML (USUARIO), solo ML (GLOBAL) o solo L (SISTEMA).
    /// </summary>
    public enum EClaseParametro {
        NINGUNO = 0,
        SISTEMA,
        GLOBAL,
        USUARIO
    }
}