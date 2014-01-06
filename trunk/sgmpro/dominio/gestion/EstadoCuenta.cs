///////////////////////////////////////////////////////////
//  EstadoCuenta.cs
//  Implementation of the Class EstadoCuenta
//  Generated by Enterprise Architect
//  Created on:      20-abr-2009 16:57:18
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using scioParamLibrary.dominio;
using scioPersistentLibrary.acceso;
using scioSecureLibrary.dominio;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace sgmpro.dominio.gestion {
    /// <summary>
    /// Esta clase representa a un Estado de Cuenta en un momento determinado.
    /// Las Cuentas van pasando por diferentes estados en la medida en que son
    /// gestionadas, y entonces para cada una se crea un EstadoCuenta cuando se
    /// ingresa a dicho estado. es una forma de mantener el historial de estados
    /// de la Cuenta. Esta clase es persistente.
    /// </summary>
    public class EstadoCuenta : EntidadIdentificada<EstadoCuenta> {
        /// <summary>
        /// La Cuenta a la que pertenece el estado. FK. No Nulo.
        /// </summary>
        public virtual Cuenta Cuenta { get; set; }
        /// <summary>
        /// El estado de la cuenta. Par�metro. No Nulo.
        /// </summary>
        public virtual Parametro Estado { get; set; }
        /// <summary>
        /// La fecha de inicio dentro del estado. No Nulo.
        /// </summary>                
        public virtual DateTime FechaInicio {
            get { return _fechainicio; }
            set { _fechainicio = Fechas.GetOkDate(value); }
        }
        private DateTime _fechainicio = Fechas.FechaNull;
        /// <summary>
        /// El usuario que llevo a la cuenta al estado. FK. No Nulo.
        /// </summary>
        public virtual Usuario Usuario { get; set; }
        /// <summary>
        /// Un comentario sobre el cambio de estado. Nulo.
        /// </summary>
        public virtual string Comentario { get; set; }

        /// <summary>
        /// Este m�todo genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return string.Format("{0}=>{1}", Cuenta.Codigo, Estado.Nombre);
        }
    }
}