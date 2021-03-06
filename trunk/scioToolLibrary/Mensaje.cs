///////////////////////////////////////////////////////////
//  Mensaje.cs
//  Implementation of the Class Mensaje
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:41
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioToolLibrary.enums;
using scioToolLibrary.interfases;

namespace scioToolLibrary {
    /// <summary>
    /// Esta es una clase helper que implementa el concepto de mensaje 
    /// dentro del sistema. Permite unificar el tratamiento de mensajes
    /// dentro de la aplicaci�n y los textos que se muestran. Posee un
    /// m�todo para mostrar un mensaje y otro para solo logear (utiliza
    /// la clase LogSistema para tal proposito).
    /// </summary>
    public class Mensaje {
        public static readonly string TERMINADOR = "***";

        /// <summary>
        /// Este atributo permite contener una clase extra que ayude a esta
        /// agregando mensajes personalizados para acciones propias de los
        /// proyecto creados con el proto-framework.
        /// </summary>
        public static IMensajeHelper Helper { get; set;}

        /// <summary>
        /// M�todo para decodificar una cadena como un valor tipo 
        /// de Mensaje, es decir como un valor de la enumeraci�n
        /// ENivelMensaje.
        /// </summary>
        /// <param name="nivel">
        /// El nivel del mensaje representado como cadena.
        /// </param> 
        /// <returns>
        /// Retorna el valor de enumeraci�n correspondiente a la
        /// cadena pasada como argumento o bien el valor [ERROR].
        /// </returns>
        public static ENivelMensaje DecodeNivelMensaje(string nivel) {
            switch (nivel) {
                case "DEBUG":
                    return ENivelMensaje.DEBUG;
                case "INFORMACION":
                    return ENivelMensaje.INFORMACION;
                case "FATAL":
                    return ENivelMensaje.FATAL;
                case "PREGUNTA":
                    return ENivelMensaje.PREGUNTA;
                case "SISTEMA":
                    return ENivelMensaje.SISTEMA;
                case "BATCH":
                    return ENivelMensaje.BATCH;
                default:
                    return ENivelMensaje.ERROR;
            }
        }

