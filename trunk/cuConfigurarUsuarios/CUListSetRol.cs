﻿///////////////////////////////////////////////////////////
//  CUListSetRol.cs
//  Clase de implementación de CUListSetRol.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioSecureLibrary.dominio;

namespace cuConfigurarUsuarios {
    public class CUListSetRol : CUListSetGenerico<Rol> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListSetRol() {
            ColsInvisibles.Add("Roles");
            ColsInvisibles.Add("Permisos");
        }
    }
}