﻿///////////////////////////////////////////////////////////
//  EFuncionAgregacion.cs
//  Implementation of the Class EFuncionAgregacion
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
namespace scioPersistentLibrary.enums {
    /// <summary>
    /// Esta enumeración permite identificar los tipos de funciones 
    /// SQL de agregación que pueden utilizarse con un Repositorio
    /// Genérico, para obtener algún valor de agregación sobre un 
    /// atributo de la Entidad revisada.
    /// </summary>
    public enum EFuncionAgregacion {
        COUNT = 0,
        SUMA,
        PROMEDIO,
        MAXIMO,
        MINIMO,
        COUNT_DISTINCT
    }
}