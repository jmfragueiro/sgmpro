///////////////////////////////////////////////////////////
//  LogSistema.cs
//  Implementation of the Class LogSistema
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:41
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.IO;
using scioLoggingLibrary.excepciones;
using scioLoggingLibrary.interfases;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace scioLoggingLibrary {
    /// <summary>
    /// Esta es una clase helper que implementa un servicio de logging
    /// a un destino de log como un archivo de texto. Se implementa la
    /// Interface IControladorLogging.
    /// </summary>
    public class LogSistema : IControladorLogging {
        private StreamWriter _archivo;
        /// <summary>
        /// Estado del servicio de logging (propiedad de solo lectura, 
        /// que se inicia a 'false' y solo cambia v�a m�todos iniciar() 
        /// y terminar()).
        /// </summary>
        public bool Activo { get; set; }
        /// <summary>
        /// El nivel de corte mensajes a logear (primero se setea en el 
        /// constructor).
        /// </summary>
        public ENivelMensaje NivelMensaje { get; set; }

        /// <summary>
        /// Constructor de la clase que acepta el nivel de ejecuci�n de 
        /// la aplicaci�n para utilizarlo como un corte y restringir los 
        /// mensajes a logear. El nivel de ejecuci�n debe ser una cadena 
        /// que coincida con un valor de la enum ENivelMensaje. Tambi�n 
        /// se setea aqu� el flag de activo a falso.
        /// </summary>
        /// <param name="nivel">
        /// El nivel de ejecuci�n deseado para el sistema (que se utiliza 
        /// al iniciar el subsistema de logging y permite filtrar mensajes 
        /// a logear).
        /// </param> 
        public LogSistema(ENivelMensaje nivel) {
            Activo = false;
            NivelMensaje = nivel;
        }

        /// <summary>
        /// Implementa el M�todo de la Interfaz.
        /// </summary> 
        public void iniciar(string dir, string nombre) {
            // Solo se puede iniciar un log no iniciado
            if (!Activo)
                try {
                    Activo = true;
                    string filename = string.Format("{0}-{1:yyyyMMddHHmm}.log", nombre, DateTime.Now);
                    _archivo = new StreamWriter(dir + "\\" + filename);

                    // Logea para asegurase de que funciona
                    logear("INICIA-LOG", ENivelMensaje.SISTEMA, null);
                    logear("LOG-" + NivelMensaje, ENivelMensaje.SISTEMA, null);
                } catch (Exception ioe) {
                    Activo = false;
                    throw new LogErrorException("NO-INIT-LOG", ioe.ToString());
                }
        }

        /// <summary>
        /// Implementa el M�todo de la Interfaz.
        /// </summary>
        public void logear(string mensaje, ENivelMensaje nivel, string extra) {
            // Solo logea si esta activo y nivel supera el corte
            if (Activo & (nivel >= NivelMensaje))
                try {
                    string msj = "[" 
                        + DateTime.Now + "] => " 
                        + nivel.ToString().ToUpper()
                        + ": " + Mensaje.TextoMensaje(mensaje).Replace(Mensaje.TERMINADOR, string.Empty);
                    
                    msj = (extra == null) 
                            ? msj 
                            : msj + ": " + extra.Replace(Mensaje.TERMINADOR, string.Empty);

                    _archivo.WriteLine(msj);
                    _archivo.Flush();
                } catch (Exception ioe) {
                    throw new LogErrorException("NOLOG", ioe.ToString());
                }
        }

        /// <summary>
        /// Implementa el M�todo de la Interfaz.
        /// </summary>
        public void terminar() {
            try {
                if (_archivo != null) {
                    logear("FIN-LOG", ENivelMensaje.SISTEMA, null);
                    _archivo.Flush();
                    _archivo.Close();
                    _archivo.Dispose();
                    Activo = false;
                }
            } catch (Exception ioe) {
                throw new LogErrorException("NO-FIN-LOG", ioe.ToString());
            }
        }
    }
}