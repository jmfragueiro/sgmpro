﻿///////////////////////////////////////////////////////////
//  Gestiones.cs
//  Implementation of the Class Gestiones
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:55:00 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Data;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.enums;
using scioPersistentLibrary.orden;
using scioSecureLibrary.dominio;
using scioToolLibrary;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.configuracion.repos;

namespace sgmpro.dominio.gestion.repos {
    /// <summary>
    /// Esta clase representa al Repositorio de persistencia
    /// de Nhibernate para la entidad Movimiento de Cta Cte 
    /// (Deuda) del sistema.
    /// </summary>
    public class Gestiones : RepositorioPersistente<Gestion> {
        private static readonly Parametro _finalizada = Parametros.GetByClave("ESTADOGESTION.FINALIZADA");
        private static readonly Parametro _pendiente = Parametros.GetByClave("ESTADOGESTION.PENDIENTE");

        /// <summary>
        /// Este método devuelve un listado de gestiones según la persona
        /// que ha sido contactada en las mismas y trayendo primero las
        /// gestiones mas recientes.
        /// </summary>
        /// <param name="contactado">
        /// La persona para la que se desea la Lista de gestiones.
        /// </param>
        /// <returns>
        /// El Listado de gestiones de la persona deseada ordenados por
        /// fecha de cierre en forma descendente (primero la ultima).
        /// </returns>
        public static IList<Gestion> GetByContactado(Persona contactado) {
            return GetByCriteria(
                true,
                new[] {
                    Criterios.Igual("Contactado", contactado),
                    Criterios.Igual("FechaAnulacion", Fechas.FechaNull)
                },
                new[] {Orden.Desc("FechaInicio")});
        }

        /// <summary>
        /// Este método devuelve un listado de gestiones vivas no asigandas, 
        /// y que podrían ser asignables al usuario conectado actualmente, 
        /// para lo cual realiza una serie de cálculos para determinar cuales 
        /// son efectivamente las gestiones que puede agregar. 
        /// </summary>
        /// <param name="usuario">
        /// El usuario para el cual se desea la lista de gestiones.
        /// </param>
        /// <param name="tipo">
        /// El tipo de las gestiones que se desean obtener.
        /// </param>
        /// <returns>
        /// El listado de gestiones no asignadas que el usuario podría asignarse.
        /// </returns>
        public static IList<Gestion> GetUnassignedAsignableByUsuarioTipo(Usuario usuario, Parametro tipo) {
            IList<Gestion> gestiones = new List<Gestion>();

            foreach (Perfil perfil in usuario.Perfiles)
                foreach (TipoListaGestion tipoLg in TiposListaGestion.GetAliveByPerfilTipoGestion(perfil, tipo))
                    foreach (ListaGestion lista in ListasGestion.GetAliveByTipo(tipoLg))
                        //foreach (Gestion gestion in lista.ListaGestiones)
                        //    if (gestion.isAlive() && !gestion.estaAsignada())
                        foreach (Gestion gestion in GetAliveUnasignedByLista(lista))
                                gestiones.Add(gestion);

            return gestiones;
        }

        /// <summary>
        /// Este método devuelve un listado de gestiones vivas de una 
        /// lista determinada y que no han sido aun asigandas.
        /// </summary>
        /// <param name="lista">
        /// El tipo de las gestiones que se desean obtener.
        /// </param>
        /// <returns>
        /// El listado de gestiones vivas de la lista y no asignadas.
        /// </returns>
        public static IList<Gestion> GetAliveUnasignedByLista(ListaGestion lista) {
            return GetByCriteria(
                true,
                new[] {
                    Criterios.Igual("Lista", lista),
                    Criterios.EsNulo("Usuario")
                },
                null);
        }

        /// <summary>
        /// Este método devuelve un listado de gestiones de un tipo definido y que,
        /// si bien han sido asignadas al usuario conectado actualmente, aún no han
        /// sido finalizadas ni están en estado de pendientes.
        /// </summary>
        /// <param name="usuario">
        /// El usuario del y para el cual se desea la lista de gestiones.
        /// </param>
        /// <param name="tipo">
        /// El tipo de las gestiones que se desean obtener.
        /// </param>
        /// <returns>
        /// El listado de gestiones activas que el usuario se ha asignado.
        /// </returns>
        public static IList<Gestion> GetActivasAsignadasByUsuarioTipo(Usuario usuario, Parametro tipo) {
            return GetByCriteria(
                true,
                new[] {
                    Criterios.Igual("Usuario", usuario),
                    Criterios.Igual("Tipo", tipo),
                    Criterios.Distinto("Estado", _finalizada),
                    Criterios.Distinto("Estado", _pendiente)
                },
                null);
        }

