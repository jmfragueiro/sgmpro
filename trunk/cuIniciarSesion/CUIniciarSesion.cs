﻿///////////////////////////////////////////////////////////
//  CUIniciarSesion.cs
//  Implementation of the Class CUIniciarSesion
//  Generated by Enterprise Architect
//  Created on:      21-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using cuIniciarSesion.Properties;
using scioBaseLibrary;
using scioBaseLibrary.interfases;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuIniciarSesion {
    /// <summary>
    /// Esta clase implementa la interfaz IControladorCasoUso
    /// y es la encargada de ejecutar el caso de uso 'Iniciar
    /// Sesion'. 
    /// </summary>
    public class CUIniciarSesion : IControladorCasoUso {
        /// <summary>
        /// La vista asociada y gestionada por el caso de uso.
        /// </summary>
        public WinIniciarSession Vista { get; set; }
        /// <summary>
        /// Implementación de la propiedad de la interfaz.
        /// </summary>
        public object Padre { get { return _padre; } set { _padre = (IVistaVentanaPpal) value; } }
        private IVistaVentanaPpal _padre;

        /// <summary>
        /// Este método pasa el inicio de sesión para el usuario, con 
        /// los datos que se han ingresado (sus argumentos) a su padre
        /// la clase WinPrincipal (quien a su vez se los pasa a su propio
        /// controlador -Sistema-). No se manejan excepciones por lo que 
        /// puede lanzar un AccesoErrorException o un SesionErrorException.
        /// </summary>
        /// <param name="user">
        /// El nombre del usuario que intenta el inicio de sesión.
        /// </param>
        /// <param name="pass">
        /// La contraseña del usuario que intenta el inicio de sesión.
        /// </param>
        public void iniciarSesion(string user, string pass) {
            _padre.setAyuda(Mensaje.TextoMensaje("USUARIO-INICIANDO"));
            Sistema.Controlador.logear("USUARIO-INICIANDO", ENivelMensaje.INFORMACION, user);
            Sistema.Controlador.SecurityService.iniciarSesion(user, pass);
            _padre.setMenu();
            _padre.setExtra1(user.ToUpper());
            _padre.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
        }

        #region IControladorCasoUso Members
        /// <summary>
        /// Este método inicia el caso de uso y ejecuta sus pasos 
        /// conforme a la descripción del mismo y se apoya para 
        /// esto en la vista asociada a este caso de uso y en sus
        /// métodos.
        /// </summary>
        /// <param name="padre">
        /// En éste caso el objeto padre del caso de uso es la ventana
        /// principal del Sistema -el objeto de la clase WinPrincipal
        /// que se ha instanciado-.
        /// </param>
        /// <param name="valor">
        /// Aqui no se espera nada.
        /// </param>
        /// <returns>
        /// Retorna true si es que pudo iniciar el caso de uso,
        /// de lo contrario retorna false (obviamente solo se
        /// retorna algo si el método termina sin excepciones).
        /// </returns>
        public bool iniciar(object padre, params object[] valor) {
            // Se asegura de recibir un padre correcto (ventana)
            if (!(padre is IVistaVentanaPpal))
                return false;        
            Padre = padre;

            // Luego hace lo que debe hacer (iniciar el dialog)
            try {
                Sistema.Controlador.logear("VISTA-INIT", ENivelMensaje.DEBUG, "VistaCU");

                Vista = new WinIniciarSession(this) {
                    Icon = Resources.inicio,
                    Text = string.Format("{0} - {1}", 
                        Mensaje.TextoMensaje("TITULO-SHOW"),
                        Mensaje.TextoMensaje("INICIAR-SESION")),
                    StartPosition = FormStartPosition.CenterScreen
                };

                Vista.ShowDialog();
            } catch (Exception e) {
                Sistema.Controlador.mostrar("VISTA-NOK", ENivelMensaje.ERROR, e.ToString(), true);
            }

            return true;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public virtual void aceptarParametros(params object[] parametros) {}
        #endregion
    }
}