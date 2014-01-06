﻿///////////////////////////////////////////////////////////
//  SgmproMensaje.cs
//  Implementation of the Class SgmproMensaje
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:42
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioToolLibrary.interfases;

namespace sgmpro {
    /// <summary>
    /// Esta clase permite extender la cantidad de mensajes de la aplicación
    /// por sobre los que tare el proto-framework de manera básica. 
    /// </summary>
    internal class SgmproMensaje : IMensajeHelper {
        /// <summary>
        /// Ver descripción en clase Mensaje.
        /// </summary>
        public string textoMensaje(string mensaje) {
            switch (mensaje) {
                    // Titulos de ventanas del sistema
                case "TITULO-ABMV-CONTACTO":
                    return "Gestión de Contactos";
                case "TITULO-CONFIG-GESTION":
                    return "Administración de Datos de Gestión";
                case "TITULO-CONFIG-LISTA":
                    return "Administración de Listas de Gestión";
                case "TITULO-ABMV-GESTION":
                    return "Administración de Gestión de Mora";
                case "TITULO-ABMV-PERSONA":
                    return "Gestión de Personas";
                case "TITULO-ABMV-RECIBO":
                    return "Gestión de Recibos";
                case "TITULO-ABMV-RELACION":
                    return "Gestión de Relaciones entre Personas";
                case "TITULO-ABMV-DEUDA":
                    return "Gestión de Deudas de Cuenta";
                case "TITULO-ABMV-PAGO":
                    return "Gestión de Pagos";
                case "TITULO-ABMV-CUENTA":
                    return "Gestión de Cuentas";
                case "TITULO-ABMV-PRODUCTO":
                    return "Gestión de Productos";
                case "TITULO-ABMV-TRAMO":
                    return "Gestión de Tramos";
                case "TITULO-ABMV-ENTIDAD":
                    return "Gestión de Entidades";
                case "TITULO-ABMV-PARAMETRO":
                    return "Gestión de Parámetros";
                case "TITULO-ABMV-CONVENIO":
                    return "Gestión de Convenios";
                case "TITULO-BANDEJA-GESTIONES":
                    return "Bandeja de Gestiones Asociadas";
                case "TITULO-ABMV-JOBGES":
                    return "Gestión de Generación de Listas de Gestión";
                case "TITULO-ALTA-PAGO":
                    return "Registración Manual de Pago";
                case "TITULO-ALTA-DEUDA":
                    return "Registración Manual de Deuda";
                case "TITULO-CONFIG-LISTAS":
                    return "Administración de Listas de Gestión";
                case "TITULO-GESTIONAR":
                    return "Ejecución de Gestión de Cuenta Morosa";
                case "TITULO-ABMV-ESTRATEGIA":
                    return "Gestión de Estrategias";
                case "TITULO-ABMV-PREDICADO":
                    return "Gestión de Predicados de Estrategias";
                case "TITULO-ABMV-VARIABLE":
                    return "Gestión de Variables de Predicados";
                case "TITULO-ABMV-TIPOCONVENIO":
                    return "Gestión de Tipos de Convenio";
                case "TITULO-ABMV-TIPOLISTA":
                    return "Gestión de Tipos de Listas de Gestión";
                case "TITULO-CARGAMASIVA":
                    return "Carga Masiva de Datos al Sistema";
                case "TITULO-ABMV-FACTURA":
                    return "Gestión de Facturas A a Clientes";
                case "TITULO-ABMV-EXES":
                    return "Gestión de Ejecuciones de Jobs";
                
                    // Mensajes Generales
                case "GENERACION-DOCUMENTOS-INI":
                    return "Iniciando Generación de Documentos:";
                case "GENERACION-DOCUMENTOS-FIN":
                    return "Generación de Documentos finalizada.";

                    // Mensajes del proceso de importacion
                case "IMPORTACION-PROVLOC-INICIO":
                    return "Iniciando importación de Provincias y Localidades...";
                case "IMPORTACION-PROVLOC-FINAL":
                    return "Importación de Provincias y Localidades finalizada.";
                case "IMPORTACION-PERSONA-INICIO":
                    return "Iniciando importación de Personas y Contactos...";
                case "IMPORTACION-PERSONA-FINAL":
                    return "Importación de Personas y Contactos finalizada.";
                case "IMPORTACION-CUENTA-INICIO":
                    return "Iniciando importación de Cuentas y Deudas...";
                case "IMPORTACION-CUENTA-FINAL":
                    return "Importación de Cuentas y Deudas finalizada.";
                case "IMPORTACION-PAGO-INICIO":
                    return "Iniciando importación de Pagos e Imputaciones...";
                case "IMPORTACION-PAGO-FINAL":
                    return "Importación de Pagos e Imputaciones finalizada.";
                case "IMPORTACION-PROMO-INICIO":
                    return "Iniciando importación de Promociones...";
                case "IMPORTACION-PROMO-FINAL":
                    return "Importación de Promociones finalizada.";
                case "IMPORTACION-GESTION-INICIO":
                    return "Iniciando importación de Gestiones...";
                case "IMPORTACION-GESTION-FINAL":
                    return "Importación de Gestiones finalizada.";
                case "IMPORTACION-ESTADOCTA-INICIO":
                    return "Iniciando importación de Estados de Cuenta...";
                case "IMPORTACION-ESTADOCTA-FINAL":
                    return "Importación de Estados de Cuenta finalizada.";
                case "IMPORTACION-ENTIDAD-INICIO":
                    return "Iniciando importación de Entidades...";
                case "IMPORTACION-ENTIDAD-FINAL":
                    return "Importación de Entidades finalizada.";
                case "IMPORTACION-USUARIO-INICIO":
                    return "Iniciando importación de Usuarios...";
                case "IMPORTACION-USUARIO-FINAL":
                    return "Importación de Usuarios finalizada.";
                case "IMPORTACION-RESULTADO-INICIO":
                    return "Iniciando importación de Resultados de Gestión...";
                case "IMPORTACION-RESULTADO-FINAL":
                    return "Importación de Resultados de Gestión finalizada.";
                case "IMPORTACION-PRODUCTO-INICIO":
                    return "Iniciando importación de Productos...";
                case "IMPORTACION-PRODUCTO-FINAL":
                    return "Importación de Productos finalizada.";
                case "IMPORTACION-DESASIGNAR-INICIO":
                    return "Iniciando Desasignación de Cuentas...";
                case "IMPORTACION-DESASIGNAR-FINAL":
                    return "Desasignación de Cuentas finalizada.";
                case "IMPORTACION-PROVENCRED-BLANQUEO":
                    return "Iniciando desasignación de cuentas existentes...";
                case "IMPORTACION-PROVENCRED-BLANQUEO-FIN":
                    return "Desasignación de cuentas existentes finalizada.";
                default:
                    return null;
            }
        }

