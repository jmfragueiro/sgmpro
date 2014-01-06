///////////////////////////////////////////////////////////
//  Parametro.cs
//  Implementation of the Class Parametro
//  Generated by Enterprise Architect
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.enums;
using scioToolLibrary;

namespace scioParamLibrary.dominio {
    /// <summary>
    /// Esta clase representa a un par�metro del sistema y contiene, 
    /// adem�s de un conjunto de campos para guardar valores de distinto
    /// tipo, una interface para determinar si un usuarioe espec�fico
    /// tiene un permiso espec�fico asociado al par�metro. Los par�metros
    /// tiene una Clase (EClaseParametro) y un Tipo (ETipoParametro).
    /// </summary>
    public class Parametro : EntidadIdentificada<Parametro> {
        /// <summary>
        /// La clave del par�metro. Unico. No Nulo.
        /// </summary>
        public virtual string Clave { get; set; }
        /// <summary>
        /// El nombre del par�metro. No Nulo.
        /// </summary>
        public virtual string Nombre { get; set; }
        /// <summary>
        /// La Clase del par�metro (de EClaseParametro). No Nulo.
        /// </summary>
        public virtual EClaseParametro Clase { get; set; }
        /// <summary>
        /// El Tipo de par�metro (de ETipoParametro). No Nulo.
        /// </summary>
        public virtual ETipoParametro Tipo { get; set; }
        /// <summary>
        /// Un valor de ordenaci�n para el par�metro.
        /// </summary>
        public virtual long Orden { get; set; }
        /// <summary>
        /// Un valor de tipo int asociado al par�metro.
        /// </summary>
        public virtual long Valorint { get; set; }
        /// <summary>
        /// Un valor de tipo long asociado al par�metro.
        /// </summary>
        public virtual long Valorlong { get; set; }
        /// <summary>
        /// Un valor de tipo string asociado al par�metro.
        /// </summary>
        public virtual string Valorstring { get; set; }
        /// <summary>
        /// Un valor de tipo char asociado al par�metro.
        /// </summary>
        public virtual char Valorchar { get; set; }
        /// <summary>
        /// Un valor de tipo bool asociado al par�metro.
        /// </summary>
        public virtual bool Valorbool { get; set; }
        /// <summary>
        /// Un valor de tipo double asociado al par�metro.
        /// </summary>
        public virtual double Valordouble { get; set; }
        /// <summary>
        /// Un segundo valor de tipo double asociado al par�metro.
        /// </summary>
        public virtual double Valordouble2 { get; set; }
        /// <summary>
        /// Un valor de tipo DateTime asociado al par�metro.
        /// </summary>                
        public virtual DateTime Valordate {
            get { return _valordate; }
            set { _valordate = Fechas.GetOkDate(value); }
        }
        private DateTime _valordate = Fechas.FechaNull;
        
        /// <summary>
        /// Este m�todo genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return Nombre;
        }
    }
}