        /// <summary>
        /// Punto de entrada a la decodificaci�n de mensajes estandarizados.
        /// Este m�thod sirve para obtener el texto completo de un mensaje a 
        /// partir de una cadena identificadora codificada (debe esta aqu�).
        /// Esta intenta primero con codigos de mensajes que NO incluyen una 
        /// cadena terminadora (dada x el att de clase TERMINADOR), pero si
        /// no hay ningun aqu� mensaje que coincida con el codigo pasado =>
        /// se lo pasa a textoMensajeConTerminador para buscar por all�.
        /// </summary>
        /// <param name="mensaje">
        /// La cadena codigo identificador del mensaje a devolver.
        /// </param> 
        /// <returns>
        /// Retorna el texto del mensaje que coincide con dicho c�digo pasado 
        /// como argumento y SIN una cadena terminadora o, si no encuentra el 
        /// codigo, el mensaje que devuelve textoMensajeConTerminador sumando
        /// dicha cadena terminadora.
        /// </returns>
        public static string TextoMensaje(string mensaje) {
            switch (mensaje) {
                    // Mensajes asociados a la barra de estado
                case "AYUDA-LISTO":
                    return "Listo...";
                case "UPDATE-DATAPANEL":
                    return "Actualizando la informaci�n del panel de datos...";
                case "UPDATE-LISTPANEL":
                    return "Actualizando la informaci�n del listado de datos...";
                case "USUARIO-PRE":
                    return "Usuario: ";
                case "EXTRA1-INICIAL":
                    return "Sin Sesi�n";
                case "USUARIO-INICIANDO":
                    return "Iniciando Sesi�n de Usuario...";
                case "USUARIO-CERRANDO":
                    return "Cerrando Sesi�n de Usuario...";
                case "DB-PRE":
                    return "Base: ";
                case "EXTRA2-INICIAL":
                    return "No Conectado";
                case "REPORTE-AYUDA":
                    return "Preparando el Reporte solicitado...";

                    // Mensajes asociados al servicio de logging
                case "INICIA-LOG":
                    return "######### INICIO ARCHIVO DE LOG [" + DateTime.Now + "] ########";
                case "FIN-LOG":
                    return "######## FIN ARCHIVO DE LOG [" + DateTime.Now + "] ########";

                    // Titulos de ventanas del sistema
                case "TITULO-SHOW":
                    return "SgmPro 2";
                case "ACERCADE":
                    return "Acerca de SgmPro 2...";
                case "INICIAR-SESION":
                    return "Iniciar Sesi�n de Usuario"; 
                case "TITULO-ABMV-GENERICO":
                    return "Gesti�n de ";
                case "TITULO-ADMIN-GENERICO":
                    return "Administraci�n de Datos";
                case "TITULO-SET-GENERICO":
                    return "Asignaci�n de Par�metros del Sistema";
                case "TITULO-CONFIG-SEGURIDAD":
                    return "Administraci�n de Seguridad y Perfiles";
                case "TITULO-ABMV-PARAMETRO":
                    return "Gesti�n de Par�metros";
                case "TITULO-ABMV-USUARIO":
                    return "Gesti�n de Usuarios";
                case "TITULO-ABMV-ROL":
                    return "Gesti�n de Roles";
                case "TITULO-ABMV-PERFIL":
                    return "Gesti�n de Perfiles";

                    // Mensajes del proceso de importacion
                case "IMPORTACION-ERROR-NOK":
                    return "Error durante la importaci�n de un dato!";
                case "IMPORTACION-ERROR-NODATA":
                    return "Faltan datos para iniciar la importaci�n!";
                case "IMPORTACION-ERROR-NOFILE":
                    return "No se ha especificado el nombre del archivo �nico";
                case "IMPORTACION-INICIO":
                    return "Iniciando un proceso de importaci�n.";
                case "IMPORTACION-FINAL":
                    return "El proceso de importaci�n ha finalizado.";
                case "IMPORTACION-REVISAR":
                    return "Verifique el log del Sistema para detectar problemas";
                case "IMPORTACION-AYUDA":
                    return "Ejecutando el proceso de importaci�n de datos (carga masiva)...";

                    // Mensajes del proceso de generacion de documentos
                case "GENERACION-DOC-AYUDA":
                    return "Ejecutando el proceso de generaci�n de Documentos...";

            }
            
            // Si no ubico el mensaje busca en el helper (si hay)
            string otroMensaje = null;
            if (Helper != null)
                otroMensaje = Helper.textoMensaje(mensaje);

            // Cuando no reconoce el mensaje sigue con la cadena con 
            // terminador, sino vuelve con la cadena encontrada
            return otroMensaje ?? TextoMensajeConTerminador(mensaje) + TERMINADOR;            
        }

