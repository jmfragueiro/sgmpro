﻿///////////////////////////////////////////////////////////
//  CUListRecibos.cs
//  Clase de implementación de CUListRecibos.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.interfases;
using scioPersistentLibrary.orden;
using sgmpro.dominio.configuracion;

namespace cuAbmRecibo {
    /// <summary>
    /// Esta clase hereda de CUListGenerico y se encarga de gestionar
    /// PanelListABMV para la entidad Recibos del pago.
    /// </summary>
    public class CUListRecibos : CUListGenerico<Recibo> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListRecibos() {
            ControlEditable = new CUAbmRecibo();
            ColsInvisibles.Add("Pago");
            Ordenamiento.Add(Orden.Asc("Fecha"));
        }

        #region IControladorListable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override ICriterioConsulta getFiltroMaster() {
            return Criterios.Igual("Pago", ObjetoMaster);
        }
        #endregion
    }
}