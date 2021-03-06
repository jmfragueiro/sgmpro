///////////////////////////////////////////////////////////
//  Permiso.cs
//  Implementation of the Class Permiso
//  Generated by Enterprise Architect
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioParamLibrary.dominio;
using scioPersistentLibrary.acceso;
using scioSecureLibrary.enums;

namespace scioSecureLibrary.dominio {
    /// <summary>
    /// Esta clase representa al concepto de permiso de acceso a un determinado 
    /// recurso dentro del sistema. Los permisos de acceso son solo lectura (su 
    /// repositorio de NHibernate hereda directamente de PersitenteGenerico y no 
    /// de RepositorioPersistente), es decir que se definen 'a mano' durante la instalación 
    /// del sistema y luego pueden usarse agregandose a los distintos roles del 
    /// sistema. Cada permiso se asocia a un recurso del sistema (guardado en la 
    /// tabla Parametro) y posee un tipo (de ETipoPermiso).
    /// </summary>
    public class Permiso : EntidadIdentificada<Permiso> {
        /// <summary>
        /// Recurso al que se refiere el permiso (apunta a un Parámetro). No Nulo. FK.
        /// </summary>
        public virtual Parametro Recurso { get; set; }
        /// <summary>
        /// El Tipo del permiso (de ETipoPermiso). No Nulo.
        /// </summary>
        public virtual ETipoPermiso Tipo { get; set; }

        /// <summary>
        /// Este método genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return string.Format("{0} -> {1}", Tipo, Recurso.ToString().Replace("&", "").ToUpper());
        }
    }
}