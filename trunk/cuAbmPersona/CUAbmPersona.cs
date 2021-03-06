﻿///////////////////////////////////////////////////////////
//  CUAbmPersona.cs
//  Clase de implementación de CUAbmPersona.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmPersona {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Persona.
    /// </summary>
    public class CUAbmPersona : CUAbmGenerico<Persona> {
        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<Persona> crearPanelEdicion() {
            return new PanelAbmvPersona(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (string.IsNullOrEmpty(ObjetoEnEdicion.Nombre))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PERSONA-NOMBRE"));

            if (!string.IsNullOrEmpty(ObjetoEnEdicion.Cuit) && !Validador.ValidarCUIT(ObjetoEnEdicion.Cuit))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PERSONA-CUIT"));

            if (!string.IsNullOrEmpty(ObjetoEnEdicion.DNI) && !Validador.ValidarDNI(ObjetoEnEdicion.DNI))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PERSONA-DNI"));
        }
        #endregion
    }
}