﻿///////////////////////////////////////////////////////////
//  CUAbmDeuda.cs
//  Clase de implementación de CUAbmDeuda.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Drawing;
using cuAbmDeuda.Properties;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmDeuda {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Deuda.
    /// </summary>
    public class CUAbmDeuda : CUAbmGenerico<Deuda> {
        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<Deuda> crearPanelEdicion() {
            return new PanelAbmvDeuda(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override Icon getIcono() {
            return Resources.pago;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void add(params object[] parametros) {
            if (parametros[0] is Cuenta)
                ObjetoEnEdicion = new Deuda { Cuenta = (Cuenta) parametros[0] };
            else
                base.add(parametros);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void save(params object[] parametros) {
            try {
                ObjetoEnEdicion.Cuenta.agregarDeuda(ObjetoEnEdicion);
                ObjetoEnEdicion.save();
            } catch (Exception e) {
                ObjetoEnEdicion.delete();
                throw new DataErrorException("DATA-SAVENOK", e.ToString());
            }
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (ObjetoEnEdicion.Total <= 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-IMPORTE"));

            if (ObjetoEnEdicion.Capital < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-CAPITAL"));

            if (ObjetoEnEdicion.Interes < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-INTERES"));

            if (ObjetoEnEdicion.Honorarios < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-HONORARIO"));

            if (ObjetoEnEdicion.Gastos < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-GASTO"));

            if (ObjetoEnEdicion.Cuenta == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-CUENTA"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.Descripcion))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-DESC"));

            if (ObjetoEnEdicion.Concepto == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-CONCEPTO"));

            if (ObjetoEnEdicion.Detalle == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-DETALLE"));

            if (ObjetoEnEdicion.FechaVencimiento == Fechas.FechaNull
                || ObjetoEnEdicion.FechaVencimiento < Fechas.FechaMin)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("DEUDA-FECHA"));
        }
        #endregion

        #region IControladorCasoUso members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void aceptarParametros(params object[] parametros) {
            base.aceptarParametros(parametros);

            // Si le pasan la cuenta se la setea a la deuda
            if (parametros.Length > 2)
                ObjetoEnEdicion.Cuenta = (Cuenta) parametros[2];
        }
        #endregion
    }
}