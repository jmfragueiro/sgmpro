///////////////////////////////////////////////////////////
//  ENivelMensaje.cs
//  Implementation of the Class ENivelMensaje
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
namespace scioToolLibrary.enums {
    /// <summary>
    /// Enumeración que contiene los distintas niveles de mensajes y de
    /// ejecución del sistema que pueden existir dentro de este. El nivel
    /// de ejecución se contrasta siempre con el de un mensaje para decidir
    /// si se logea o no el mismo (entre otras cosas que pudiesen surgir).
    /// </summary>
    public enum ENivelMensaje {
        NINGUNO = 0,
        BATCH,
        DEBUG,
        INFORMACION,
        ERROR,
        FATAL,
        PREGUNTA,
        SISTEMA
    }
}