        /// <summary>
        /// Versi�n del m�todo para obtener el texto completo de un mensaje, 
        /// a partir de una cadena identificadora codificada, el cual deberia 
        /// incluir una cadena terminadora (dada x el att de clase TERMINADOR) 
        /// para diferenciar el logging de lo mostrado por pantalla. Si no hay 
        /// ningun aqu� mensaje que coincida se devuelve una cadena que indica
        /// tal situaci�n.
        /// </summary>
        /// <param name="mensaje">
        /// La cadena codigo identificador del mensaje a devolver.
        /// </param> 
        /// <returns>
        /// Retorna el texto del mensaje que coincide con dicho c�digo pasado 
        /// como argumento o bien retorna un msje que dice que no entiende el 
        /// c�digo.
        /// </returns>
        private static string TextoMensajeConTerminador(string mensaje) {
            switch (mensaje) {
                    // Mensajes generales de la aplicaci�n
                case "MENSAJE-NOK":
                    return "Fallo al mostrar un mensaje del Sistema!";
                case "MENU-COMPLETO":
                    return "Generando el Menu Principal completo del Sistema...";
                case "MENU-BASE":
                    return "Generando el Menu Principal del Sistema...";
                case "MENU-NOK":
                    return "Error generando un Menu del Sistema...";
                case "EXCEPTION":
                    return "Excepci�n del Sistema";
                case "GENERICO":
                    return "Mensaje Gen�rico";
                case "APP-NOINIT-ERROR":
                    return "El Sistema no puede iniciarse debido a un error fatal!\r\nContacte al Administrador...";
                case "APP-EXIT-ERROR":
                    return "El Sistema ha lanzado una excepci�n fatal cerrando la aplicaci�n...";
                case "APP-INIT-EXIT":
                    return "El Sistema ha comenzado a cerrarse...";
                case "APP-ERROR":
                    return "Error interno del Sistema!";
                case "APP-CTRL-ERROR":
                    return "Error en un controlador interno del Sistema!";
                case "APP-CRYPT-ERROR":
                    return "Error en el motor de encriptaci�n del Sistema!";
                case "APP-FIN":
                    return "Finalizando la aplicaci�n...";
                case "CONFIG-SIS-NOK":
                    return "No se ha podido establecer una configuraci�n del Sistema!";
                case "SISTEMA-JOBRUN-INIT":
                    return "Iniciando el Sistema en modo desatendido para ejecucion de procesos batch...";
                case "SISTEMA-JOBRUN-ERROR":
                    return "Se ha producido un error en la ejecucion de un proceso batch!";
                case "SISTEMA-JOBRUN-OK":
                    return "La ejecucion de un proceso batch ha finalizado con �xito";
                case "SISTEMA-JOBRUN-END":
                    return "Terminando la ejecucion en modo desatendido para ejecucion de procesos batch del Sistema";
                case "JOBRUN-EXIST-VERIFY":
                    return "Verificando existencia de procesos batch en ejecuci�n..";
                case "JOBRUN-VERIFY":
                    return "Determinando los trabajos batch (JOBs) a ejecutar.";
                case "JOBRUN-COUNT":
                    return "Cantidad de trabajos batch (JOBs) a ejecutar determinada";
                case "JOBRUN-TIMEWIN":
                    return "Ventana de tiempo, para captaci�n de JOBs, configurada";
                case "JOBRUN-VERIFY-NOK":
                    return "No existen trabajos (JOB) pendientes de ejecuci�n a este momento..";
                case "SISTEMA-OK":
                    return "El sistema ha pasado exitosamente la validaci�n de integridad";
                case "SISTEMA-NOK":
                    return "El sistema no ha pasado la validaci�n de integridad!";
                case "CONFIG-PARAM":
                    return "Se ha configurado un Par�metro General";
                case "RECURSO-NOEXISTS":
                    return "No existe el Recurso del Sistema solicitado!";
                case "PERMISO-ERROR":
                    return "Se ha producido un error verificando un Permiso!";
                case "PERMISO-NOK":
                    return "No tiene permiso para realizar la acci�n solicitada!";
                case "AYUDA-NOREADY":
                    return "La cach� de ayuda se est� construyendo, por favor intente m�s tarde";
                case "FORMATO-DATE-NOK":
                    return "Formato de fecha/hora incorrecto";
                case "PROCESO-OK":
                    return "El proceso ha finalizado con �xito";
                case "PROCESO-NOK":
                    return "El proceso se ha interrumpido por un error";
                case "ERROR-EDIT-ELEMENTO":
                    return "El Sistema no permite modificar el elemento seleccionado en forma manual!";
                case "ERROR-FORMAT-ELEMENTO":
                    return "El formato del campo no admite el valor ingresado!";
                case "ERROR-FATAL":
                    return "Se ha producido un Error Fatal en el sistema!";
                case "ERROR-ELEMENTO-NULO":
                    return "El Elemento requerido es nulo!";
                case "ERROR-ELEMENTO-NOINLIST":
                    return "El Elemento desado no pertenece al conjunto destino!";
                case "ERROR-ELEMENTO-INLIST":
                    return "El Elemento desado no puede repetirse en el conjunto destino!";

                    // Mensajes asociados al Servicio de Persistencia
                case "DB-CREAR":
                    return "Creando sesi�n para el Servicio de Persistencia...";
                case "DB-CONECTADO":
                    return "Conectado con sesi�n al Servicio de Persistencia";
                case "DB-DESCONECTADO":
                    return "Desconectado de la sesi�n del Servicio de Persistencia";
                case "DB-TRANSACC":
                    return "Creando transacci�n para el Servicio de Persistencia";
                case "DB-COMMIT":
                    return "Comiteando transacci�n del Servicio de Persistencia";
                case "DB-ROLLBACK":
                    return "Rollbackeando transacci�n del Servicio de Persistencia";
                case "DB-DESCONECTAR":
                    return "Desconectando sesi�n del Servicio de Persistencia";
                case "DB-SET-CONN":
                    return "Estableciendo los par�metros de conexi�n a la base";
                case "DB-ERROR":
                    return "Error al procesar sentencia del Servicio de Persistencia!";
                case "DB-INIT-ERROR":
                    return "Error al iniciar el Servicio de Persistencia!";
                case "DB-SET-ERROR":
                    return "Error al establecer un par�metro del Servicio de Persistencia!";
                case "DB-COMMIT-ERROR":
                    return "Error al procesar COMMIT del Servicio de Persistencia!";
                case "DB-ROLLBACK-ERROR":
                    return "Error al procesar ROLLBACK del Servicio de Persistencia!";
                case "DB-CLOSE-ERROR":
                    return "Error al cerrar Sesi�n del Servicio de Persistencia!";
                case "DB-FIN-ERROR":
                    return "Error al terminar Sesi�n del Servicio de Persistencia!";
                case "DB-INITRAN-ERROR":
                    return "Error al iniciar Transacci�n del Servicio de Persistencia!";
                case "DB-ERROR-NOINIT":
                    return "No puede trabajar con el Servicio de Persistencia porque no se a iniciado!";
                case "DB-ERROR-NOSESION":
                    return "No se puede acceder al Servicio de Persistencia (no hay sesi�n)!";
                case "DB-ERROR-NOCONN":
                    return "No se puede conectar con el Servicio de Persistencia!";
                case "DB-ERROR-NOTRANSACC":
                    return "No se puede operar con el Servicio de Persistencia (no hay transacci�n)!";
                case "DB-ERROR-NOISALIVE":
                    return "No se puede determinar el m�todo de verificaci�n persitente IsAlive!";
                case "DB-SQL-ADHOC":
                    return "Ejecutando sentencia SQL ad-hoc";

                    // Mensajes asociados a la gesti�n de controladores de casos de uso
                case "UCCALLER":
                    return "Ejecutando un m�dulo externo";
                case "UCCALLER-NOINIT":
                    return "Error al iniciar un m�dulo externo";
                case "UCCALLER-NOK":
                    return "Error al intentar ejecutar un m�dulo externo";
                case "UCCALLER-NOPADRE":
                    return "Tipo de padre esperado incorrecto externo";

                    // Mensajes asociados al servicio de logging
                case "NOLOG":
                    return "Fallo interno en el servicio de Logging del Sistema!";
                case "NO-INIT-LOG":
                    return "No se puede iniciar el servicio de Logging del Sistema!";
                case "NO-FIN-LOG":
                    return "No se puede cerrar el servicio de Logging del Sistema!";
                case "LOG-DEBUG":
                    return "Se ha iniciado el Log en modo DEBUG";
                case "LOG-INFORMACION":
                    return "Se ha iniciado el Log en modo INFORMACION";
                case "LOG-ERROR":
                    return "Se ha iniciado el Log en modo ERROR";
                case "LOG-FATAL":
                    return "Se ha iniciado el Log en modo FATAL";
                case "LOG-PREGUNTA":
                    return "Se ha iniciado el Log en modo PREGUNTA";
                case "LOG-SISTEMA":
                    return "Se ha iniciado el Log en modo SISTEMA";
                case "LOG-BATCH":
                    return "Se ha iniciado el Log en modo BATCH";

                    // Mensajes asociados a las vistas del sistema
                case "VISTA-INIT":
                    return "Iniciando una Vista del Sistema";
                case "VISTA-NOK":
                    return "No se ha podido inicializar una Vista del Sistema!";
                case "VISTA-NOREADY":
                    return "Se intent� cargar una Vista del Sistema que no esta lista!";
                case "VISTA-CLOSE":
                    return "Cerrando una Vista del Sistema";
                case "VISTA-NO-PARENT":
                    return "El elemento no posee un contenedor visual v�lido!";
                case "VISTA-CLOSE-NOK":
                    return "No se pudo cerrar correctamente una Vista del Sistema";
                case "VISTA-MENU-NOK":
                    return "Se ha producido un error al actualizar el Men� del Sistema!";
                case "VISTA-MENU-EXE-NOK":
                    return "Se ha producido un error al ejecutar una acci�n del men� del Sistema!";
                case "VISTA-EXE-GENERACION":
                    return "Ejecutando el proceso de generaci�n de listas...";
                case "PANEL-NOK":
                    return "Se ha producido un error al gestionar el Panel de datos!";
                case "PANEL-SETOBJECT-NOK":
                    return "No se ha proporcionado un elemento esperado por el Panel de datos!";
                case "PANEL-GETED-NOK":
                    return "Se ha producido un error al crear/obtener el Panel de Edici�n de datos!";
                case "PANEL-GETLS-NOK":
                    return "Se ha producido un error al crear/obtener el Panel de Listado de datos!";
                case "PANEL-LS-UPDATEROW-NOK":
                    return "Se ha producido un error al obtener el registro del listado de datos!";
                case "PANEL-GETPV-NOK":
                    return "Se ha producido un error al crear/obtener el Panel de Preview de datos!";
                case "PANEL-PARAM":
                    return "Par�metro de base";
                case "PANEL-ENUM":
                    return "Enumeraci�n";
                case "LISTADO-UPDATE-NOK":
                    return "Error al actualizar los registros del listado!";
                case "LISTADO-NOK":
                    return "Error al gestionar un listado de datos del Sistema!";
                case "SUBLISTADO-NOK":
                    return "Error al gestionar un listado detail (sublistado) del panel!";
                case "ROW-NOK":
                    return "Error al seleccionar un registro del listado!";
                case "ROW-MUST":
                    return "Debe seleccionar un registro del listado para operar!";
                case "ROW-NOTALIVE":
                    return "El elemento seleccionado debe estar activo/vivo/abierto para operar!";
                case "TREE-NOK":
                    return "Error al generar un �rbol de opciones!";
                case "SELECT-CUENTAS-NOK":
                    return "Error al generar un filtro de selecci�n de Cuentas!";
                case "VISTA-SELECT-NOK":
                    return "Error al gestionar la ventana de Selecci�n!";
                case "VISTA-SELECT-COLS-NOK":
                    return "Error al establecer las columnas de filtro en la ventana de Selecci�n!";
                case "VISTA-SELECT-FILTER-NOK":
                    return "Error al ejecutar el filtro en la ventana de Selecci�n!";
                case "VISTA-SELECT-ADDFILTER-NOK":
                    return "Error al agregar un criterio de filtro en la ventana de Selecci�n!";
                case "VISTA-FILTRO-NOK":
                    return "Error al gestionar la ventana de Filtro!";
                case "VISTA-FILTRO-NOCOL":
                    return "No se puede filtrar el presente listado!";
                case "VISTA-FILTRO-COLNOK":
                    return "Error al gestionar las columnas de Filtro!";
                case "VISTA-FILTRO-VIEWNOK":
                    return "Error al mostrar los criterios de Filtro!";
                case "VISTA-FILTRO-ADDNOK":
                    return "No se puede agregar un criterio de Filtro!";
                case "VISTA-FILTRO-CRITNOK":
                    return "No se reconoce el criterio de Filtro seleccionado!";
                case "VISTA-SET-DATANOK":
                    return "No se pueden configurar par�metros porque faltan datos!";
                case "CAMPO-NOK":
                    return "Campo inv�lido";

                    // Mensajes asociados a la sesi�n de usuario
                case "SESION-INIT":
                    return "Intentando iniciar la sesi�n de usuario";
                case "SESION-INIT-NODATA":
                    return "Debe ingresar Usuario y Contrase�a para iniciar la sesi�n!";
                case "SESION-DATA-ERROR":
                    return "Error al validar Usuario/Contrase�a ingresados!";
                case "SESION-INIT-ERROR":
                    return "Error al intentar iniciar la sesi�n de usuario!";
                case "SESION-INIT-OK":
                    return "Se ha iniciado correctamente la sesion de usuario";
                case "SESION-EXISTS":
                    return "No puede iniciarse una sesi�n de usuario porque ya existe una!";
                case "SESION-ERROR":
                    return "No se puede acceder a la sesi�n de usuario actual!";
                case "SESION-NOEXISTS":
                    return "No se ha iniciado ninguna sesi�n de usuario!";
                case "SESION-NOACTIVA":
                    return "La sesi�n de usuario actual no se ha activado!";
                case "USER-STATE-ERROR":
                    return "La cuenta del usuario se encuentra desactivada!";
                case "SESION-INIFIN":
                    return "Finalizando la sesi�n de Usuario...";
                case "SESION-FIN":
                    return "La sesi�n de Usuario ha sido finalizada correctamente...";

                    // Mensajes de administracion
                case "ERROR-NOADD-ELEMENTO":
                    return "El elemento no puede agregarse (es inv�lido/ya existe/no est� completo)!";
                case "ERROR-NODEL-ELEMENTO":
                    return "El elemento no puede quitarse (es inv�lido/no existe/no est� completo)!";
                case "ERROR-USE-ELEMENTO-NOALIVE":
                    return "No puede utilizarse un elemento que ha sido eliminado!";
                case "ERROR-DATA-LESS-THAN-EXPECT":
                    return "Faltan datos para ejecutar la acci�n requerida!";
                case "ERROR-ADD-WITHOUT-MASTER":
                    return "No se puede crear el elemento porque depende de otro que no se ha proporcionado!";
                case "ERROR-USUARIO":
                    return "Se ha producido un error al gestionar el Usuario!";
                case "ERROR-PERMISO-USUARIO":
                    return "No se ha podido verificar un permiso del Usuario!";
                case "ERROR-ROL":
                    return "Se ha producido un error al gestionar el Rol!";
                case "ERROR-PERMISO":
                    return "Se ha producido un error al gestionar el Permiso!";
                case "ERROR-PERFIL":
                    return "Se ha producido un error al gestionar el Perfil!";

                    // Mensajes genericos asociados a campos de datos 
                case "DATA-NOK":
                    return "Los datos ingresados/editados para un objeto no son v�lidos!";
                case "DATA-SAVEOK":
                    return "Los datos ingresados/editados se han guardado con �xito";
                case "DATA-SAVENOK":
                    return "Los datos ingresados/editados no se han guardado!";
                case "DATA-DELOK":
                    return "Los datos se han eliminado con �xito";
                case "DATA-DELNOK":
                    return "Los datos no se han podido eliminar!";
                case "DATA-DEL-NOVALID":
                    return "Los datos de este tipo no puede ser eliminados!";
                case "DATA-EDITNOK":
                    return "Los datos no pueden editarse!";
                case "DATA-ADDNOK":
                    return "Los datos no pueden crearse!";
                case "DATA-LISTNOK":
                    return "No se ha podido generar un listado de datos para mostrar!";
                case "DATA-VERIFYNOK":
                    return "No se ha podido verificar los datos de un Panel!";
                case "DATA-LS-FILTERNOK":
                    return "No se ha podido generar/aplicar un filtro al listado de datos!";
                case "DATA-LS-DELNOK":
                    return "Un registro del listado no se ha podido eliminar!";
                case "DATA-LS-EDITNOK":
                    return "Un registro del listado no ha podido editarse!";
                case "DATA-LS-ADDNOK":
                    return "No se ha podido agregar un nuevo registro al listado!";
                case "DATA-OBJNOK":
                    return "No existe un elemento seleccionado actualmente!";
                case "DATA-VIEWNOK":
                    return "No pueden mostrarse los datos seleccionados!";
                case "DATA-REVIEW":
                    return "El elemento seleccionado es el que realmente est� viendo!";
                case "DATA-EDITORIGEN":
                    return "Este elemento solo puede editarse desde su Origen!";
                case "DATA-LOADNOK":
                    return "Los datos del elemento no han podido ser cargados!";
                case "DATA-SETNOK":
                    return "No se ha podido establecer en el panel el elemento seleccionado!";
                case "DATA-DIRTYNOK":
                    return "No se ha podido determinar el estado de actualizaci�n del elemento!";
                case "DATA-UPDATENOK":
                    return "No se pudo actualizar la informaci�n dentro del elemento!";
                case "DATA-GETNOK":
                    return "No se pudieron procesar las acciones del panel de datos!";
                case "DATA-UNDEL-NOK":
                    return "No se puede reavivar (undelete) el elemento seleccionado!";

                    // Mensajes asociados a botones de acci�n
                case "ACTION-COMPLETE-NOK":
                    return "No se ha podido completar correctamente la acci�n seleccionada!\r\nVerifique los datos si ha agregado/editado alguno.";
                case "ACTION-VIEW-NOK":
                    return "No se ha podido mostrar el elemento!";
                case "ACTION-ADD-NOK":
                    return "No se ha podido agregar el elemento a la base de datos!";
                case "ACTION-SAVE-NOK":
                    return "No se ha podido guardar el elemento en la base de datos!";
                case "ACTION-EDIT-NOK":
                    return "No se ha podido editar el elemento!";
                case "ACTION-DEL-NOK":
                    return "No se ha podido eliminar el elemento!";
                case "ACTION-FILTER-NOK":
                    return "No se ha podido ejecutar el filtro sobre el listado!";
                case "ACTION-UNDO-NOK":
                    return "No se ha podido deshacer la operaci�n!";
                case "ACTION-CLEAR-NOK":
                    return "No se puede limpiar el panel de datos!";
                case "ACTION-HELP-NOK":
                    return "No se puede mostrar el �tem de Ayuda del Sistema!";
                case "ACTION-ERROR-OBJ-NODEL":
                    return "No se puede eliminar un elemento del tipo seleccionado!";
                case "ACTION-SETADD-NOK":
                    return "No se puede agregar un par�metro a la lista de configurados!";
                case "ACTION-SETDEL-NOK":
                    return "No se puede remover un par�metro de la lista de configurados!";
                case "ACTION-GESTION-NOK":
                    return "No se puede iniciar la gesti�n de la Cuenta!";
                case "ACTION-PRINT-NOK":
                    return "No se puede imprimir el reporte asociado a la Gesti�n!";
                case "ACTION-VIEW-DEUDAPAGO-NOK":
                    return "No se puede ver el detalle de la deuda desde �sta ventana (ingrese desde Cuenta/Convenio)!";
                case "ACTION-VIEW-MUST-SELECT":
                    return "Debe seleccionar un elemento existente para visualizar!";
                case "ACTION-VIEW-SESION-NOK":
                    return "No hay m�s datos para mostrar de la sesi�n seleccionada!";

                    // Mensaje de preguntas
                case "PREGUNTA-SALIR":
                    return "Est� seguro de salir del Sistema?";
                case "PREGUNTA-CERRAR-SESION":
                    return "Est� seguro de cerrar la sesi�n de usuario?";
                case "PREGUNTA-CERRAR-DIRTY":
                    return "Existen cambios sin guardar, desea continuar de todos modos?";
                case "PREGUNTA-NOUNDO-ACTION":
                    return "Este cambio no se puede deshacer, desea continuar de todos modos?";
                case "PREGUNTA-SAVE-FOR-ADD":
                    return "Esta acci�n requiere guardar los datos actuales, desea continuar de todos modos?";
                case "PREGUNTA-BAJAR-OBJETO":
                    return "Est� seguro de eliminar el elemento seleccionado?";

                    // Mensaje de excepciones
                case "AccesoErrorException":
                    return "EXCEPCION DE ACCESO";
                case "AppErrorException":
                    return "EXCEPCION DE APLICACION";
                case "CUErrorException":
                    return "EXCEPCION DE CASO DE USO";
                case "DataErrorException":
                    return "EXCEPCION DE DATOS";
                case "DBErrorException":
                    return "EXCEPCION DE DATABASE";
                case "FatalErrorException":
                    return "EXCEPCION FATAL";
                case "SchedulerListaErrorException":
                    return "EXCEPCION DE SCHEDULER";
                case "VistaErrorException":
                    return "EXCEPCION DE VISTA";
                case "SesionErrorException":
                    return "EXCEPCION DE SESION";

                    // Mensajes del esquema de persistencia
                case "OPERANDO-NOK":
                    return "No se reconoce el operador de comparaci�n de criterio de consulta declarado!";
                case "OPERANDO-LOGICO-NOK":
                    return "No se reconoce el operador l�gico de criterio de consulta declarado!";
                case "OPERANDO-TIPO-NOK":
                    return "No se reconoce el tipo del operando de criterio de consulta declarado!";

                    // Mensajes asociados a los reportes
                case "REPORTE-NOFILTRO":
                    return "Se debe especificar almenos un valor para todos los criterios de filtros";
                case "REPORTE-NORESULT":
                    return "No hay resultado para los criterios de filtros especificados";
                case "REPORTE-SINOMBRE":
                    return "No se especific� el nombre del destinatario";
                case "REPORTE-FALTADATO":
                    return "La cuenta/gesti�n no posee los datos necesarios para la generaci�n del documento";
                case "REPORTE-ERROR":
                    return "Se ha producido un error al generar el Reporte solicitado!";
            }
            
            // Si no ubico el mensaje busca en el helper (si hay)
            string otroMensaje = null;
            if (Helper != null)
                otroMensaje = Helper.textoMensajeConTerminador(mensaje);

            // Cuando no reconoce el mensaje sigue con la cadena con 
            // terminador, sino vuelve con la cadena encontrada
            return otroMensaje ?? "No se reconoce el mensaje a mostrar/registrar (" + mensaje + ")!";             
        }

