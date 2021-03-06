﻿///////////////////////////////////////////////////////////
//  CUAdminDeudas.cs
//  Clase de implementación de CUAdminDeudas.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmDeuda {
    public class CUAdminDeudas : CUAdminGenerico<Deuda> {
        /// <summary>
        /// Este métodor retorna el controlador a utilizarse. Es para 
        /// sobrepasar en una clase heredada y establecer el controlador 
        /// correcto.
        /// </summary>
        /// <returns>
        /// El controlador que debe utilizarse para este list-preview.
        /// </returns>
        protected override IControladorPreview<Deuda> getControlador() {
            return new CUListDeudasAll {ModoVista = EModoVentana.LIST};
        }
    }
}