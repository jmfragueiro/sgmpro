﻿///////////////////////////////////////////////////////////
//  Imputacion.cs
//  Implementation of the Class Imputacion
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:54:59 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary;
using scioPersistentLibrary.acceso;
using scioToolLibrary;

namespace sgmpro.dominio.configuracion {
    /// <summary>
    ///   Esta clase representa a una imputacion de un pago sobre una deuda, y
    ///   permite manejar de manera eficiente el concepto de pagos parciales y
    ///   las operaciones de aplicacion y desaplicacion de pagos parciales a 
    ///   deudas, sin mezclar importes ni fechas. Esta clase es persistente.
    /// </summary>
    public class Imputacion : EntidadIdentificada<Imputacion> {
        private static readonly Parametro _cancelada = Parametros.GetByClave("ESTADODEUDA.CANCELADA");

        /// <summary>
        ///   El pago a imputarse. No Nulo. FK.
        /// </summary>
        public virtual Pago Pago { get; set; }
        /// <summary>
        ///   La deuda sobre la que se imputa el pago. No Nulo. FK.
        /// </summary>
        public virtual Deuda Deuda { get; set; }
        /// <summary>
        ///   El importe total imputado. No Nulo.
        /// </summary>
        public virtual double Total {
            get { return Math.Round((_capital + _interes + _honorarios + _gastos), 2); }
        }
        /// <summary>
        ///   El importe de capital imputado. No Nulo.
        /// </summary>
        public virtual double Capital {
            get { return _capital; }
            set { _capital = Math.Round(value, 2); }
        }
        private double _capital;
        /// <summary>
        ///   El importe de intereses imputado. No Nulo.
        /// </summary>
        public virtual double Interes {
            get { return _interes; }
            set { _interes = Math.Round(value, 2); }
        }
        private double _interes;
        /// <summary>
        ///   El importe de honorarios imputado. No Nulo.
        /// </summary>
        public virtual double Honorarios {
            get { return _honorarios; }
            set { _honorarios = Math.Round(value, 2); }
        }
        private double _honorarios;
        /// <summary>
        ///   El importe de gastos imputado. No Nulo.
        /// </summary>
        public virtual double Gastos {
            get { return _gastos; }
            set { _gastos = Math.Round(value, 2); }
        }
        private double _gastos;
        /// <summary>
        ///   La fecha de imputación. No Nulo.
        /// </summary>
        public virtual DateTime Fecha {
            get { return _fecha; }
            set { _fecha = Fechas.GetOkDate(value); }
        }
        private DateTime _fecha = Fechas.FechaNull;

        /// <summary>
        ///   Este método prepara la imputación para aplica desde un
        ///   pago a una deuda, para lo cula establece los montos que
        ///   debe utilizarse. También establece la fecha de imputación
        ///   a ahora. Verifica el pago y la deuda, por lo que puede 
        ///   lanzar una DataErrorException si hay problemas.
        /// </summary>
        /// <param name = "deuda">
        ///   La deuda a la cual imputarse el pago.
        /// </param>
        /// <param name = "pago">
        ///   El pago a imputarse a la deuda.
        /// </param>
        /// <returns>
        ///   Esta instancia de Imputación ya preparada.
        /// </returns>
        public virtual Imputacion preparar(Deuda deuda, Pago pago) {
            if (pago == null || pago.Total <= 0)
                throw new DataErrorException("ERROR-NOADD-ELEMENTO", "PAGO en IMPUTACION");
            if (!pago.isAlive())
                throw new DataErrorException("ERROR-USE-ELEMENTO-NOALIVE", pago.ToString());
            if (deuda == null || pago.Total <= 0)
                throw new DataErrorException("ERROR-NOADD-ELEMENTO", "DEUDA en IMPUTACION");
            if (!deuda.isAlive())
                throw new DataErrorException("ERROR-USE-ELEMENTO-NOALIVE", deuda.ToString());
            if (!isAlive())
                throw new DataErrorException("ERROR-USE-ELEMENTO-NOALIVE", ToString());

            Deuda = deuda;
            Pago = pago;
            Fecha = DateTime.Now;

            return this;
        }

