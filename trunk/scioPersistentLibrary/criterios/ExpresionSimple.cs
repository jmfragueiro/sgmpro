﻿///////////////////////////////////////////////////////////
//  ExpresionSimple.cs
//  Implementación de una expresion de comparación SQL simple
//  (como mayorque, menorque, igual, etc.)
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using NHibernate.Criterion;
using scioPersistentLibrary.enums;
using scioPersistentLibrary.excepciones;
using scioPersistentLibrary.interfases;

namespace scioPersistentLibrary.criterios {
    /// <summary>
    /// Esta clase reprsenta el concepto de una expresión simple dentro de un
    /// criterio de consulta a un motor de persistencia (por ejemplo: un solo
    /// componente atómico como "campo = '23'" dentro de un Where de cláusula
    /// Select de un motor SQL). Estas expresiones simples pueden combinarse
    /// dentro de expresiones lógicas.
    /// </summary>
    public class ExpresionSimple : CriterioConsulta {
        protected string _atributo, _strvalor;
        protected EOperadorSimple _op;
        protected EOperadorUnario _opu;
        protected object _valor;

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es una cadena (un valor para por ejemplo
        /// "campo = 'JOSE LOPEZ'").
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, string valor) {
            _strvalor = string.Format("'{0}'", valor);
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es un Guid (un valor para por ejemplo
        /// "Id = '5C2671ED-3953-47E3-A565-0257A6B8B312'").
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, Guid valor) {
            _strvalor = string.Format("'{0}'", valor);
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es un long (un valor para por ejemplo
        /// "campo = 51321312").
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, long valor) {
            _strvalor = valor.ToString();
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es un int (un valor para por ejemplo
        /// "campo = 513").
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, int valor) {
            _strvalor = valor.ToString();
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es un entero (un valor para por ejemplo
        /// "campo = 5").
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, Enum valor) {
            _strvalor = valor.ToString();
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es una fecha (un valor para por ejemplo
        /// "campo = '17/11/2009 15:23:32'").
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, DateTime valor) {
            _strvalor = string.Format("'{0}'", valor);
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es un double (un valor para por ejemplo
        /// "campo = 5.30").
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, double valor) {
            _strvalor = valor.ToString();
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// en donde el segundo operando es un double (un valor para por ejemplo
        /// "campo = 1" -porque true=1 y false=0-).
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, bool valor) {
            _strvalor = ((valor)
                             ? "1"
                             : "0");
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion binaria (de dos operandos)
        /// donde el segundo operando es clase persistente (IEntidadIdentificable 
        /// para por ejemplo "campo = unaCuenta"). En este caso se toma su Id para
        /// la cadena where y se toma ek propio objeto para el NHicriteria.
        /// </summary>
        public ExpresionSimple(EOperadorSimple op, string atributo, IEntidadIdentificable valor) {
            _strvalor = string.Format("'{0}'", valor.Id);
            _op = op;
            _atributo = atributo;
            _valor = valor;
        }

        /// <summary>
        /// Constructor de la clase para una expresion unaria (de un solo 
        /// operando) en donde solo se permite dcomo operando el nombre de
        /// un atributo del objeto como una cadena (un valor para poner por 
        /// ejemplo "unaCuenta is not null").
        /// </summary>
        public ExpresionSimple(EOperadorUnario op, string atributo) {
            _opu = op;
            _atributo = atributo;
        }

        #region Implementation of ICriterioConsulta
        public override string getCriterioSQL(string prefijo) {
            return _strvalor != null
                       ? string.Format(" {0}{1} {2} {3} ",
                             (prefijo != null)
                                 ? prefijo + "_"
                                 : "",
                             _atributo,
                             GetOpString(_op),
                             _strvalor)
                       : string.Format(" {0}{1} {2} ",
                             (prefijo != null)
                                 ? prefijo + "_"
                                 : "",
                             _atributo,
                             GetOpString(_opu));
        }

        public override ICriterion getCriterioNH() {
            return (_valor != null)
                       ? getCriterionNH()
                       : getCriterionUnitarioNH();
        }
        #endregion

        #region helpers
        /// <summary>
        /// Este método devuelve el operador SQL correspondiente al operador
        /// enum que representa a la operacion simple (comparación) pasada 
        /// como argumento.
        /// </summary>
        /// <param name="op">
        /// Enum que representa a la operacion simple.
        /// </param>
        /// <returns>
        /// Cadena que reprsenta al operador como un string (para SQL Where).
        /// </returns>
        private static string GetOpString(EOperadorSimple op) {
            switch (op) {
                case EOperadorSimple.IGUAL:
                    return "=";
                case EOperadorSimple.DISTINTO:
                    return "<>";
                case EOperadorSimple.LIKE:
                    return "like";
                case EOperadorSimple.MAYORIGUAL:
                    return ">=";
                case EOperadorSimple.MAYORQUE:
                    return ">";
                case EOperadorSimple.MENORIGUAL:
                    return "<=";
                case EOperadorSimple.MENORQUE:
                    return "<";
            }
            throw new PersistErrorException("OPERANDO-NOK");
        }

        /// <summary>
        /// Este método devuelve el operador SQL correspondiente al operador
        /// enum que representa a una operacion unaria (is null/is not null) 
        /// pasada como argumento.
        /// </summary>
        /// <param name="op">
        /// Enum que representa a la operacion simple.
        /// </param>
        /// <returns>
        /// Cadena que reprsenta al operador como un string (para SQL Where).
        /// </returns>
        private static string GetOpString(EOperadorUnario op) {
            switch (op) {
                case EOperadorUnario.NULO:
                    return "is null";
                case EOperadorUnario.NONULO:
                    return "is not null";
            }
            throw new PersistErrorException("OPERANDO-NOK");
        }

        /// <summary>
        /// Este método devuelve el NHibernate Restriction correspondiente
        /// a la operacion simple (comparación) pasada como argumento.
        /// </summary>
        /// <returns>
        /// Restriction (de NHibernate) que reprsenta al operador.
        /// </returns>
        private ICriterion getCriterionNH() {
            switch (_op) {
                case EOperadorSimple.IGUAL:
                    return Restrictions.Eq(_atributo, _valor);
                case EOperadorSimple.DISTINTO:
                    return Restrictions.Not(Restrictions.Eq(_atributo, _valor));
                case EOperadorSimple.LIKE:
                    return Restrictions.Like(_atributo, _valor);
                case EOperadorSimple.MAYORIGUAL:
                    return Restrictions.Ge(_atributo, _valor);
                case EOperadorSimple.MAYORQUE:
                    return Restrictions.Gt(_atributo, _valor);
                case EOperadorSimple.MENORIGUAL:
                    return Restrictions.Le(_atributo, _valor);
                case EOperadorSimple.MENORQUE:
                    return Restrictions.Lt(_atributo, _valor);
            }
            throw new PersistErrorException("OPERANDO-NOK");
        }

        /// <summary>
        /// Este método devuelve el NHibernate Restriction correspondiente
        /// a la operacion simple (comparación) pasada como argumento.
        /// </summary>
        /// <returns>
        /// Restriction (de NHibernate) que reprsenta al operador.
        /// </returns>
        private ICriterion getCriterionUnitarioNH() {
            switch (_opu) {
                case EOperadorUnario.NULO:
                    return Restrictions.IsNull(_atributo);
                case EOperadorUnario.NONULO:
                    return Restrictions.IsNotNull(_atributo);
            }
            throw new PersistErrorException("OPERANDO-NOK");
        }
        #endregion helpers
    }
}