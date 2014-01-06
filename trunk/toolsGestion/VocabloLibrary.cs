using System.Collections.Generic;
using sgmpro.interfases;
using toolsGestion.Vocablos;

namespace toolsGestion {
    /// <summary>
    /// Clase que devuelve la libreria de vocablos existente.
    /// </summary>
    public class VocabloLibrary : IVocabloLibrary {
        /// <summary>
        /// Bloque de construcción estática.
        /// </summary>
        public IDictionary<string, IVocablo> getVocablos() {
            IDictionary<string, IVocablo> lista = new Dictionary<string, IVocablo> {
                {"VocabloCtdadDiasDeDeuda", new VocabloCtdadDiasDeDeuda()},
                {"VocabloCtdadDiasEnUltEstado", new VocabloCtdadDiasEnUltEstado()},
                {"VocabloCtdadDiasUltAsignacionCuenta", new VocabloCtdadDiasUltAsignacionCuenta()},
                {"VocabloCtdadDiasUltFechaPago", new VocabloCtdadDiasUltFechaPago()},
                {"VocabloCtdadDiasUltGestion", new VocabloCtdadDiasUltGestion()},
                {"VocabloDummy", new VocabloDummy()},
                {"VocabloEstadoCuenta", new VocabloEstadoCuenta()},
                {"VocabloFechaSgtePromesaCuota", new VocabloFechaSgtePromesaCuota()},
                {"VocabloFechaSgtePromesaPago", new VocabloFechaSgtePromesaPago()},
                {"VocabloFechaSgtePromesaSucursal", new VocabloFechaSgtePromesaSucursal()},
                {"VocabloFechaSgtePromesaVisita", new VocabloFechaSgtePromesaVisita()},
                {"VocabloFechaUltAsignacionCuenta", new VocabloFechaUltAsignacionCuenta()},
                {"VocabloLocalidadTitular", new VocabloLocalidadTitular()},
                {"VocabloMontoDeuda", new VocabloMontoDeuda()},
                {"VocabloMontoSgteCuotaConvenio", new VocabloMontoSgteCuotaConvenio()},
                {"VocabloPoseeCalle", new VocabloPoseeCalle()},     
                {"VocabloPoseeCelular", new VocabloPoseeCelular()},
                {"VocabloPoseeConvenioActivo", new VocabloPoseeConvenioActivo()},
                {"VocabloPoseeConvenioCaido", new VocabloPoseeConvenioCaido()},        
                {"VocabloPoseeDescContactoLaboral", new VocabloPoseeDescContactoLaboral()},      
                {"VocabloPoseeGestionPostal", new VocabloPoseeGestionPostal()},     
                {"VocabloPoseeGestionTerreno", new VocabloPoseeGestionTerreno()},     
                {"VocabloPoseePromesaCuotaSDH", new VocabloPoseePromesaCuotaSDH()},
                {"VocabloPoseePromesaPagoSDH", new VocabloPoseePromesaPagoSDH()},
                {"VocabloPoseePromesaSucursalSDH", new VocabloPoseePromesaSucursalSDH()},
                {"VocabloPoseePromesaSucursalSDH2", new VocabloPoseePromesaSucursalSDH2()},
                {"VocabloPoseePromesaVisitaSDH", new VocabloPoseePromesaVisitaSDH()},
                {"VocabloPoseeSolicitudContactoSDH", new VocabloPoseeSolicitudContactoSDH()},
                {"VocabloPoseeTelefono", new VocabloPoseeTelefono()},     
                {"VocabloProductoCuenta", new VocabloProductoCuenta()},
                {"VocabloTramoActual", new VocabloTramoActual()},
                {"VocabloUltimoResGestion", new VocabloUltimoResGestion()},
                {"VocabloUltimoTipoPago", new VocabloUltimoTipoPago()},
                {"VocabloUsuarioGestor", new VocabloUsuarioGestor()}
            };
            return lista;
        }