        /// <summary>
        ///   Este método ejecuta la imputación efectiva del pago sobre la deuda.
        ///   Ejecuta antes un Refresh de cada parte y luego verifica los montos.
        ///   Puede lanzar una DataErrorException si hay problemas.
        /// </summary>
        public virtual void imputar() {
            if (Pago == null || Deuda == null)
                throw new DataErrorException("ERROR-NOADD-ELEMENTO", "IMPUTACION");

            try {
                // Primero actualiza las partes para asegurar los montos
                Deuda.refrescar();
                Pago.refrescar();

                // Verifica que la deuda no este cancelada
                if (Deuda.Estado.Equals(_cancelada))
                    throw new DataErrorException("ERROR-PAGODEUDA-CANCELADA");

                // Luego ejecuta la imputacion
                long scn = Persistencia.Controlador.iniciarTransaccion();
                Capital = (Pago.getSaldoCapital() > Deuda.Capital)
                              ? Deuda.Capital
                              : Pago.getSaldoCapital();
                Interes = (Pago.getSaldoInteres() > Deuda.Interes)
                              ? Deuda.Interes
                              : Pago.getSaldoInteres();
                Honorarios = (Pago.getSaldoHonorario() > Deuda.Honorarios)
                                 ? Deuda.Honorarios
                                 : Pago.getSaldoHonorario();
                Gastos = (Pago.getSaldoGastos() > Deuda.Gastos)
                             ? Deuda.Gastos
                             : Pago.getSaldoGastos();

                Pago.Imputaciones.Add(this);
                Pago.resetEstado();
                Pago.save();

                // Actualiza los saldos de la deuda (pero se mantienen 
                // los valores originales en atributos capitalo, etc.)
                Deuda.Capital -= Capital;
                Deuda.Interes -= Interes;
                Deuda.Honorarios -= Honorarios;
                Deuda.Gastos -= Gastos;

                Deuda.Imputaciones.Add(this);
                Deuda.resetEstado();
                Deuda.save();

                save();
                Persistencia.Controlador.commitTransaccion(scn);
            } catch (Exception e) {
                Persistencia.Controlador.rollbackTransaccion();
                Pago.refrescar();
                Deuda.refrescar();
                base.delete();
                throw new DataErrorException("ERROR-DEUDA", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base. En este caso al deletearse la
        ///   imputacion, primero se elimina del pago y de la deuda. En la
        ///   imputación la referencia queda (por las dudas). Puede lanzar 
        ///   una DataErrorException si tiene problemas.
        /// </summary>
        public override void delete() {
            if (!isAlive())
                return;

            try {
                long scn = Persistencia.Controlador.iniciarTransaccion();
                Pago.Imputaciones.Remove(this);
                Pago.resetEstado();
                Pago.save();

                Deuda.Capital += Capital;
                Deuda.Interes += Interes;
                Deuda.Honorarios += Honorarios;
                Deuda.Gastos += Gastos;

                Deuda.Imputaciones.Remove(this);
                Deuda.resetEstado();
                Deuda.save();

                base.delete();
                Persistencia.Controlador.commitTransaccion(scn);
            } catch (Exception e) {
                Persistencia.Controlador.rollbackTransaccion();
                Pago.refrescar();
                Deuda.refrescar();
                refrescar();
                throw new DataErrorException("ERROR-IMPUTACION", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base. Aqui ademas, se reagrega
        ///   la imputacion a el pago y la deuda respectivas (verifica
        ///   primero si no esta ya). Puede lanzar DataErrorException 
        ///   si tiene problemas.
        /// </summary>
        public override void undelete() {
            throw new DataErrorException("DATA-UNDEL-NOK");
        }

        /// <summary>
        ///   Este método genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return string.Format("{0:C}({1})", Total, Fecha);
        }
    }
}