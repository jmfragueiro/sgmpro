using System;
using System.Data;
using scioBaseLibrary.excepciones;
using scioParamLibrary.dominio.repos;
using sgmpro.interfases;

namespace sgmpro.dominio.configuracion {
    /// <summary>
    /// Clase abstracta que encapsula comportamiento común
    /// de los vocablos.
    /// Las clases hijas deben definir un cosntructor que 
    /// asigne la descripción de la misma.
    /// </summary>
    public abstract class Vocablo : IVocablo {
        protected static DataTable _dt;
        protected static readonly string _solicita   = Parametros.GetByClave("RESULTADOGESTION.SOLICITACONTACTO").Id.ToString();
        protected static readonly string _promesa    = Parametros.GetByClave("RESULTADOGESTION.PROMESAPAGO").Id.ToString();
        protected static readonly string _sucursal   = Parametros.GetByClave("RESULTADOGESTION.PROMESASUCURSAL").Id.ToString();
        protected static readonly string _promcuota = Parametros.GetByClave("RESULTADOGESTION.PROMESAPAGOCUOTA").Id.ToString();
        protected static readonly string _visita = Parametros.GetByClave("RESULTADOGESTION.PROMESAVISITA").Id.ToString();
        protected static readonly string _postal = Parametros.GetByClave("RESULTADOGESTION.CORREOENTREGADO").Id.ToString();
        protected static readonly string _terreno = Parametros.GetByClave("RESULTADOGESTION.TERRENOENTREGADO").Id.ToString();
        protected static readonly string _finalizada = Parametros.GetByClave("ESTADOGESTION.FINALIZADA").Id.ToString();
        protected static readonly string _enproceso = Parametros.GetByClave("ESTADOGESTION.ENPROCESO").Id.ToString();
        protected static readonly string _cancelada  = Parametros.GetByClave("ESTADODEUDA.CANCELADA").Id.ToString();        
        protected static readonly string _aplicado = Parametros.GetByClave("ESTADOPAGO.APLICADO").Id.ToString();

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public abstract bool Evaluar(object unObj, string unCriterio, string unValor);

        #region comparadores
        protected static bool Comparar(int operador, string operacion, int operando) {
            try {
                switch (operacion.Trim()) {
                    case "==":
                        return (operador == operando);
                    case ">=":
                        return (operador >= operando);
                    case "<=":
                        return (operador <= operando);
                    case ">":
                        return (operador > operando);
                    case "<":
                        return (operador < operando);
                    case "<>":
                        return (operador != operando);
                    default:
                        return false;
                }
            } catch (Exception e) {
                throw new AppErrorException("DATA-VOCABLO-NOK", e.ToString());
            }
        }

        protected static bool Comparar(long operador, string operacion, long operando) {
            try {
                switch (operacion.Trim()) {
                    case "==":
                        return (operador == operando);
                    case ">=":
                        return (operador >= operando);
                    case "<=":
                        return (operador <= operando);
                    case ">":
                        return (operador > operando);
                    case "<":
                        return (operador < operando);
                    case "<>":
                        return (operador != operando);
                    default:
                        return false;
                }
            } catch (Exception e) {
                throw new AppErrorException("DATA-VOCABLO-NOK", e.ToString());
            }
        }

        protected static bool Comparar(double operador, string operacion, double operando) {
            try {
                switch (operacion.Trim()) {
                    case "==":
                        return (operador == operando);
                    case ">=":
                        return (operador >= operando);
                    case "<=":
                        return (operador <= operando);
                    case ">":
                        return (operador > operando);
                    case "<":
                        return (operador < operando);
                    case "<>":
                        return (operador != operando);
                    default:
                        return false;
                }
            } catch (Exception e) {
                throw new AppErrorException("DATA-VOCABLO-NOK", e.ToString());
            }
        }

        protected static bool Comparar(float operador, string operacion, float operando) {
            try {
                switch (operacion.Trim()) {
                    case "==":
                        return (operador == operando);
                    case ">=":
                        return (operador >= operando);
                    case "<=":
                        return (operador <= operando);
                    case ">":
                        return (operador > operando);
                    case "<":
                        return (operador < operando);
                    case "<>":
                        return (operador != operando);
                    default:
                        return false;
                }
            } catch (Exception e) {
                throw new AppErrorException("DATA-VOCABLO-NOK", e.ToString());
            }
        }

        protected static bool Comparar(bool operador, string operacion, bool operando) {
            try {
                switch (operacion.Trim()) {
                    case "==":
                        return (operador == operando);
                    case ">=":
                        return ((operador && !operando) || (operador == operando));
                    case "<=":
                        return ((!operador && operando) || (operador == operando));
                    case ">":
                        return (operador && !operando);
                    case "<":
                        return (!operador && !operando);
                    case "<>":
                        return (operador != operando);
                    default:
                        return false;
                }
            } catch (Exception e) {
                throw new AppErrorException("DATA-VOCABLO-NOK", e.ToString());
            }
        }

        protected static bool Comparar(DateTime operador, string operacion, DateTime operando) {
            try {
                switch (operacion.Trim()) {
                    case "==":
                        return (operador == operando);
                    case ">=":
                        return (operador >= operando);
                    case "<=":
                        return (operador <= operando);
                    case ">":
                        return (operador > operando);
                    case "<":
                        return (operador < operando);
                    case "<>":
                        return (operador != operando);
                    default:
                        return false;
                }
            } catch (Exception e) {
                throw new AppErrorException("DATA-VOCABLO-NOK", e.ToString());
            }
        }

        protected static bool Comparar(string operador, string operacion, string operando) {
            try {
                switch (operacion.Trim()) {
                    case "==":
                        return (operador.Equals(operando));
                    case ">=":
                        return (operador.CompareTo(operando) > -1);
                    case "<=":
                        return (operador.CompareTo(operando) < 1);
                    case ">":
                        return (operador.CompareTo(operando) > 0);
                    case "<":
                        return (operador.CompareTo(operando) < 0);
                    case "<>":
                        return (!operador.Equals(operando));
                    default:
                        return false;
                }
            } catch (Exception e) {
                throw new AppErrorException("DATA-VOCABLO-NOK", e.ToString());
            }
        }
        #endregion comparadores
    }
}