﻿///////////////////////////////////////////////////////////
//  CUListSetTipoLista.cs
//  Clase de implementación de CUListSetTipoLista.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using sgmpro.dominio.configuracion;

namespace cuGenerarJobs {
    public class CUListSetTipoLista : CUListSetGenerico<TipoListaGestion> {
        /// <summary>
        /// Constructor de la clase que inicializa elementos internos.
        /// </summary>
        public CUListSetTipoLista() {
            ColsInvisibles.Add("Descripcion");
            ColsInvisibles.Add("TipoGestion");
            ColsInvisibles.Add("Perfil");
            ColsInvisibles.Add("MaxCuentas");
            ColsInvisibles.Add("Prioridad");
            ColsInvisibles.Add("Elegibilidad");
            ColsInvisibles.Add("Pendiente");
            ColsInvisibles.Add("Cancelacion");
            ColsInvisibles.Add("ListaEntidades");
            ColsInvisibles.Add("ListaEstrategias");
            ColsInvisibles.Add("FechaAlta");
        }
    }
}