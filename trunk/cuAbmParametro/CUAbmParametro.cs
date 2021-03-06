﻿///////////////////////////////////////////////////////////
//  CUAbmParametro.cs
//  Clase de implementación de CUAbmParametro.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioParamLibrary.dominio;
using scioPersistentLibrary.enums;
using scioToolLibrary;

namespace cuAbmParametro {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Parametro.
    /// </summary>
    public class CUAbmParametro : CUAbmGenerico<Parametro> {
        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<Parametro> crearPanelEdicion() {
            return new PanelAbmvParametro(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (string.IsNullOrEmpty(ObjetoEnEdicion.Clave))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PARAMETRO-CLAVE"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.Nombre))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PARAMETRO-NOMBRE"));

            if (ObjetoEnEdicion.Clase == EClaseParametro.NINGUNO)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PARAMETRO-CLASE"));

            if (ObjetoEnEdicion.Tipo == ETipoParametro.NINGUNO)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PARAMETRO-TIPO"));
        }
        #endregion
    }
}