        /// <summary>
        /// Este método devuelve un listado de gestiones de un tipo definido y no
        /// finalizadas y no asignadas o asignadas al usuario conectado actualmente, 
        /// para lo cual realiza una serie de calculos para determinar cuales son las 
        /// gestiones que puede mostrar en cada caso. Tienen que ser gestiones que:
        /// a) No han sido asignadas (o iniciadas) aún o han sido asignadas al usuario.
        /// b) Son de un perfil asignado al usuario.
        /// c) No estan dadas de baja.
        /// d) No estan finalizadas.
        /// </summary>
        /// <param name="usuario">
        /// El usuario del y para el cual se desea la lista de gestiones.
        /// </param>
        /// <param name="tipo">
        /// El tipo de las gestiones que se desean obtener.
        /// </param>
        /// <returns>
        /// El listado de gestiones que el usuario podría asignarse.
        /// </returns>
        public static IList<Gestion> GetGestionablesByUsuarioTipo(Usuario usuario, Parametro tipo) {
            // Primero obtiene no asignadas, del tipo deseado, que podrían gestionarse
            IList<Gestion> gestiones = GetUnassignedAsignableByUsuarioTipo(usuario, tipo);

            // Luego las no finalizadas y asignadas al propio usuario (del tipo deseado)
            foreach (Gestion gestion in GetActivasAsignadasByUsuarioTipo(usuario, tipo))
                gestiones.Add(gestion);

            return OrdenarPorPriodidadLista(gestiones);
        }

        /// <summary>
        /// Este método devuelve un listado de gestiones vivas de una 
        /// lista determinada y que no han sido aun asigandas.
        /// </summary>
        /// <param name="lista">
        ///La lista de las que se desea obtener las gestiones.
        /// </param>
        /// <returns>
        /// El listado de gestiones vivas de la lista y no asignadas.
        /// </returns>
        public static long CountAliveUnasignedByLista(ListaGestion lista) {
            return (long)GetAggByCriteria(
                true,
                EFuncionAgregacion.COUNT,
                "Id",
                new[] {
                    Criterios.Igual("Lista", lista),
                    Criterios.EsNulo("Usuario")
                });
        }

        /// <summary>
        /// Este método devuelve la cantidad de gestiones vivas no asigandas, 
        /// y que podrían ser asignables al usuario conectado actualmente, 
        /// para lo cual realiza una serie de cálculos para determinar cuales 
        /// son efectivamente las gestiones que puede agregar. 
        /// </summary>
        /// <param name="usuario">
        /// El usuario para el cual se desea la lista de gestiones.
        /// </param>
        /// <param name="tipo">
        /// El tipo de las gestiones que se desean obtener.
        /// </param>
        /// <returns>
        /// La cantidad de gestiones no asignadas que el usuario podría asignarse.
        /// </returns>
        public static long CountUnassignedAsignableByUsuarioTipo(Usuario usuario, Parametro tipo) {
            long ctdad = 0;

            foreach (Perfil perfil in usuario.Perfiles)
                foreach (TipoListaGestion tipoLg in TiposListaGestion.GetAliveByPerfilTipoGestion(perfil, tipo))
                    foreach (ListaGestion lista in ListasGestion.GetAliveByTipo(tipoLg))
                        ctdad += CountAliveUnasignedByLista(lista);

            return ctdad;
        }

        /// <summary>
        /// Este método devuelve la cantidad de gestiones de un tipo definido y que,
        /// si bien han sido asignadas al usuario que se pasa como parametro, aún no 
        /// han sido finalizadas ni están en estado de pendientes.
        /// </summary>
        /// <param name="usuario">
        /// El usuario del y para el cual se desea la lista de gestiones.
        /// </param>
        /// <param name="tipo">
        /// El tipo de las gestiones que se desean obtener.
        /// </param>
        /// <returns>
        /// La cantidad de gestiones activas que el usuario se ha asignado.
        /// </returns>
        public static long CountActivasAsignadasByUsuarioTipo(Usuario usuario, Parametro tipo) {
            return (long)GetAggByCriteria(
                true,
                EFuncionAgregacion.COUNT,
                "Id",
                new[] {
                    Criterios.Igual("Usuario", usuario),
                    Criterios.Igual("Tipo", tipo),
                    Criterios.Distinto("Estado", _finalizada),
                    Criterios.Distinto("Estado", _pendiente)
                });
        }

        /// <summary>
        /// Este método devuelve la cantidad de gestiones finalizadas del usuario 
        /// que se pasa como parametro.
        /// </summary>
        /// <param name="usuario">
        /// El usuario del y para el cual se desea la lista de gestiones.
        /// </param>
        /// <returns>
        /// La cantidad de gestiones finalizadas del usuario.
        /// </returns>
        public static long CountFinalizadasByUsuario(Usuario usuario) {
            return (long)GetAggByCriteria(
                           true,
                           EFuncionAgregacion.COUNT,
                           "Id",
                           new[] {
                               Criterios.Igual("Estado", _finalizada),
                               Criterios.Igual("Usuario", usuario)
                           });
        }

        /// <summary>
        /// Este método devuelve la cantidad de gestiones pendientes del usuario 
        /// que se pasa como parametro.
        /// </summary>
        /// <param name="usuario">
        /// El usuario del y para el cual se desea la lista de gestiones.
        /// </param>
        /// <returns>
        /// La cantidad de gestiones pendientes del usuario.
        /// </returns>
        public static long CountPendientesByUsuario(Usuario usuario) {
            return (long)GetAggByCriteria(
                           true,
                           EFuncionAgregacion.COUNT,
                           "Id",
                           new[] {
                               Criterios.Igual("Estado", _pendiente),
                               Criterios.Igual("Usuario", usuario)
                           });
        }

