﻿///////////////////////////////////////////////////////////
//  CUListRoles.cs
//  Clase de implementación de CUListRoles.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioPersistentLibrary.orden;
using scioSecureLibrary.dominio;

namespace cuConfigurarUsuarios {
    /// <summary>
    /// Esta clase hereda de CUListGenerico y se encarga de 
    /// gestionar un PanelListABMV para la entidad Rol.
    /// </summary>
    public class CUListRoles : CUPreviewGenerico<Rol> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListRoles() {
            ControlEditable = new CUAbmRol();
            ColsInvisibles.Add("Permisos");
            ColsInvisibles.Add("Roles");
            Ordenamiento.Add(Orden.Asc("Nombre"));
        }

        #region IControladorListable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        protected override PanelPreview<Rol> crearPanelPreview() {
            return new PanelPreviewRol(ControlEditable);
        }
        #endregion
    }
}