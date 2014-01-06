﻿///////////////////////////////////////////////////////////
//  CUAdminTiposConvenio.cs
//  Clase de implementación de CUAdminTiposConvenio.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmTipoConvenio {
    public class CUAdminTiposConvenio : CUAdminGenerico<TipoConvenio> {
        /// <summary>
        /// Este métodor etorna el controlador a utilizarse. Es para sobrepasar
        /// en una clase heredada y establecer el controlador correcto.
        /// </summary>
        /// <returns>
        /// El controlador que debe utilizarse para este list-preview.
        /// </returns>
        protected override IControladorPreview<TipoConvenio> getControlador() {
            return new CUListTiposConvenio {ModoVista = EModoVentana.LIST};
        }
    }
}