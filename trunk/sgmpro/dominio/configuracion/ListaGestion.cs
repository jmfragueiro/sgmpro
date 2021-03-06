///////////////////////////////////////////////////////////
//  ListaGestion.cs
//  Implementation of the Class ListaGestion
//  Generated by Enterprise Architect
//  Created on:      20-abr-2009 16:57:18
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary;
using scioPersistentLibrary.acceso;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.gestion;
using sgmpro.helpers;
using System.Data;
using scioSecureLibrary.dominio;
using sgmpro.dominio.configuracion.repos;

namespace sgmpro.dominio.configuracion {
    /// <summary>
    ///   Clase que se genera luego del proceso de Generaci�n de Lista
    ///   de Gesti�n.
    /// </summary>
    public class ListaGestion : EntidadIdentificada<ListaGestion> {
        ///<summary>
        ///  Nombre
        ///</summary>
        public virtual string Nombre { get; set; }
        ///<summary>
        ///  Descripci�n
        ///</summary>
        public virtual string Descripcion { get; set; }
        ///<summary>
        ///  Tipo de Lista de Gesti�n
        ///</summary>
        public virtual TipoListaGestion TipoLista { get; set; }
        /// <summary>
        ///   Fecha de creaci�n
        /// </summary>
        public virtual DateTime FchCreacion { get; set; }
        ///<summary>
        ///  Gestiones realizadas
        ///</summary>
        public virtual IList<Gestion> ListaGestiones { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ListaGestion() {
            // Inicializa los atributos
            ListaGestiones = new List<Gestion>();
            FchCreacion = Fechas.FechaNull;
        }

        /// <summary>
        /// Genera una lista de gesti�n a partir de un tipo de lista determinado.
        /// Exige que el tipo de lista ya haya sido seteado antes de comenzar la
        /// generaci�n (de lo contrario lanza una excepcion).
        /// </summary>
        /// <param name="usuario">
        /// Un usuario para asociar las cuentas relacioandas a las gestiones generadas.
        /// </param>
        /// <returns>
        /// Un string indicando el resultado de la generaci�n.
        /// </returns>
        public virtual string generar(Usuario usuario) {
            int cEntProc = 0; //Cantidad de Entidades Procesadas
            int cCueProc = 0; //Cantidad de Cuentas Procesadas
            int cCueIncl = 0; //Cantidad de Cuentas Incluidas

            // Verifica que ya exista seteado el tipo de lista
            if (TipoLista == null)
                throw new AppErrorException("ERROR-LISTA-SIN-TIPO", this.ToString());

            // Primero borra los registros temporales y la memoria
            ProcesosGenerales.LimpiarTemporal();
            ProcesosGenerales.LimpiarMemoria("ListaGestion.generar()");

            // Recorre todas las entidades asignadas que esten vivas y activas
            foreach (Entidad entidad in TipoLista.ListaEntidades)
                if (entidad.Activada && entidad.isAlive()) {
                    // Incrementa el nro de entidades para el log y logea
                    Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION,
                                "Procesa Entidad " + (++cEntProc) + ": " + entidad.Id);

                    // Para cada entidad recorre todas las cuentas
                    using (DataTable dtrows = Cuentas.ObtenerCuentasParaGeneracion(entidad.Id, 
                                                            TipoLista.Elegibilidad, 
                                                            TipoLista.Cancelacion, 
                                                            TipoLista.Pendiente))
                        foreach (DataRow row in dtrows.Rows) {
                            // Ejecuta un garbage collection cada 500 recorridos
                            if ((++cCueProc % 500) == 0)
                                ProcesosGenerales.LimpiarMemoria("E=" + cEntProc + "|CP:" + cCueProc + "|CI:" + cCueIncl);

                            // Establece el id de la cuenta y el usuario gestor en caso 
                            // de existir, sino se coloca como null el mismo (este valor 
                            // se usa despues en el insert temporal y final de la gestion 
                            // para dejar la misma atada al usuario gestor de la cuenta)
                            Guid ctaid = (Guid)row[0];
                            string gestor = (usuario == null
                                                ? ((row[1] is Guid) ? "'" + ((Guid)row[1]) + "'" : "null")
                                                : "'" + usuario.Id + "'");

                            // Verifica si la cuenta pasa las estrategias del tipo de lista
                            if (!Cuenta.Evaluar(ctaid, TipoLista.ListaEstrategias))
                                continue;

                            // Si paso entonces se incluye en la lista temporal a generarse
                            ProcesosGenerales.InsertarTemporal(ctaid.ToString(), this, cCueProc, gestor, TipoLista.TipoGestion);

                            // Cuenta y si supera el numero de cuentas admitidas se termina
                            cCueIncl++;
                            if (TipoLista.MaxCuentas > 0 && cCueIncl >= TipoLista.MaxCuentas)
                                break;
                        }

                    // Ejecuta un garbage collection al finalizar la entidad
                    ProcesosGenerales.LimpiarMemoria("Finaliza la entidad");

                    // Si se supera el numero de cuentas admitidas se termina
                    if (TipoLista.MaxCuentas > 0 && cCueIncl >= TipoLista.MaxCuentas)
                        break;
                }

            // Ejecuta un garbage collection al finalizar la lista
            // Actualiza la estadistica de la generacion de la lista
            Descripcion += string.Format("Entidades:{0}, Cuentas Recorridas:{1}, Cuentas Incluidas:{2}",
                                            cEntProc, cCueProc, cCueIncl);
            Descripcion += (cCueIncl >= TipoLista.MaxCuentas && TipoLista.MaxCuentas > 0)
                                            ? " (Fin por Max.Cuentas)" : " (Fin por Proceso)";

            // Una ultima limpieza al finalizar el proceso
            ProcesosGenerales.LimpiarMemoria(Descripcion);

            // asienta definitivamente las gestiones generadas
            ProcesosGenerales.AsentarGestiones(this, usuario);

            // Finalmente retorna el resultado de la generaci�n
            return ("GENERADA [" + Nombre + "]: " + Descripcion);
        }

        /// <summary>
        /// Cierra una lista de gesti�n descartando todas las gestiones que
        /// no hayan sido procesadas y dando de baja la propia lista. Puede
        /// lanzar una DataErrorException si hay problemas.
        /// </summary>
        public virtual void cerrar() {
            try {
                Descripcion += descartarGestiones();
                base.delete();
            } catch (Exception e) {
                Persistencia.Controlador.rollbackTransaccion();
                refrescar();
                throw new DataErrorException("ERROR-CLOSE-LISTA", e.ToString());
            }
        }

        /// <summary>
        /// Este m�todo descarta todas las gestiones no asignadas de esta lista.
        /// </summary>
        public virtual string descartarGestiones() {
            return ProcesosGenerales.DescartarGestiones(this);
        }

        /// <summary>
        /// Ver descripci�n en clase base. En este caso al deletearse
        /// la lista, primero se cierra la misma, descartando todas
        /// las gestiones generadas para la misma. 
        /// Puede lanzar una DataErrorException si tiene problemas.
        /// </summary>
        public override void delete() {
            if (isAlive())
                cerrar();
        }

        /// <summary>
        /// Este m�todo genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return string.Format("{0} ({1})", Nombre, FchCreacion);
        }
    }
}