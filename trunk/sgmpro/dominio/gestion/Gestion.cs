///////////////////////////////////////////////////////////
//  Gestion.cs
//  Implementation of the Class Gestion
//  Generated by Enterprise Architect
//  Created on:      20-abr-2009 16:57:18
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioSecureLibrary.dominio;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace sgmpro.dominio.gestion {
    /// <summary>
    /// Esta clase representa a una Gesti�n realizada sobre una Cuenta morosa. Las
    /// gestiones implican un contacto, de un gestor, con una determinada cuenta y 
    /// la ejecuci�n de alguna acci�n sobre �sta que decanta en una modificaci�n de 
    /// su estado, aunque no implique ning�n cambio en ninguno de sus datos propios 
    /// (al menos si cambia la cantidad de gestiones realizadas sobre la misma).
    /// Esta clase es persistente.
    /// </summary>
    public class Gestion : EntidadIdentificada<Gestion> {
        private readonly Parametro _finalizada = Parametros.GetByClave("ESTADOGESTION.FINALIZADA");
        private readonly Parametro _pendiente = Parametros.GetByClave("ESTADOGESTION.PENDIENTE");

        /// <summary>
        /// La Cuenta a la que pertenece la gesti�n. FK.
        /// </summary>
        public virtual Cuenta Cuenta { get; set; }
        /// <summary>
        /// El tipo de gesti�n realizada. Par�metro. No Nulo.
        /// </summary>
        public virtual Parametro Tipo { get; set; }
        /// <summary>
        /// El estado de ejecuci�n de la gesti�n. Par�metro.
        /// </summary>
        public virtual Parametro Estado { get; set; }
        /// <summary>
        /// La fecha de inicio de la gestion.
        /// </summary>                
        public virtual DateTime FechaInicio {
            get { return _fechainicio; }
            set { _fechainicio = Fechas.GetOkDate(value); }
        }
        private DateTime _fechainicio = Fechas.FechaNull;
        /// <summary>
        /// El usuario que ejecuta la gestion. FK.
        /// </summary>
        public virtual Usuario Usuario { get; set; }
        /// <summary>
        /// El resultado de la gesti�n. Par�metro.
        /// </summary>
        public virtual Parametro Resultado { get; set; }
        /// <summary>
        /// Descripci�n del contacto.
        /// </summary>
        public virtual string ResultadoDesc { get; set; }
        /// <summary>
        /// El resultado de la gesti�n realizada.
        /// </summary>
        public virtual DateTime ResultadoFecha {
            get { return _fechares; }
            set { _fechares = Fechas.GetOkDate(value); }
        }
        private DateTime _fechares = Fechas.FechaNull;
        /// <summary>
        /// La fecha de cierre de la gestion.
        /// </summary>                
        public virtual DateTime FechaCierre {
            get { return _fechacierre; }
            set { _fechacierre = Fechas.GetOkDate(value); }
        }
        private DateTime _fechacierre = Fechas.FechaNull;
        /// <summary>
        /// La persona contactada v�a la gestion. FK.
        /// </summary>
        public virtual Persona Contactado { get; set; }
        /// <summary>
        /// El Contacto utilizado en la gesti�n. FK.
        /// </summary>
        public virtual Contacto Contacto { get; set; }
        /// <summary>
        /// La Lista de Gesti�n que da origen a la gesti�n. FK.
        /// </summary>
        public virtual ListaGestion Lista { get; set; }
        /// <summary>
        /// La fecha de ultima modificaci�n de la gesti�n.
        /// </summary>                
        public virtual DateTime FechaUMod {
            get { return _fechaumod; }
            set { _fechaumod = Fechas.GetOkDate(value); }
        }
        private DateTime _fechaumod = DateTime.Now;
        /// <summary>
        /// La fecha de anulacion de la gestion.
        /// </summary>                
        public virtual DateTime FechaAnulacion {
            get { return _fechaanul; }
            set { _fechaanul = Fechas.GetOkDate(value); }
        }
        private DateTime _fechaanul = Fechas.FechaNull;

        /// <summary>
        /// Este m�todo dice si la gesti�n esta asignada a un usuario (est� siendo 
        /// procesada por alguien), � no. Se busca en la base para obtener esa info
        /// de manera de tener siempre lo ultimo.
        /// </summary>
        /// <returns>
        /// Retorna 'true' si la gesti�n esta asignada, sino 'false'. 
        /// </returns>
        public virtual bool estaAsignada() {
            refrescar();
            return (Usuario != null);
        }

        /// <summary>
        /// Este m�todo dice si la gesti�n esta pendiente, � no. Se busca en la base 
        /// para obtener esa info de manera de tener siempre lo ultimo.
        /// </summary>
        /// <returns>
        /// Retorna 'true' si la gesti�n esta asignada, sino 'false'. 
        /// </returns>
        public virtual bool estaPendiente() {
            refrescar();
            return Estado.Equals(_pendiente);
        }

        /// <summary>
        /// Este m�todo dice si la gesti�n esta finalizada � no.
        /// </summary>
        /// <returns>
        /// Retorna 'true' si la gesti�n esta finalizada, sino 'false'. 
        /// </returns>
        public virtual bool estaFinalizada() {
            refrescar();
            return Estado.Equals(_finalizada);
        }

        /// <summary>
        /// Este m�todo genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return string.Format("{0}:{1}", Tipo, Resultado);
        }
    }
}