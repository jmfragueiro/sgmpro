﻿///////////////////////////////////////////////////////////
//  CUListImputaciones.cs
//  Clase de implementación de CUListImputaciones.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioControlLibrary.enums;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.interfases;
using scioPersistentLibrary.orden;
using sgmpro.dominio.configuracion;

namespace cuAbmDeuda {
    /// <summary>
    /// Esta clase hereda de CUListGenerico y se encarga de gestionar
    /// PanelListABMV para la entidad Imputacion de pagos sobre deudas.
    /// </summary>
    public class CUListImputaciones : CUListGenerico<Imputacion> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListImputaciones() {
            ColsInvisibles.Add("Deuda");
            Ordenamiento.Add(Orden.Asc("Fecha"));
        }

        #region IControladorListable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelListABMV<Imputacion> getPanelListado(params object[] parametros) {
            return base.getPanelListado(EModoVentana.VIEW);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override ICriterioConsulta getFiltroMaster() {
            return Criterios.Igual("Deuda", ObjetoMaster);
        }
        #endregion
    }
}