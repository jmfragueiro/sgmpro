﻿///////////////////////////////////////////////////////////
//  CUAbmGestion.cs
//  Clase de implementación de CUAbmGestion.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.gestion;
using toolsGestion;

namespace cuAbmGestion {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Gestión.
    /// </summary>
    public class CUAbmGestion : CUAbmGenerico<Gestion> {
        private static readonly Parametro _pendiente = Parametros.GetByClave("ESTADOGESTION.PENDIENTE");
        private static readonly Parametro _enproceso = Parametros.GetByClave("ESTADOGESTION.ENPROCESO");
        private static readonly Parametro _finalizada = Parametros.GetByClave("ESTADOGESTION.FINALIZADA");
        private static readonly Parametro _nocontacto = Parametros.GetByClave("RESULTADOGESTION.NOCONTACTADO");
        private static readonly Parametro _invalido = Parametros.GetByClave("RESULTADOGESTION.CONTACTOINVALIDO");
        private static readonly Parametro _convenio = Parametros.GetByClave("RESULTADOGESTION.ALTACONVENIO");

        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<Gestion> crearPanelEdicion() {
            return new PanelAbmvGestion(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void add(params Object[] parametros) {
            if (parametros.Length > 0)
                ObjetoEnEdicion = new Gestion {Cuenta = (Cuenta)parametros[0]};
            else
                throw new AppErrorException("ERROR-ADD-WITHOUT-MASTER");
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void save(params Object[] parametros) {
            if (ObjetoEnEdicion == null)
                return;

            // Primero carga algún dato general antes de empezar en serio y
            // ejecuta el resultado (ATENCION!!!: puede volver con exception
            // si el resultado no pudo o no debio ejecutarse por algun motivo)
            Parametro estado = ObjetoEnEdicion.Estado;
            ObjetoEnEdicion.Usuario = Sistema.Controlador.SecurityService.getUsuario();
            ObjetoEnEdicion.Estado = _enproceso;
            ResultadoGestion.EjecutarResultado(ObjetoEnEdicion, ObjetoEnEdicion.Resultado);

            // Luego graba y actualiza algunas cosas
            try {
                long scn = Persistencia.Controlador.iniciarTransaccion();

                // Tambien marca como verificado el contacto utilizado
                if (ObjetoEnEdicion.Contacto != null
                    && ObjetoEnEdicion.Contacto.VerificadoPor == null
                    && !ObjetoEnEdicion.Resultado.Equals(_nocontacto)
                    && !ObjetoEnEdicion.Resultado.Equals(_invalido)) {
                    ObjetoEnEdicion.Contacto.VerificadoPor = ObjetoEnEdicion.Usuario;
                    ObjetoEnEdicion.Contacto.FechaUMod = DateTime.Now;
                    ObjetoEnEdicion.Contacto.save();
                }

                // Agrega la gestion a la cuenta y marca su cierre
                ObjetoEnEdicion.Cuenta.agregarGestion(ObjetoEnEdicion);
                ObjetoEnEdicion.FechaCierre = DateTime.Now;

                // Establece la gestion como finalizada si debe
                if (!ObjetoEnEdicion.Estado.Equals(_pendiente))
                    ObjetoEnEdicion.Estado = _finalizada;

                ObjetoEnEdicion.save();
                Sistema.Controlador.SecurityService.getSesion().cerrarGestion();
                Persistencia.Controlador.commitTransaccion(scn);
                Persistencia.Controlador.getSsp().Flush();
            } catch (Exception e) {
                Persistencia.Controlador.rollbackTransaccion();
                ObjetoEnEdicion.Estado = estado;
                throw new DataErrorException("DATA-SAVENOK", e.ToString());
            }
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (string.IsNullOrEmpty(ObjetoEnEdicion.ResultadoDesc))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("GESTION-DESC"));

            if (ObjetoEnEdicion.Resultado == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("GESTION-RESULTADO"));

            if (ObjetoEnEdicion.Tipo.Valorbool && ObjetoEnEdicion.Contactado == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("GESTION-PERSONA"));

            if (ObjetoEnEdicion.Tipo.Valorbool && ObjetoEnEdicion.Contacto == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("GESTION-CONTACTO"));

            if (ObjetoEnEdicion.Tipo == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("GESTION-TIPO"));

            if (ObjetoEnEdicion.Resultado.Valorstring != null && ObjetoEnEdicion.ResultadoFecha == Fechas.FechaNull)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("GESTION-FECHA"));

            if (ObjetoEnEdicion.Resultado.Equals(_convenio) && ObjetoEnEdicion.Cuenta.ConvenioActivo == null)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("GESTION-AC-SIN-CONVENIO"));
        }
        #endregion
    }
}