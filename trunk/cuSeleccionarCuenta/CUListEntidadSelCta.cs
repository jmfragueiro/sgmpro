﻿////////////////////////////////////////////////////////////
//  CUListPersonas.cs
//  Clase de implementación de CUListPersonas.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using cuAbmEntidad;
using scioControlLibrary;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.interfases;
using sgmpro.dominio.configuracion;

namespace cuSeleccionarCuenta {
    /// <summary>
    /// Esta clase hereda de CUListGenerico y se encarga de 
    /// gestionar un PanelListABMV para la entidad Persona.
    /// </summary>
    public class CUListEntidadSelCta : CUListEntidad {
        private readonly WinSelectCuenta _ventana;

        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListEntidadSelCta(WinSelectCuenta ventana) {
            _ventana = ventana;
        }

        #region IControladorListable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        protected override PanelListABMV<Entidad> crearPanelListado() {
            return new PanelListSeleccion<Entidad>(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void alActualizarFila(params object[] parametros) {
            if (_panelListado.getObjetoActual() != null) {
                base.alActualizarFila(_panelListado.getObjetoActual());
                _ventana.CriterioCuentas = Criterios.Igual("Entidad", _panelListado.getObjetoActual());
            }
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override ICriterioConsulta getFiltroMaster() {
            if (ObjetoMaster is ICriterioConsulta)
                return (ICriterioConsulta)ObjetoMaster;

            return base.getFiltroMaster();
        }
        #endregion
    }
}