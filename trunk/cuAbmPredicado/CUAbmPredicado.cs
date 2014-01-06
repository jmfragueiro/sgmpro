﻿///////////////////////////////////////////////////////////
//  CUAbmPredicado.cs
//  Clase de implementación de CUAbmPredicado.
//  Generated by Fernando
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fernando
///////////////////////////////////////////////////////////
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmPredicado {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Predicado.
    /// </summary>
    public class CUAbmPredicado : CUAbmGenerico<Predicado> {
        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<Predicado> crearPanelEdicion() {
            return new PanelAbmvPredicado(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void add(params object[] parametros) {
            if (parametros[0] is Estrategia)
                ObjetoEnEdicion = new Predicado { Estrategia = (Estrategia) parametros[0] };
            else
                throw new AppErrorException("ERROR-ADD-WITHOUT-MASTER", "PREDICADO");
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void save(params object[] parametros) {
            if (ObjetoEnEdicion != null) {
                ObjetoEnEdicion.Estrategia.ListaPredicados.Add(ObjetoEnEdicion);
                ObjetoEnEdicion.save();
                ObjetoEnEdicion.Estrategia.save();
            }
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (string.IsNullOrEmpty(ObjetoEnEdicion.Descripcion))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PREDICADO-DESC"));

            if (ObjetoEnEdicion.NroOrden <= 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("PREDICADO-ORDEN"));
        }
        #endregion
    }
}