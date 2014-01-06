﻿///////////////////////////////////////////////////////////
//  CUAbmTipoConvenio.cs
//  Clase de implementación de CUAbmTipoConvenio.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmTipoConvenio {
    /// <summary>
    /// Esta clase hereda de CUAbmGenerico y se encarga de gestionar la 
    /// ventana WinABMV junto con su panelABMV para la entidad Entidad.
    /// </summary>
    public class CUAbmTipoConvenio : CUAbmGenerico<TipoConvenio> {
        #region IControladorEditable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override PanelABMV<TipoConvenio> crearPanelEdicion() {
            return new PanelAbmvTipoConvenio(this);
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void add(params object[] parametros) {
            ObjetoEnEdicion = new TipoConvenio();
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override void verify(params object[] parametros) {
            if (string.IsNullOrEmpty(ObjetoEnEdicion.Nombre))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-NOMBRE"));

            if (ObjetoEnEdicion.TasaPura < 0 || ObjetoEnEdicion.TasaPura > 20)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-TASA"));

            if (ObjetoEnEdicion.MaxCuotas < 1)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPCONV-CTDAD-CTAS"));

            if (ObjetoEnEdicion.MaxCuotasCaidas < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-MAX-CTASCAIDAS"));

            if (ObjetoEnEdicion.MinCuotas < 0 || ObjetoEnEdicion.MinCuotas > ObjetoEnEdicion.MaxCuotas)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-MIN-CUOTAS"));

            if (ObjetoEnEdicion.Punitorio < 0 || ObjetoEnEdicion.Punitorio > 20)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-PUNITORIO"));

            if (ObjetoEnEdicion.ValorMinimoCuota < 0 || ObjetoEnEdicion.TasaPura > 20)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-VALORMINCU"));

            if (ObjetoEnEdicion.ValorMinimoAnticipo < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-VALORMINAN"));

            if (ObjetoEnEdicion.MaxQuita < 0)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-MAX-QUITA"));

            if (ObjetoEnEdicion.ReglaHA < 0 || ObjetoEnEdicion.ReglaHA > 100)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-REGLAHA"));

            if (ObjetoEnEdicion.Honorarios < 0 || ObjetoEnEdicion.Honorarios > 100)
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-HONORAR"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.FormulaCuota))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-FORM-TOTAL"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.FormulaInteres))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-FORM-INTERES"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.FormulaHonorarios))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-FORM-HONORARIO"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.FormulaGastos))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-FORM-GASTOS"));

            if (string.IsNullOrEmpty(ObjetoEnEdicion.FormulaBaseConvenio))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("TIPOCONV-FORM-HONANT"));
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override string getTitulo() {
            return Mensaje.TextoMensaje("TITULO-ABMV-TIPOCONVENIO");
        }
        #endregion
    }
}