        /// <summary>
        /// Ver descripción en clase Mensaje.
        /// </summary>
        public string textoMensajeConTerminador(string mensaje) {
            switch (mensaje) {
                case "GESTION-PANEL-CONTACTO":
                    return "Gestionando el panel de Contacto";
                case "GESTION-PANEL-PERSONA":
                    return "Gestionando el panel de Persona";
                case "GESTION-PANEL-RELACION":
                    return "Gestionando el panel de Relación";
                case "GESTION-PANEL-ENTIDAD":
                    return "Gestionando el panel de Entidad";
                case "GESTION-PANEL-CUENTA":
                    return "Gestionando el panel de Cuenta";
                case "GESTION-PANEL-PRODUCTO":
                    return "Gestionando el panel de Producto";
                case "GESTION-FINALIZADA":
                    return "No se puede recargar una Gestión Finalizada!";
                case "ERROR-ENTIDAD":
                    return "Se ha producido un error al gestionar la Entidad!";
                case "ERROR-PERSONA":
                    return "Se ha producido un error al gestionar la Persona!";
                case "ERROR-CONTACTO":
                    return "Se ha producido un error al gestionar el Contacto!";
                case "ERROR-CUENTA":
                    return "Se ha producido un error al gestionar la Cuenta Morosa!";
                case "ERROR-CONVENIO":
                    return "Se ha producido un error al gestionar un Convenio!";
                case "ERROR-DEUDA":
                    return "Se ha producido un error al gestionar una Deuda!";
                case "ERROR-PAGO":
                    return "Se ha producido un error al gestionar un Pago!";
                case "ERROR-IMPUTACION":
                    return "Se ha producido un error al gestionar una Imputación!";
                case "ERROR-PREDICADO":
                    return "Se ha producido un error al gestionar un Predicado!";
                case "ERROR-LISTA-GESTION":
                    return "Se ha producido un error al gestionar una Lista de Gestión!";
                case "ERROR-PAGO-TIPO":
                    return "No se reconoce el tipo de Pago ingresado!";
                case "INFO-PAGO-MODIFICADO":
                    return "Se han recalculado los importes globales del pago. Verifique.";
                case "ERROR-PAGO-CUENTA":
                    return "No puede crearse un Pago sin una Cuenta asociada!";
                case "ERROR-TOTAL-PAGO-MAYOR":
                    return "El importe del Pago no puede ser mayor al de la Deuda seleccionada!";
                case "ERROR-APLICAR-PAGO":
                    return "No se pudo aplicar el Pago ingresado!";
                case "ERROR-IMPUTACION-SOBREIMPORTE":
                    return "No puede imputarse un pago por un monto mayor a su importe!";
                case "ERROR-PAGO-SINIMPORTE":
                    return "El pago asociado no posee importe";
                case "ERROR-PAGO-SINDEUDA":
                    return "Verifique que exista deuda asociada";
                case "ERROR-PRODUCTO":
                    return "Se ha producido un error al gestionar el Producto!";
                case "ERROR-PRODUCTO-TRAMO":
                    return "Se ha producido un error al obtener el Tramo correspondiente del Producto!";
                case "ERROR-TRAMO":
                    return "Se ha producido un error al gestionar el Tramo de Gestión!";
                case "ERROR-FPAGO-CUENTA":
                    return "No puede utilizarse esa Forma de Pago en Cuentas de esa Entidad!";
                case "ERROR-MOVASOCIADO-CUENTA":
                    return "No se pueden asociar Deudas/Pagos de Cuentas distintas!";
                case "ERROR-CANCEL-CUENTA":
                    return "No se puede cancelar la Cuenta seleccionada!";
                case "ERROR-NO-PERMISO-PARA-ESTADO":
                    return "No posee permisos suficientes para utilizar el Estado seleccionado!";
                case "ERROR-NO-GESTOR-PARA-ESTADO":
                    return "Solo el usuario gestor de la cuenta puede modificar el Estado de la misma!";
                case "CANCEL-CUENTA-OK":
                    return "La Cuenta seleccionada ha sido cancelada!";
                case "ERROR-SALDO-HIST-NOADD":
                    return "No se pudo agregar un Historial de Saldo!";
                case "ERROR-PERSONA-MUSTHAVE":
                    return "No se puede seleccionar un Contacto antes que una Persona!";
                case "ERROR-CUENTA-MUSTHAVE":
                    return "No se puede seleccionar un Movimiento antes que una Cuenta!";
                case "ERROR-CONVENIO-DATANOK":
                    return "No se puede calcular el Convenio (Error en los datos del Convenio)!";
                case "ERROR-CONVENIO-NOK":
                    return "No se puede calcular el Convenio (Error Interno)!";
                case "ERROR-CONVENIO-EXISTS":
                    return "No se puede generar un Convenio que ya existe!";
                case "ERROR-CONVENIO-NOEXISTS":
                    return "No existe un Convenio activo asociado a la Cuenta actual!";
                case "ERROR-CONVENIO-NODUP":
                    return "Solo puede haber un Convenio activo por Cuenta!";
                case "ERROR-CONVENIO-YAGEN":
                    return "El Convenio ya ha sido generado o no existe un Tipo aplicable!";
                case "ERROR-CONVENIO-NODEUDA":
                    return "No puede caluclarse el Convenio porque la Cuenta no posee saldo adeudado!";
                case "ERROR-CONVENIO-NODELWIHTPAGO":
                    return "No se puede dar de baja un Convenio activo con pagos asociados!";
                case "ERROR-CONVENIO-NOGEN":
                    return "Debe generar el convenio antes de intentar guardarlo!";
                case "ERROR-MOVCTACTE-NODEL":
                    return "El sistema no permite eliminar una Deuda/Pago (intente revertir)!";
                case "ERROR-NODEL-PROD-CTAS":
                    return "No puede eliminarse un producto que posee Cuentas asociadas!";
                case "ERROR-NOADD-TIPOGESTION":
                    return "No se puede agregar como Tipo de Gestión un elemento que no lo es!";
                case "ERROR-NOADD-TIPOFACTURA":
                    return "No se puede agregar como Tipo de Factura un elemento que no lo es!";
                case "ERROR-NOADD-FORMAPAGO":
                    return "No se puede agregar como Forma de Pago un elemento que no lo es!";
                case "ERROR-NODEL-TIPOGESTION":
                    return "No se puede remover un elemento que no es Tipo de Gestión!";
                case "ERROR-NODEL-TIPOFACTURA":
                    return "No se puede remover un elemento que no es Tipo de Factura!";
                case "ERROR-NODEL-FORMAPAGO":
                    return "No se puede remover un elemento que no es Forma de Pago!";
                case "ERROR-PROD-NO-ENTIDAD":
                    return "El Producto solicitado no pertenece a la Entidad actual!";
                case "ERROR-DATA-GESTION-TIPO-NOK":
                    return "El tipo deseado para la Gestión no es correcto!";
                case "ERROR-ADD-DEUDA":
                    return "El Sistema no permite crear una deuda en forma manual!";
                case "ERROR-DEL-DEUDA":
                    return "El Sistema no permite borrar una deuda en forma manual!";
                case "ERROR-EDIT-DEUDA":
                    return "El Sistema no permite modificar una deuda en forma manual!";
                case "ERROR-ADD-CONVENIO":
                    return "El Sistema no permite crear un convenio desde esta ventana!";
                case "ERROR-EDIT-PAGO":
                    return "El Sistema no permite modificar un pago en forma manual!";
                case "ERROR-DEUDA-PAGO":
                    return "No se ha seleccionado deuda a la cual aplicar el pago!";
                case "ERROR-ACTIVAR-CONVENIO":
                    return "No se ha podido activar el convenio deseado!";
                case "ERROR-CLOSE-LISTA":
                    return "Se ha producido un error al cerrar la lista de gestión!";
                case "ERROR-CLOSE-GESTIONPER":
                    return "Se ha producido un error al cerrar el conjunto de gestión periódica!";
                case "ERROR-GESTION-YAASGINADA":
                    return "No se puede iniciar la gestión porque ésta ya ha sido asignada!";
                case "ERROR-PAGODEUDA-CANCELADA":
                    return "La deuda que se intenta pagar ya ha sido cancelada!";
                case "ERROR-PAGODEUDA-ENCONVENIO":
                    return "La deuda que se intenta gestionar se encuentra bajo Convenio!";
                case "ERROR-PAGODEUDA-NOHAY":
                    return "La cuenta no posee deuda para pagar!";
                case "ERROR-REFINDEUDA-NOHAY":
                    return "La cuenta no posee deuda para refinanciar!";
                case "ERROR-TIPOCONTACTO-NOEDITABLE":
                    return "El contacto no puede editarse debido a su Origen!";
                case "ERROR-CUENTA-NOGESTIONABLE":
                    return "La Cuenta no acepta nuevas gestiones porque no se encuentra activa!";
                case "ERROR-PAGO-RECIBO":
                    return "La carga del Recibo no ha podido ser finalizada!";
                case "ERROR-IMPRIMIR-RECIBO":
                    return "El Recibo no ha podido ser impreso (ha sido guardado, intente reimprimir)!";
                case "ERROR-IMPRIMIR-GESTION":
                    return "El Tipo de Gestión no posee un documento asociado!";
                case "ERROR-EJECUTAR-RESULTADO":
                    return "La gestión se ha modificado, pero no se ha podido ejecutar el resultado!";
                case "PAGO-ANULAR-OK":
                    return "El Pago ha sido correctamente anulado";
                case "DEUDA-ANULAR-OK":
                    return "La deuda ha sido correctamente anulada";
                case "DEUDA-ANULAR-NOK":
                    return "La Deuda no puede anularse porque tiene Pagos asociados!";
                case "ERROR-CONVENIOACTIVO-EXISTS":
                    return "No puede crearse el Convenio porque la Cuenta ya posee uno!";
                case "ERROR-GESTIONESAUTO-NOMORE":
                    return "No existen mas gestiones asignables automáticamente para tu usuario!";
                case "ERROR-CONTACTOPPAL-NODEL":
                    return "No se puede eliminar el Contacto Principal de una Persona!";
                case "ERROR-DATAITEMFACTURA-NOK":
                    return "No se puede agregar el Item a la Factura porque faltan datos!";
                case "ERROR-RESULTADO-REPETIDO":
                    return "No se puede agregar una nueva Gestion con el mismo Resultado a la Cuenta !";
                case "ERROR-EJECUTAR-PAGO-RESULTADO":
                    return "El Pago ha sido aplicado, pero no se ha podido ejecutar el resultado asociado!";
                case "ERROR-JOBRUN-EXIST":
                    return "No puede ejecutarse la generación de lista porque existe un proceso ejecutándose!";
                case "ERROR-JOBRUN-NOEXIST":
                    return "No existe un proceso ejecutándose!";
                case "JOBRUN-INIT":
                    return "Iniciando Trabajo de Generación de Listas";
                case "JOBRUN-DEL-GENPER":
                    return "Descartando las Listas generadas compatibles con el JOB...";
                case "JOBRUN-CREATE-GENPER":
                    return "Creando la Gestion Periodica a utilizarse...";
                case "GESPER-ASENTADA":
                    return "Asentando todas las gestiones creadas para todas las listas...";
                case "JOBRUN-EXE-PASO":
                    return "Ejecutando los pasos de Generación de Listas...";
                case "JOBRUN-SAVE-GENPER":
                    return "Guardando la Gestion Periodica generada...";
                case "JOBRUN-INACTIVO":
                    return "El Trabajo de Generación de Listas seleccionado no se encuentra activo!";
                case "DATA-VOCABLO-NOK":
                    return "Error al trabajar con los datos de un Vocablo!";
                case "DATA-VOCABLO-ERRVALOR":
                    return "El tipo del valor no corresponde";
                case "ERROR-GENERACION-LISTA":
                    return "Se ha producido un error al generar un tipo de lista!";
                case "ERROR-EJECUTAR-GENERACION-LISTA":
                    return "Se ha producido un error al ejecutar la generación del tipo de lista!";
                case "ERROR-INSERT-GESTION-TEMP":
                    return "No ha podido insertarse la gestion temporal para la cuenta!";
                case "ERROR-GENERACION-GESTION":
                    return "Se ha producido un error al generar la gestion para una cuenta!";
                case "JOBRUN-DEL-GES-LISTA":
                    return "Descartando gestiones de la Lista generada";
                case "JOBRUN-DEL-LISTA":
                    return "Dando de baja la Lista generada";
                case "ERROR-EVAL-PREDICADO":
                    return "Se ha producido un error evaluando un predicado (se retorna FALSO)";
                case "ACTION-GESTION-NOK":
                    return "No se puede iniciar la gestión de la Cuenta!";
                case "ACTION-PRINT-NOK":
                    return "No se puede imprimir el reporte asociado a la Gestión!";
                case "ACTION-VIEW-DEUDAPAGO-NOK":
                    return "No se puede ver el detalle de la deuda desde ésta ventana (ingrese desde Cuenta/Convenio)!";
                case "ACTION-VIEW-GESTION-NOK":
                    return "Debe ingresar un Código valido para seleccionar la cuenta!";
                case "DATO-RESULTADO-MODIFICAR":
                    return "Verifique y actualice los datos de Resultado de la Gestión";
                case "PREGUNTA-SAVE-CONVENIO":
                    return "Está seguro de confirmar el Convenio generado?";
                case "PREGUNTA-BAJAR-CONVENIO":
                    return "Esta Cuenta posee un Convenio que debe caer, desea ejecutar la caída?";
                case "PREGUNTA-MODIFICAR-NOELEGIBLE":
                    return "La Cuenta no se encuentra elegible y no se mantuvo el tipo de Resultado, está seguro de guardar los cambios?";
                case "ERROR-CONVENIO-CUOTACERO":
                    return "El cálculo del Convenio arroja un valor de cuota menor o igual a cero!";
                case "ERROR-CONVENIO-ANTICIPO":
                    return "El cálculo del honorario del anticipo del Convenio terminó con error!";
                case "ERROR-CONVENIO-TOTALCUOTA":
                    return "El cálculo del total de cada cuota del Convenio terminó con error!";
                case "ERROR-CONVENIO-COMPCUOTA":
                    return "El cálculo de algún componente de cada cuota del Convenio terminó con error!";
                case "ERROR-CONVENIO-CUOTAMIN":
                    return "El cálculo del Convenio arroja un valor de cuota menor al mínimo aceptable!";
                case "ERROR-CONVENIO-COMPANTICIPO":
                    return "El cálculo de algún componente del anticipo arroja un valor menor o igual a cero!";
                case "ERROR-NO-USER-GESTOR":
                    return "Solo el Gestor de una cuenta puede generar gestiones a la misma!";
                case "ERROR-NO-CHANGE-GESTOR":
                    return "Error al modificar la asignación de Gestor a las Cuentas (verifique)!";
                case "ERROR-POSPAGO-DEUDA":
                    return "No se pudo verificar estados de Cuenta/Convenio (el Pago podría haberse aplicado, verifique)!";
                case "ERROR-POSANULAPAGO-PAGO":
                    return "No se pudo verificar estados de Cuenta/Convenio (el Pago podría haberse anulado, verifique)!";
                case "ERROR-POSCANCELACONVE-CONVE":
                    return "No se pudo verificar estado de Cuenta (el Convenio podría haberse cancelado, verifique)!";
                case "ERROR-POSCAECONVE-CONVE":
                    return "No se pudo verificar estado de Cuenta (el Convenio podría haber caído, verifique)!";
                case "ERROR-POSCANCELTODO-CTA":
                    return "No se pudo verificar estado de Cuenta (el Saldo podría haber sido cancelado, verifique)!";
                case "ERROR-SOLOEDIT-DDAPEND":
                    return "Solamente se pueden anular deudas pendientes!";
                case "ERROR-NODEL-DDACONVE":
                    return "No pueden elimiarse Cuotas de un Convenio!";
                case "ERROR-NOUNDEL-CONVE-NOACT":
                    return "No puede reactivarse un Convenio en una Cuenta que ya posee otro!";
                case "ERROR-NODEL-CONVE-NOACT":
                    return "No puede modificarse un Convenio que no se encuentra activo!";
                case "ACTUALIZA-SALDOS":
                    return "Iniciando la actualizacion de saldos...";
                case "ACTUALIZA-SALDOS-FIN":
                    return "La actualizacion de saldos ha sido finalizada.";
                case "ERROR-USE-CTA-NOACTIVE":
                    return "No puede actualizarse una cuenta que no se encuentra Activa!";
                case "ERROR-LISTA-SIN-TIPO":
                    return "No puede generarse una Lista de Gestión que no posea un Tipo de Lista asociado!";
                case "ERROR-LISTA-TIPO-INCORRECTO":
                    return "El Tipo de la Lista selecccionada no genera gestiones Postales ni de Terreno!";
                case "PREGUNTA-CANCEL-MANUAL-DEUDA":
                    return "Está seguro de cancelar manualmente la Deuda?";
                case "CANCEL-MANUAL-DEUDA-OK":
                    return "La Cancelación Manual de Deuda a sido ejecutada exitosamente!";
                case "CANCEL-MANUAL-DEUDA-NOK":
                    return "La Cancelación Manual de Deuda NO pudo ejecutarse (verifique los datos)!";
                case "ERROR-NO-PERMISO-PARA-DESASIGNAR":
                    return "No posee permisos suficientes para utilizar el Estado Desasignar Cuenta!";
                case "ERROR-PAGO-CTA-SIN-CTOPPAL":
                    return "La Cuenta no posee un Contacto Principal, NO podra generar recibos formales!";
                default:
                    return null;
            }
        }

