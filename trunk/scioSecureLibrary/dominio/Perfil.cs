///////////////////////////////////////////////////////////
//  Perfil.cs
//  Implementation of the Class Perfil
//  Generated by Enterprise Architect
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioPersistentLibrary.acceso;

namespace scioSecureLibrary.dominio {
    /// <summary>
    /// Esta clase representa a un perfil del sistema, los cuales son grupos
    /// l�gicos que asocian a usuarios de acuerdo a caracter�sticas definidas
    /// (como por ejemplo experiencia y/o tipo de tareas, etc.). Los perfiles
    /// se utilizan como destino de la generaci�n de listas de gesti�n. Esta 
    /// clase es persistente.
    /// </summary>
    public class Perfil : EntidadIdentificada<Perfil> {
        /// <summary>
        /// Nombre de Perfil (utilizado en la aplicaci�n). Unico. No Nulo.
        /// </summary>
        public virtual string Nombre { get; set; }
        /// <summary>
        /// Una descripcion textual para el Perfil.
        /// </summary>
        public virtual string Descripcion { get; set; }
        /// <summary>
        /// El estado de activaci�n del usuario (puede � no iniciar sesi�n). No Nulo.
        /// </summary>
        public virtual bool Activado { get; set; }

        /// <summary>
        /// Este m�todo se utiliza para dar a un usuario el perfil, 
        /// lo que se efectiviza pasando el propio rol al m�todo 
        /// agregarPerfil() del propio usuario (de la clase Usuario).
        /// No captura la excepciones.
        /// </summary>
        /// <param name="usuario">
        /// El permiso a agregarse al rol.
        /// </param>
        public virtual void agregarUsuario(Usuario usuario) {
            usuario.agregarPerfil(this);
        }

        /// <summary>
        /// Este m�todo se utiliza para quitar el perfil al usuario, 
        /// lo que se efectiviza pasando el propio rol al m�todo 
        /// quitarPerfil() del propio usuario (de la clase Usuario).
        /// No captura la excepciones.
        /// </summary>
        /// <param name="usuario">
        /// El usuario a quitarse del rol.
        /// </param>
        public virtual void quitarUsuario(Usuario usuario) {
            usuario.quitarPerfil(this);
        }

        /// <summary>
        /// Este m�todo genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return Nombre;
        }
    }
}