﻿///////////////////////////////////////////////////////////
//  CUAbmTramo.cs
//  Clase de implementación de CUAbmTramo.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmTramo {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Tramo.
    /// </summary>
    public class CUAbmTramo : CUAbmGenerico<Tramo> {
        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<Tramo> crearPanelEdicion() {
            return new PanelAbmvTramo(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void add(params object[] parametros) {
            if (parametros[0] is Producto)
                ObjetoEnEdicion = new Tramo { Producto = (Producto)parametros[0] };
            else
                throw new AppErrorException("ERROR-ADD-WITHOUT-MASTER", "TRAMO");
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (string.IsNullOrEmpty(ObjetoEnEdicion.Nombre))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TRAMO-NOMBRE"));

            if (ObjetoEnEdicion.Limite < 1 || ObjetoEnEdicion.Limite > 99999)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TRAMO-LIMITE"));

            if (ObjetoEnEdicion.Honorario < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TRAMO-HONOR"));

            if (ObjetoEnEdicion.Punitorio < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TRAMO-PUNIT"));
        }
        #endregion
    }
}