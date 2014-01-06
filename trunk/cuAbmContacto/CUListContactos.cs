﻿///////////////////////////////////////////////////////////
//  CUListContactos.cs
//  Clase de implementación de CUListContactos.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.interfases;
using sgmpro.dominio.configuracion;

namespace cuAbmContacto {
    /// <summary>
    /// Esta clase hereda de CUListGenerico y se encarga de 
    /// gestionar un PanelListABMV para la entidad Contacto.
    /// </summary>
    public class CUListContactos : CUListGenerico<Contacto> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListContactos() {
            ControlEditable = new CUAbmContacto();
            ColsInvisibles.Add("Persona");
        }

        #region IControladorListable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override ICriterioConsulta getFiltroMaster() {
            if (ObjetoMaster is Persona)
                return Criterios.Igual("Persona", ObjetoMaster);

            return base.getFiltroMaster();
        }
        #endregion
    }
}