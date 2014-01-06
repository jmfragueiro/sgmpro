﻿///////////////////////////////////////////////////////////
//  CUConfigurarGestion.cs
//  Clase de control para la ventana de configurar gestión.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.interfases;

namespace cuSeleccionarCuenta {
    public class CUSeleccionarCuenta : IControladorCasoUso {
        /// <summary>
        /// Implementación de la propiedad de la interfaz.
        /// </summary>
        public object Padre { get { return _padre; } set { _padre = (Form) value; } }
        private Form _padre;

        #region Implementation of IControladorCasoUso
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public bool iniciar(Object padre, params Object[] valor) {
            try {
                // Controla que el padre sea de un tipo válido
                if (!(padre is Form))
                    return false;
                Padre = padre;

                // Crea e inicia la ventana de seleccion
                (new WinSelectCuenta {StartPosition = FormStartPosition.CenterScreen}).ShowDialog();

                return true;
            } catch (Exception e) {
                throw new AppErrorException("UCCALLER-NOINIT", e.ToString());
            }
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void aceptarParametros(params Object[] parametros) {}
        #endregion
    }
}