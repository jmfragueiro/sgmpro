﻿///////////////////////////////////////////////////////////
//  CUListFacturas.cs
//  Clase de implementación de CUListFacturas.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System.Drawing;
using cuAbmFactura.Properties;
using scioControlLibrary;
using scioPersistentLibrary.orden;
using scioToolLibrary;
using sgmpro.dominio.caja;

namespace cuAbmFactura {
    /// <summary>
    /// Esta clase hereda de CUListGenerico y se encarga de 
    /// gestionar un PanelListABMV para la entidad Factura.
    /// </summary>
    public class CUListFacturas : CUPreviewGenerico<Factura> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListFacturas() {
            ControlEditable = new CUAbmFactura();

            ColsInvisibles.Add("Items");
            Ordenamiento.Add(Orden.Desc("Fecha"));
        }

        #region IControladorPreview
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override string getTitulo() {
            return Mensaje.TextoMensaje("TITULO-ABMV-FACTURA");
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public override Icon getIcono() {
            return Resources.factura;
        }
        #endregion

        #region IControladorListable Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        protected override PanelPreview<Factura> crearPanelPreview() {
            return new PanelPreviewFactura(ControlEditable);
        }
        #endregion
    }
}