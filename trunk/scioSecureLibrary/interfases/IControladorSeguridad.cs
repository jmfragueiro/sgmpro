///////////////////////////////////////////////////////////
//  IControladorSeguridad.cs
//  Implementation of the Interface IControladorSeguridad
//  Generated by Enterprise Architect
//  Created on:      15-Abr-2009 07:11:10 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioSecureLibrary.dominio;
using scioSecureLibrary.enums;

namespace scioSecureLibrary.interfases {
    /// <summary>
    /// Esta interfase es la que representa el comportamiento deseable 
    /// de una clase que implemente y controle l servicio de seguridad
    /// de un Sistema completo, el cual debe encargarse, para ello, de 
    /// brindar fcs de gestion de usuario, roles, permisos y manejo de
    /// sesiones. Tambien se ingcluye la verificaci�n de permisos.
    /// </summary>
    public interface IControladorSeguridad {
        /// <summary>
        /// Este m�todo inicia una sesi�n de usuario dentro del sistema
        /// (para lo cual crea el objeto Sesion si debe) a partir de los 
        /// datos de conexi�n pasados. Lanza una SecurityErrorException si 
        /// no puede iniciar la sesi�n o una SesionErrorException si ya 
        /// hay una sesion activa.
        /// </summary>
        /// <param name="user">
        /// El nombre del usuario que intenta el inicio de sesi�n.
        /// </param>
        /// <param name="pass">
        /// La contrase�a del usuario que intenta el inicio de sesi�n.
        /// </param>
        void iniciarSesion(string user, string pass);

        /// <summary>
        /// Este m�todo establece si existe una sesi�n activa actualmente
        /// dentro del sistema.
        /// </summary>
        /// <returns>
        /// Retorna 'true' si existe una sesion activa, o si no 'false'
        /// </returns>
        bool haySesionActiva();

        /// <summary>
        /// Este m�todo devuelve el nombre del usuario de la sesi�n actual
        /// del sistema. 
        /// </summary>
        /// <returns>
        /// Retorna el nombre del usuario de la sesi�n actual o 'NINGUNO'.
        /// </returns>
        Sesion getSesion();

        /// <summary>
        /// Este m�todo devuelve el usuario de la sesi�n actual del sistema. 
        /// </summary>
        /// <returns>
        /// Retorna el usuario de la sesi�n actual � null si no hay usuario.
        /// </returns>
        Usuario getUsuario();

        /// <summary>
        /// Este m�todo cierra la sesi�n de usuario actual del sistema 
        /// Si no hay una sesi�n creada o activa, solo logea un mensaje
        /// �, si no puede cerrar la sesi�n, lanza SesionErrorException.
        /// </summary>
        void terminarSesion();

        /// <summary>
        /// Este m�todo verifica si el usuario actualmente conectado posee un 
        /// permiso determinado. Lanza una SecurityErrorException si no consigue 
        /// determinar un recurso v�lido a partir de la cadena pasada como argumento.
        /// </summary>
        /// <param name="recurso">
        /// La cadena con la que se establece el recurso a verificar.
        /// </param>
        /// <param name="tipo">
        /// El tipo de permiso a verificar para el recurso determinado.
        /// </param>
        /// <returns>
        /// Retorna 'true' si el usuario posee el permiso o si no 'false'.
        /// </returns>
        bool usuarioActualPoseePermiso(string recurso, ETipoPermiso tipo);

        /// <summary>
        /// Este m�todo verifica si un usuario cualquiera posee un permiso 
        /// determinado. Lanza una SecurityErrorException si no consigue 
        /// determinar un recurso v�lido a partir de la cadena pasada como 
        /// argumento.
        /// </summary>
        /// <param name="usuario">
        /// El usuario del que se desea verificar el permiso.
        /// </param>
        /// <param name="recurso">
        /// La cadena con la que se establece el recurso a verificar.
        /// </param>
        /// <param name="tipo">
        /// El tipo de permiso a verificar para el recurso determinado.
        /// </param>
        /// <returns>
        /// Retorna 'true' si el usuario posee el permiso o si no 'false'.
        /// </returns>
        bool usuarioPoseePermiso(Usuario usuario, string recurso, ETipoPermiso tipo);
    }
}