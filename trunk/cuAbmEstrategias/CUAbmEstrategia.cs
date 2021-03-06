﻿///////////////////////////////////////////////////////////
//  CUAbmEstrategia.cs
//  Clase de implementación de CUAbmEstrategia.
//  Generated by Fernando
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fernando
///////////////////////////////////////////////////////////
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmEstrategia {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Estrategia.
    /// </summary>
    public class CUAbmEstrategia : CUAbmGenerico<Estrategia> {
        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<Estrategia> crearPanelEdicion() {
            return new PanelAbmvEstrategia(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (string.IsNullOrEmpty(ObjetoEnEdicion.Descripcion))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("ESTRATEGIA-DESC"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.Nombre))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("ESTRATEGIA-NOMBRE"));
        }
        #endregion IControladorEditable Members
    }
}