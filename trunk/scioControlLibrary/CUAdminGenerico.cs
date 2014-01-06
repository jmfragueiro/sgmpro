﻿///////////////////////////////////////////////////////////
//  CUAdminGenerico.cs
//  Clase de implementación de CUAdminGenerico.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.interfases;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;
using scioToolLibrary;

namespace scioControlLibrary {
    public class CUAdminGenerico<T> : IControladorCasoUso where T : EntidadIdentificada<T>, new() {
        #region Implementation of IControladorCasoUso
        /// <summary>
        /// Implementación de la propiedad de la interfaz.
        /// </summary>
        public object Padre { get { return _padre; } set { _padre = (Form) value; } }
        private Form _padre;

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public bool iniciar(object padre, params object[] valor) {
            try {
                // Controla que el padre sea de un tipo válido
                if (!(padre is Form))
                    return false;
                Padre = padre;

                // acepta cualquier parametro extra que se deba utilizar
                aceptarParametros(valor);

                // Finalmente muestra la ventana
                new WinAbmListPreview<T>(getControlador()) {
                    StartPosition = FormStartPosition.CenterScreen,
                    MdiParent = ((Form)Padre)
                }.Show();

                // Si termina está ok, entonces retorna true
                return true;
            } catch (Exception e) {
                throw new AppErrorException(Mensaje.TextoMensaje("UCCALLER-NOINIT"), e.ToString());
            }
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public virtual void aceptarParametros(params object[] parametros) {}
        #endregion

        #region helpers
        /// <summary>
        /// Este método retorna el controlador a utilizarse. Es para sobrepasar
        /// en una clase heredada y establecer el controlador correcto.
        /// </summary>
        /// <returns>
        /// El controlador que debe utilizarse para este list-preview.
        /// </returns>
        protected virtual IControladorPreview<T> getControlador() {
            return new CUPreviewGenerico<T>();
        }
        #endregion
    }
}