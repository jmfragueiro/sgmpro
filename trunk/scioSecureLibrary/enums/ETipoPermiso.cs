///////////////////////////////////////////////////////////
//  ETipoPermiso.cs
//  Implementation of the Class ETipoPermiso
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
namespace scioSecureLibrary.enums {
    /// <summary>
    /// Enumeraci�n que contiene los distintos tipos de permisos de
    /// acceso a un recurso que pueden existir dentro del sistema. 
    /// El tipo de un permiso es un valor que permite establecer los
    /// distintos niveles de acceso y trabajo con recursos del sistema.
    /// </summary>
    public enum ETipoPermiso {
        NINGUNO = 0,
        VER,
        AGREGAR,
        EDITAR,
        REMOVER,        
        EJECUTAR,
        TOTAL
    }
}