        /// <summary>
        /// Ver descripción en clase Mensaje.
        /// </summary>
        public string textoValidacion(string mensaje) {
            switch (mensaje) {
                case "CONTACTO-EMAIL":
                    return "El Email debe tener un formato válido";
                case "CONTACTO-PERSONA":
                    return "La Persona asociada es obligatoria";
                case "CONTACTO-PERSONA-SCPPAL":
                    return "No puede dejar a la Persona sin Contacto Principal";
                case "CONVENIO-TIPO":
                    return "El Tipo de Convenio es obligatorio";
                case "CONVENIO-MONTO":
                    return "El monto de deuda original para el Convenio no puede ser cero ni menor";
                case "CONVENIO-MONTOREF":
                    return "El monto a refinanciar para el Convenio no puede ser cero ni menor";
                case "CONVENIO-QUITA":
                    return "El monto de Quita para el Convenio no puede ser menor a cero";
                case "CONVENIO-QUITAMAX":
                    return "El monto de Quita para el Convenio supera el máximo aplicable";
                case "CONVENIO-ANTICIPO":
                    return "El monto del Anticipo para el Convenio no puede ser menor a cero";
                case "CONVENIO-GASTOS":
                    return "El monto de Gastos de Anticipo del Convenio no puede ser mayor al total del Anticipo";
                case "CONVENIO-CTDADCTAS":
                    return "La cantidad de cuotas debe ser mayor a cero";
                case "CONVENIO-CTDADCTAS-MAX":
                    return "La cantidad de cuotas no puede ser mayor a la permitida por el Tipo de Convenio";
                case "CONVENIO-FECHAINI":
                    return "La Fecha de Inicio del Convenio no puede ser menor a hoy";
                case "CUENTA-DESC":
                    return "La Descripción de la Cuenta es obligatoria";
                case "CUENTA-CODIGO":
                    return "El Código de Cuenta es obligatorio";
                case "CUENTA-TITULAR":
                    return "El Titular de la Cuenta es obligatorio";
                case "CUENTA-EXPEDIENTE":
                    return "El Númer de Expediente es obligatorio para una Cuenta en Gestión Legal";
                case "DEUDA-IMPORTE":
                    return "El Importe de la Deuda debe ser válido";
                case "DEUDA-CAPITAL":
                    return "El Capital de la Deuda debe ser válido";
                case "DEUDA-INTERES":
                    return "El Interes de la Deuda debe ser válido";
                case "DEUDA-HONORARIO":
                    return "El Honorario de la Deuda debe ser válido";
                case "DEUDA-GASTO":
                    return "El Gasto de la Deuda debe ser válido";
                case "DEUDA-CUENTA":
                    return "La Cuenta de la Deuda es obligatoria";
                case "DEUDA-DESC":
                    return "La Descripción de la Deuda es obligatoria";
                case "DEUDA-CONCEPTO":
                    return "El Concepto de la Deuda es obligatorio";
                case "DEUDA-DETALLE":
                    return "El Detalle de la Deuda es obligatorio";
                case "DEUDA-FECHA":
                    return "La Fecha de la Deuda debe ser válida";
                case "ENTIDAD-NOMBRE":
                    return "El Nombre de la Empresa es obligatorio";
                case "ENTIDAD-CODIGO":
                    return "El Código de la Empresa es obligatorio";
                case "ENTIDAD-PERSONA":
                    return "La Persona de Contacto de la Empresa es obligatoria";
                case "ENTIDAD-EMAIL":
                    return "El Email debe tener un formato válido";
                case "ENTIDAD-CUIT":
                    return "El Cuit debe tener un formato válido";
                case "ESTRATEGIA-DESC":
                    return "La Descripción de la Estrategia es obligatoria";
                case "ESTRATEGIA-NOMBRE":
                    return "El Nombre de Estrategia es obligatorio";
                case "FACTURA-CLIENTE":
                    return "El Cliente al que realizar la Factura es obligatorio";
                case "FACTURA-TIPO":
                    return "El Tipo del Factura es obligatorio";
                case "FACTURA-FECHA":
                    return "La Fecha de la Factura debe ser válida";
                case "FACTURA-NUMERO":
                    return "El Número de Factura es obligatorio";
                case "RECIBO-NUMERO":
                    return "El Número del Recibo es obligatorio y debe ser válido";
                case "GESTION-DESC":
                    return "La Descripción de la Gestión es obligatoria";
                case "GESTION-RESULTADO":
                    return "El Resultado de la Gestión es obligatorio";
                case "GESTION-PERSONA":
                    return "La Persona asociada a la Gestión es obligatoria para este Tipo de Gestión";
                case "GESTION-CONTACTO":
                    return "El Contacto de la Gestión es obligatorio para este Tipo de Gestión";
                case "GESTION-TIPO":
                    return "El tipo de Gestión es obligatorio";
                case "GESTION-FECHA":
                    return "La Fecha Indicada para el Resultado de la Gestión es obligatoria para este Resultado";
                case "PAGO-DEUDAS":
                    return "Debe seleccionar obligatoriamente Deudas a pagar";
                case "PAGO-IMPORTE":
                    return "El Importe del Pago debe ser válido";
                case "PAGO-CAPITAL":
                    return "El Capital de la Pago debe ser válido";
                case "PAGO-INTERES":
                    return "El Interes de la Pago debe ser válido";
                case "PAGO-HONORARIO":
                    return "El Honorario de la Pago debe ser válido";
                case "PAGO-GASTO":
                    return "El Gasto de la Pago debe ser válido";
                case "PAGO-CUENTA":
                    return "La Cuenta de la Pago es obligatoria";
                case "PAGO-DESC":
                    return "La Descripción de la Pago es obligatoria";
                case "PAGO-CONCEPTO":
                    return "El Concepto de la Pago es obligatorio";
                case "PAGO-TIPO":
                    return "El Tipo del Pago es obligatorio";
                case "PAGO-FORMA":
                    return "La Forma de Pago del Pago es obligatoria";
                case "PAGO-FECHA":
                    return "La Fecha del Pago debe ser válida";
                case "PAGO-FECHA-INGRESO":
                    return "La Fecha de Ingreso del Pago debe ser válida";
                case "PAGO-VS-DEUDA":
                    return "Algún importe del Pago excede a algún importe de la Deuda a cancelar";
                case "PERSONA-NOMBRE":
                    return "El Nombre de la Persona es obligatorio";
                case "PERSONA-CUIT":
                    return "El CUIT de la Persona debe ser válido";
                case "PERSONA-DNI":
                    return "El DNI de la Persona debe ser válido";
                case "PREDICADO-DESC":
                    return "La Descripción del Predicado es obligatoria";
                case "PREDICADO-ORDEN":
                    return "El Número de Orden debe ser mayor a cero";
                case "PRODUCTO-NOMBRE":
                    return "El Nombre del Producto es obligatorio";
                case "PRODUCTO-CODIGO":
                    return "El Código del Producto es obligatorio";
                case "PRODUCTO-DESC":
                    return "La Descripción del Producto es obligatoria";
                case "PRODUCTO-IMPUTACION":
                    return "La Fórmula de Imputación de Pagos del Producto es obligatoria";
                case "PRODUCTO-HONOR":
                    return "El porcentaje de honorarios del Producto debe ser igual o mayor a cero";
                case "RELACION-PERSONAS":
                    return "Las Personas a relacionarse no pueden ser la misma";
                case "TIPOCONV-NOMBRE":
                    return "El Nombre del Tipo de Convenio es obligatorio";
                case "TIPOCONV-TASA":
                    return "La Tasa Pura del convenio debe ser mayor o igual a cero y menor o igual a veinte";
                case "TIPCONV-CTDAD-CTAS":
                    return "La cantidad máxima de cuotas debe ser mayor a uno";
                case "TIPOCONV-MAX-CTASCAIDAS":
                    return "La máxima cantidad de cuotas caidas de gracia debe ser mayor o igual a cero";
                case "TIPOCONV-MAX-CTASAVISO":
                    return "La cantidad de cuotas de aviso debe ser mayor o igual a cero";
                case "TIPOCONV-REGLAHA":
                    return "El Valor de aplicación de la Regla HA debe estar entre 0 y 100 (inclusives)";
                case "TIPOCONV-HONORAR":
                    return "El Valor de actualizacion de honorarios debe estar entre 0 y 100 (inclusives)";
                case "TIPOCONV-MAXCTAS-MAXAVI":
                    return "La cantidad de cuotas de aviso no puede ser mayor a la máxima cantidad de cuotas";
                case "TIPOCONV-FORM-TOTAL":
                    return "La fórmula de Cuota Total debe contener una expresión válida";
                case "TIPOCONV-FORM-INTERES":
                    return "La fórmula de Interés debe contener una expresión válida";
                case "TIPOCONV-FORM-HONORARIO":
                    return "La fórmula de Honorarios debe contener una expresión válida";
                case "TIPOCONV-FORM-GASTOS":
                    return "La fórmula de Gastos debe contener una expresión válida";
                case "TIPOCONV-FORM-HONANT":
                    return "La fórmula de Base del Convenio debe contener una expresión válida";
                case "TIPOCONV-MIN-CUOTAS":
                    return "La cantidad mínima de cuotas de no puede ser menor a cero ni mayor a la máxima cantidad";
                case "TIPOCONV-PUNITORIO":
                    return "La Tasa de Punitorio del convenio debe ser mayor o igual a cero y menor o igual a veinte";
                case "TIPOCONV-VALORMINCU":
                    return "El Valor Mínimo de Cuota de debe ser mayor o igual a cero";
                case "TIPOCONV-VALORMINAN":
                    return "El Valor Mínimo de Anticipo debe ser mayor o igual a cero";
                case "TIPOCONV-MAX-QUITA":
                    return "El Valor Máximo de Quita debe ser mayor o igual a cero";
                case "TIPOLISTA-DESC":
                    return "La Descripción del Tipo de Lista es obligatoria";
                case "TIPOLISTA-NOMBRE":
                    return "El Nombre del Tipo de Lista es obligatorio";
                case "TIPOLISTA-PERFIL":
                    return "El Perfil para gestionar la Lista es obligatorio";
                case "TIPOLISTA-PRIORIDAD":
                    return "La Prioridad de gestión de la Lista debe estar entre 0 y 10";
                case "TRAMO-NOMBRE":
                    return "El Nombre del Tramo es obligatorio";
                case "TRAMO-LIMITE":
                    return "El valor de Límite del Tramo debe ser válido";
                case "TRAMO-HONOR":
                    return "El porcentaje de honorarios del Tramo debe ser igual o mayor a cero";
                case "TRAMO-PUNIT":
                    return "El valor de interes Punitorio del Tramo debe ser igual o mayor a cero";
                case "VARIABLE-DESC":
                    return "La Descripción de la Variable es obligatoria";
                case "VARIABLE-NOMBRE":
                    return "El Nombre de Variable es obligatorio";
                case "VARIABLE-VALOR":
                    return "El Valor de Variable es obligatorio";
                case "GESTION-AC-SIN-CONVENIO":
                    return "No puede guardarse este Resultado si la cuenta no tiene un Convenio activo";
                case "ERROR-CALCULO-BASE-CONVENIO":
                    return "Error al calcular la deuda base para un Convenio";
                case "JOB-NOMBRE":
                    return "El Nombre del Job es obligatorio";
                case "JOB-DESC":
                    return "La Descripción deL Job es obligatoria";
                case "JOB-CRONTAB":
                    return "La definición de periodicidad (dias de ejecución) no es válida";
                default:
                    return null;
            }
        }
    }
}