        /// <summary>
        /// Punto de entrada a la decodificaci�n de mensajes de validaci�n 
        /// de campos est�ndar. Este m�todo sirve para obtener el texto de 
        /// un mensaje en respuesta a una validaci�n de un campo y a partir 
        /// de una cadena identificadora codificada (debe esta aqu�). Aqui 
        /// se incluyen una cadena terminadora (dada por el atrib de clase 
        /// TERMINADOR), para diferenciar el logging del mensaje en pantalla.
        /// </summary>
        /// <param name="mensaje">
        /// La cadena codigo identificador del mensaje a devolver.
        /// </param> 
        /// <returns>
        /// Retorna el texto del mensaje que coincide con dicho c�digo pasado 
        /// como argumento y CON una cadena terminadora o, si no encuentra el 
        /// codigo, un mensaje estandar de error de validaci�n.
        /// </returns>
        public static string TextoValidacion(string mensaje) {
            switch (mensaje) {
                    // Mensajes asociados al proto-framework
                case "PARAMETRO-CLAVE":
                    return "La Clave del Par�metro es obligatoria" + TERMINADOR;
                case "PARAMETRO-NOMBRE":
                    return "El Nombre del Par�metro es obligatorio" + TERMINADOR;
                case "PARAMETRO-CLASE":
                    return "La Clase del Par�metro es obligatoria" + TERMINADOR;
                case "PARAMETRO-TIPO":
                    return "El Tipo del Par�metro es obligatorio" + TERMINADOR;
                case "PERFIL-NOMBRE":
                    return "El Nombre del Perfil es obligatorio" + TERMINADOR;
                case "ROL-NOMBRE":
                    return "El Nombre del Rol es obligatorio" + TERMINADOR;
                case "USUARIO-NOMBRE":
                    return "El Nombre de Usuario es obligatorio" + TERMINADOR;
                case "USUARIO-LEGAJO":
                    return "El Numero de Legajo del Usuario es obligatorio" + TERMINADOR;
                case "USUARIO-PASSWORD":
                    return "El Password del Usuario es obligatorio (y debe tener 4 cars. m�nimo)" + TERMINADOR;
            }

            // Si no ubico el mensaje busca en el helper (si hay)
            string otroMensaje = null;
            if (Helper != null)
                otroMensaje = Helper.textoValidacion(mensaje);

            // Cuando no reconoce el mensaje sigue con la cadena con 
            // terminador, sino vuelve con la cadena encontrada
            return (otroMensaje ?? "El Valor de alg�n campo ingresado no es v�lido") + TERMINADOR;
        }
    }
}