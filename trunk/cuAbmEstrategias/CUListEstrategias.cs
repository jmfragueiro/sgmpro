﻿///////////////////////////////////////////////////////////
//  CUAbmEstrategia.cs
//  Clase de implementación de CUAbmEstrategia.
//  Generated by Fernando
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fernando
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioPersistentLibrary.orden;
using sgmpro.dominio.configuracion;

namespace cuAbmEstrategia {
    /// <summary>
    /// Esta clase hereda de CUListGenerico y se encarga de 
    /// gestionar un PanelListABMV para la entidad Estrategia.
    /// </summary>
    public class CUListEstrategias : CUPreviewGenerico<Estrategia> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListEstrategias() {
            ControlEditable = new CUAbmEstrategia();
            ColsInvisibles.Add("ListaPredicados");
            Ordenamiento.Add(Orden.Asc("FechaAlta"));
        }

        #region IControladorPreview Members
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        protected override PanelPreview<Estrategia> crearPanelPreview() {
            return new PanelPreviewEstrategia(ControlEditable);
        }
        #endregion
    }
}