        /// <summary>
        /// Este método devuelve la cantidad de gestiones finalizadas del usuario 
        /// conectado actualmente.
        /// </summary>
        /// <param name="usuario">
        /// El usuario del y para el cual se desea la lista de gestiones.
        /// </param>
        /// <param name="tipo">
        /// El tipo de las gestiones que se desean obtener.
        /// </param>
        /// <returns>
        /// La cantidad de gestiones pendientes del usuario.
        /// </returns>
        public static long CountGestionablesByUsuarioTipo(Usuario usuario, Parametro tipo) {
            return (CountUnassignedAsignableByUsuarioTipo(usuario, tipo)
                    + CountActivasAsignadasByUsuarioTipo(usuario, tipo));
        }

        /// <summary>
        /// Este método obtiene una siguiente cuenta para gestionar, para el 
        /// usuario pasado como argumento y para alguno de los tipos de gestion
        /// del segundo argumento, obvio esto si bien justo antes de entrar la
        /// gestión podría ser tomada por otro usuario.
        /// </summary>
        /// <param name="usuario">
        /// El usuario para el cual se buscan las gestiones.
        /// </param>
        /// <param name="tipos">
        /// Los tipos de gestiones entre los que se buscan.
        /// </param>
        /// <returns>
        /// La siguiente probable cuenta para gestionar o null si no hay mas.
        /// </returns>
        public static Gestion ObtenerSiguienteGestion(Usuario usuario, params Parametro[] tipos) {
            // Busca los perfiles del usuario
            foreach (Perfil perfil in usuario.Perfiles)
                // ...por cada tipo de gestion en tipos
                foreach (Parametro tipo in tipos)
                    // ...por cada perfil busca los tipos de listas generadas para gestión telefónica
                    foreach (TipoListaGestion tipoLg in TiposListaGestion.GetAliveByPerfilTipoGestion(perfil, tipo))
                        // ...por cada tipo de lista busca alguna lista activa
                        foreach (ListaGestion lista in ListasGestion.GetAliveByTipo(tipoLg)) {
                            // ...entonces busca las gestiones creadas
                            DataTable dt = SelectByCriteria(
                                true,
                                new[] {Criterios.EsNulo("Usuario"), Criterios.Igual("Lista", lista)},
                                null);
                            // ...si encuentra una retorna esa
                            if (dt.Rows.Count > 0)
                                return GetById((Guid) dt.Rows[0]["Id"]);
                        }

            return null;
        }

        /// <summary>
        /// Este método ordena un conjunto de gestiones según su fecha de
        /// cierre pero en forma descendente (primero van los mas nuevos).
        /// </summary>
        /// <param name="origen">
        /// El conjunto de gestiones a ordenar.
        /// </param>
        /// <returns>
        /// El conjunto de gestiones ordenado por fecha de cierre (descendente).
        /// </returns>
        public static IList<Gestion> OrdenarPorFechaCierreDesc(IList<Gestion> origen) {
            IList<Gestion> conjunto = new List<Gestion>();
            Gestion temp = new Gestion();

            while (conjunto.Count < origen.Count) {
                DateTime piso = Fechas.FechaNull.AddYears(-99);
                foreach (Gestion obj in origen)
                    if (!conjunto.Contains(obj))
                        if (obj.FechaCierre > piso) {
                            piso = obj.FechaCierre;
                            temp = obj;
                        }
                conjunto.Add(temp);
            }

            return conjunto;
        }

        /// <summary>
        /// Este método ordena un conjunto de gestiones según la prioridad de su lista
        /// y, para igual prioridad, por fecha de ultima modificacion ascendente. Las
        /// prioridades se toman como que las mayores son mas prioritarias, es decir 
        /// que una lista con prioridad 10 pone a sus gestiones antes que una con la
        /// prioridad 5.
        /// </summary>
        /// <param name="origen">
        /// El conjunto de gestiones a ordenar.
        /// </param>
        /// <returns>
        /// El conjunto de gestiones ordenado por prioridad de su lista.
        /// </returns>
        public static IList<Gestion> OrdenarPorPriodidadLista(IList<Gestion> origen) {
            IList<Gestion> conjunto = new List<Gestion>();
            Gestion temp = new Gestion();

            while (conjunto.Count < origen.Count) {
                long piso = -1;
                DateTime techo;
                DateTime tecori = techo = DateTime.Now.AddYears(99);
                foreach (Gestion obj in origen)
                    if (!conjunto.Contains(obj)) {
                        long prio = 0;
                        try{ prio = obj.Lista.TipoLista.Prioridad; } catch {}
                        if (prio >= piso) {
                            if (prio > piso) {
                                techo = tecori;
                                piso = prio;
                            }

                            if (obj.FechaUMod < techo) {
                                techo = obj.FechaUMod;
                                temp = obj;
                            }
                        }
                    }
                conjunto.Add(temp);
            }

            return conjunto;
        }
    }
}