        public static string GetDescripcion(string vocablo) {
            switch (vocablo) {
                case "VocabloCtdadDiasDeDeuda":
                    return "Devuelve un NUMERO ENTERO: la cantidad de días (corridos) desde la fecha de "
                           + "vencimiento de la deuda más antigua de la cuenta (origen y/o cuota de plan). "
                           + "Si no se puede determinar la fecha mas antigua, retorna [-999]. Ejemplo: [55]";
                case "VocabloCtdadDiasEnUltEstado":
                    return "Devuelve un NUMERO ENTERO: la cantidad de días (corridos) desde la fecha en "
                           + "que la cuenta ingresó al Estado que posee actualmente. Si no puede determinar "
                           + "dicha fecha, retorna [-999]. Ejemplo: [7]";
                case "VocabloCtdadDiasUltAsignacionCuenta":
                    return "Devuelve un NUMERO ENTERO: la cantidad de días (corridos) desde la fecha más "
                           + "reciente en que la cuenta fue asignada por el Cliente (si hay varias toma la "
                           + "última). Si no puede determinar dicha fecha, retorna [-999]. Ejemplo: [20]";
                case "VocabloCtdadDiasUltFechaPago":
                    return "Devuelve un NUMERO ENTERO: la cantidad de días (corridos) desde la fecha del "
                           + "pago mas reciente asociado a la cuenta (para deuda origen y/o cuota de plan). "
                           + "Si no se puede determinar la fecha mas reciente, retorna [-999]. Ejemplo: [45]";
                case "VocabloCtdadDiasUltGestion":
                    return "Devuelve un NUMERO ENTERO: la cantidad de días (corridos) desde la fecha en "
                           + "que se finalizó la última gestión hecha sobre la cuenta (no contempla gestiones "
                           + "pendientes/anuladas). Si no puede determinar dicha fecha, retorna [-999]. Ejemplo: [35]";
                case "VocabloDummy":
                    return "No devuelve valor, pero su evaluación siempre retorna TRUE. Permite aceptar (Selector "
                           + "en TRUE) ó rechazar (Selector en FALSE) todas las cuentas evaluadas, por ejemplo, para "
                           + "tomar las que no fueron tomadas por listas ya generadas (durante un Job).";
                case "VocabloEstadoCuenta":
                    return "Devuelve un TEXTO: el nombre del Estado en que se encuentra la Cuenta actualmente. "
                           + "Ejemplo: [CUENTA CON EMBARGO]";
                case "VocabloFechaSgtePromesaCuota":
                    return "Devuelve una FECHA (DD/MM/YYYY): la fecha cargada en el resultado de la última Gestion "
                           + "finalizada sobre la Cuenta, cuando el Resultado es 'PROMESA PAGO CUOTA'. Si la última "
                           + "Gestión no tiene ese resultado, la evaluación retorna FALSO.";
                case "VocabloFechaSgtePromesaPago":
                    return "FechaSgtePromesaPago";
                case "VocabloFechaSgtePromesaSucursal":
                    return "FechaSgtePromesaSucursal";
                case "VocabloFechaSgtePromesaVisita":
                    return "FechaSgtePromesaVisita";
                case "VocabloFechaUltAsignacionCuenta":
                    return "FechaUltAsignacionCuenta";
                case "VocabloLocalidadTitular":
                    return "LocalidadTitular";
                case "VocabloMontoDeuda":
                    return "MontoDeuda";
                case "VocabloMontoSgteCuotaConvenio":
                    return "MontoSgteCuotaConvenio";
                case "VocabloPoseeCalle":
                    return "VocabloPoseeCalle";
                case "VocabloPoseeConvenioActivo":
                    return "PoseeConvenioActivo";
                case "VocabloPoseeConvenioCaido":
                    return "PoseeConvenioCaido";
                case "VocabloPoseeTelefono":
                    return "PoseeTelefono";
                case "VocabloPoseeCelular":
                    return "PoseeCelular";
                case "VocabloPoseeDescContactoLaboral":
                    return "No devuelve valor, pero su evaluación retorna TRUE si la cuenta posee al menos un contacto"
                           + " Laboral cuya descripción contiene la cadena a evaluarse (el valor de comparación).";
                case "VocabloPoseeGestionPostal":
                    return "VocabloPoseeGestionPostal";
                case "VocabloPoseeGestionTerreno":
                    return "VocabloPoseeGestionTerreno";
                case "VocabloPoseeSolicitudContactoSDH":
                    return "PoseeSolicitudContactoSDH";
                case "VocabloPoseePromesaCuotaSDH":
                    return "PoseePromesaCuotaSDH";
                case "VocabloPoseePromesaPagoSDH":
                    return "PoseePromesaPagoSDH";
                case "VocabloPoseePromesaSucursalSDH":
                    return "PoseePromesaSucursalSDH";
                case "VocabloPoseePromesaSucursalSDH2":
                    return "PoseePromesaSucursalSDH2";
                case "VocabloPoseePromesaVisitaSDH":
                    return "PoseePromesaVisitaSDH";
                case "VocabloProductoCuenta":
                    return "ProductoCuenta";
                case "VocabloTramoActual":
                    return "TramoActual";
                case "VocabloUltimoResGestion":
                    return "UltimoResGestion";
                case "VocabloUltimoTipoPago":
                    return "UltimoTipoPago";
                case "VocabloUsuarioGestor":
                    return "UsuarioGestor";
                default:
                    return "No existe descripción para el Vocablo seleccionado!";
            }            
        }

    }
}