///////////////////////////////////////////////////////////
//  Persistencia.cs
//  Implementation of the Class Persistencia
//  Generated by Enterprise Architect
//  Created on:      13-abr-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using NHibernate;
using NHibernate.Cfg;
using scioPersistentLibrary.excepciones;
using scioPersistentLibrary.interfases;

namespace scioPersistentLibrary {
    /// <summary>
    /// Esta es la clase que implementa realmente el concepto servicio de 
    /// persistencia (aqu� base de datos) con todas sus propiedades y sus
    /// funciones asociadas. Esta clase es la que implementa la interfaz 
    /// IControladorPersistencia y provee de los servicios efectivos de 
    /// infraestructura para poder ejecutar transacciones, para administrar 
    /// la conexi�n interna del sistema al servicio de persistencia y la 
    /// verificaci�n del inicio y la gesti�n de transacciones (commit, 
    /// rollback, etc.).
    /// </summary>
    public class Persistencia : IControladorPersistencia {
        private static IControladorPersistencia _database;
        private static long _scn;
        protected static bool _configurado;
        /// <summary>
        /// Sesion de Nhibernate (unica para cada sesion en la ejecuci�n,
        /// si bien puede, por performance, desconectarse y reconectarse 
        /// entre transacciones mientras espera la interacci�n de usuario).
        /// </summary>
        protected static ITransaction _transacc;
        /// <summary>
        /// Sesion del servicio de persistencia, aqu� Nhibernate, (unica 
        /// para cada sesion en la ejecuci�n, aunque puede, por performance
        /// �p por un error+rollback, salirse y vover a crearse).
        /// </summary>
        protected static ISession _ssp;
        /// <summary>
        /// Factoria de NHibernate para la sesion (�nica para la ejecuci�n 
        /// porque representa un objeto muy costoso de crear y/o destruir).
        /// </summary>
        protected static ISessionFactory _sessionFactory;
        /// <summary>
        /// Listado de librerias incluidas para nhibernate.
        /// </summary>
        protected static List<string> _incluidos;
        /// <summary>
        /// Listado de propiedades seteadas para nhibernate.
        /// </summary>
        protected static IDictionary<string, string> _propiedades;
        /// <summary>
        /// Controlador de la database implementadea via el singleton.
        /// </summary>
        public static IControladorPersistencia Controlador {
            get { return _database ?? (_database = new Persistencia()); }
        }
        /// <summary>
        /// Nombre interno del servicio de persistencia (propiedad de solo 
        /// lectura, que se genera desde el servicio al utilizar el m�todo 
        /// crearSSP()).
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// La cadena de conexi�n al servicio de persistencia (propiedad de 
        /// solo lectura, la que se obtiene desde el servicio al utilizar el 
        /// m�todo crearSSP()).
        /// </summary>
        public string CadenaConexion { get; set; }

        /// <summary>
        /// Este m�todo permite configurar el servicio de persistencia global.
        /// Qu� significa esto depende de la implementaci�n de la innerface y
        /// de el servicio subyacente utilizado para efectivamente gestionar
        /// los datos. En este caso se trata de una configuraci�n del servicio 
        /// del NHibernate por lo que se setean los valores iniciales necesarios 
        /// para arrancar el ISessionFactory. Se deber� establecer el valor 
        /// _configurado (protected) a 'true' una vez que se haya configurado 
        /// el servicio.
        /// </summary>
        public static void ConfigurarPersistencia() {
            try {
                if (_configurado)
                    return;

                Configuration configuration = new Configuration();

                configuration.SetProperties(_propiedades);

                foreach (string s in _incluidos)
                    configuration.AddAssembly(s);

                if (EsquemaORM.Helper != null)
                    EsquemaORM.GenerarEsquema(configuration);

                _sessionFactory = configuration.BuildSessionFactory();

                if (EsquemaORM.Helper != null)
                    EsquemaORM.CargarEsquema();

                _configurado = true;
            } catch (Exception e) {
                throw new PersistErrorException("DB-INIT-ERROR", e.ToString());
            }
        }

        /// <summary>
        /// Propiedad que implementa un patr�n Singleton para asegurar la
        /// unicidad de la fabrica de sesiones (Session Factory), la que 
        /// debe ser �nica porque representa un objeto muy costoso de crear
        /// y, en principio, solo deber�a utilizarse desde una instancia.
        /// </summary>
        private static ISessionFactory SessionFactory {
            get {
                if (_sessionFactory == null)
                    ConfigurarPersistencia();

                return _sessionFactory;
            }
        }

        /// <summary>
        /// Este m�todo permite establecer una propiedad, al momento de crear 
        /// la clase, de manera de que se utilicen al momento de configurar la
        /// f�brica de sesiones de nhibernate. De esta forma se pueden setear
        /// propiedades en proyectos que utilicen a �ste proyecto como referencia.
        /// </summary>
        /// <param name="propiedad">
        /// El nombre del par�metro de NHibernate a setear.
        /// </param>
        /// <param name="valor">
        /// El valor a establecer para el par�metro a setear.
        /// </param>
        public void setearPropiedad(string propiedad, string valor) {
            try {
                if (_propiedades == null)
                    _propiedades = new Dictionary<string, string>();

                _propiedades.Add(propiedad, valor);
            } catch (Exception e) {
                throw new PersistErrorException("DB-SET-ERROR", e.ToString());
            }
        }

        /// <summary>
        /// Este m�todo permite incluir una librer�a, al momento de crear la
        /// clase, de manera de que se tomen todos los hbm.xml de nhibernate
        /// para cargar las definiciones de clases a perisistir. De esta forma
        /// se pueden agregar clases en proyectos que utilicen a �ste proyecto
        /// como referencia (y evitar la referencia circular).
        /// </summary>
        /// <param name="nombreLibreria">
        /// El nombre de la librer�a (assembly) a incluir para nhibernate.
        /// </param>
        public void incluirLibreria(string nombreLibreria) {
            try {
                if (_incluidos == null)
                    _incluidos = new List<string>();

                _incluidos.Add(nombreLibreria);
            } catch (Exception e) {
                throw new PersistErrorException("DB-SET-ERROR", e.ToString());
            }
        }

        /// <summary>
        /// Este m�todo es el encargado de generar una sesion nueva contra el
        /// sistema de persistencia, terminando primero la actual, si hay una,
        /// y devolveviendo la sesi�n creada como un objeto tipo ISession (de 
        /// Nhibernate), para que pueda ser utilizado en la ejecuci�n de las
        /// operaciones de persistencia. Este m�todo relanza toda excepci�n 
        /// como una DBErrorException.
        /// </summary>
        /// <returns>
        /// Objeto que representa la sesion del sistema de persistencia creado.
        /// </returns>
        public ISession crearSsp() {
            try {
                cerrarSsp();
                _ssp = SessionFactory.OpenSession();
                return _ssp;
            } catch (Exception e) {
                terminarSsp();
                throw new PersistErrorException("DB-ERROR-NOCONN", e.ToString());
            }
        }

        /// <summary>
        /// Este m�todo es el encargado de devolver la sesion de persistencia
        /// actualmente abierta. Este m�todo relanza toda excepci�n como una 
        /// FatalErrorException (primero la registra al mecanismo de logging).
        /// </summary>
        /// <returns>
        /// Un objeto que representa la sesion en curso (si existe).
        /// </returns>
        public ISession getSsp() {
            try {
                return _ssp ?? (_ssp = crearSsp());
            } catch (Exception e) {
                terminarSsp();
                throw new PersistErrorException("DB-ERROR", e.ToString());
            }
        }

        /// <summary>
        /// Este m�todo es el encargado de desconectar la sesi�n del servicio
        /// de persistencia (podr�a hacerse, por ejemplo, para as� mejorar la 
        /// performance del sistema). Se hacen firmes (commit) todas aquellas
        /// actualizaciones no persistidas. No se podr�n ejecutar transacciones 
        /// hasta un nuevo inicio de sesi�n contra el mecanismo de persistencia.
        /// Si no hay una sesi�n activa entonces no hace nada. Relanza cualquier
        /// excepcion como una FatalErrorException (primero la registra mediante 
        /// el mecanismo de logging).
        /// </summary>
        public void cerrarSsp() {
            try {
                if (_ssp != null) {
                    _ssp.Flush();
                    _ssp.Close();
                }
            } catch (Exception e) {
                throw new PersistErrorException("DB-CLOSE-ERROR", e.ToString());
            } finally {
                _ssp = null;
            }
        }

        /// <summary>
        /// Este m�todo es el encargado de terminar una sesi�n del servicio
        /// de persistencia (esto se debe hacer ante un error de NHibernate 
        /// que genere un rollback, ya que NHibernate rollbackea solo la base 
        /// -pero no su cach� de objetos en memoria- por lo que este quedar�a 
        /// en un estado inconsistente). Se rollbackean las actualizaciones a
        /// la base, y se pierden las de la memoria, no persistidas. Ya no se 
        /// podr�n ejecutar transacciones hasta un nuevo inicio de sesi�n del
        /// servicio de persistencia. Si no hay una sesi�n activa entonces no 
        /// hace nada. Relanza cualquier excepci�n como un FatalErrorException 
        /// (primero la registra mediante el mecanismo de logging).
        /// </summary>
        public void terminarSsp() {
            try {
                if (_ssp != null) {
                    _ssp.Clear();
                    _ssp.Close();
                }
            } catch (Exception e) {
                throw new PersistErrorException("DB-FIN-ERROR", e.ToString());
            } finally {
                _ssp = null;
            }
        }

        /// <summary>
        /// Este m�todo es el encargado de iniciar una transacci�n contra el
        /// servicio de persistencia. Como las transacciones dependen siempre
        /// de una sesi�n ya activa, si no hay una sesi�n activa entonces se
        /// crea una. Adem�s, si ya hay una transacci�n en curso, el pedido no
        /// crea una nueva sino que obtiene la misma y pasa a ser parte de esta.
        /// Relanza cualquier excepci�n como un PersistErrorException.
        /// </summary>
        /// <returns>
        /// Un entero largo, el SCN (system change numebr), que representa la 
        /// transacci�n en curso si es que no habia ninguna � cero si ya hay 
        /// una transacci�n en curso (y esta pasa a ser parte de la misma).
        /// </returns>
        public long iniciarTransaccion() {
            try {
                if (_transacc == null) {
                    _transacc = getSsp().BeginTransaction();
                    return (_scn = new Random(DateTime.Now.Millisecond).Next());
                }

                return 0;
            } catch (Exception e) {
                _transacc = null;
                _scn = 0;
                terminarSsp();
                throw new PersistErrorException("DB-INITRAN-ERROR", e.ToString());
            }
        }

        /// <summary>
        /// Este m�todo determina si existe una transacci�n en curso actualmente, 
        /// y devuelve un valor booleano declarando dicha situaci�n. 
        /// </summary>
        /// <returns>
        /// Retorna 'true' si existe una transacci�n en curso �, si no, 'false'. 
        /// </returns>
        public bool hayTransaccion() {
            return (_transacc != null);
        }

        /// <summary>
        /// Este m�todo es el encargado de comitear la transacci�n actual en
        /// el servicio de persistencia, y luego cierra dicha transacci�n. No 
        /// se capturan excepciones (si hay) y si no hay transacci�n se hace
        /// un flush de la sesi�n (descarga todos los cambios). Si no existe
        /// una sesi�n entonces no hace nada. No captura excepciones (aunque
        /// s� las registra mediante el mecanismo de logging).
        /// </summary>
        public void commitTransaccion(long scn) {
            try {
                if (_transacc != null && scn == _scn) {
                    _transacc.Commit();
                    _transacc = null;
                    _scn = 0;
                }
            } catch (Exception e) {
                rollbackTransaccion();
                throw new PersistErrorException("DB-COMMIT-ERROR", e.ToString());
            }
        }

        /// <summary>
        /// Este m�todo realiza un refresh de un objeto contra la base de datos
        /// para asegurarse de que lo que esta viendo es realmente lo ultimisimo.
        /// </summary>
        /// <param name="objeto">
        /// El objeto IEntidadIdentificable cuyos datos quieren actualizarse.
        /// </param>
        public void refrescarDatos(IEntidadIdentificable objeto) {
            // ReSharper disable EmptyGeneralCatchClause
            try { getSsp().Refresh(objeto); } catch (Exception) {}
            // ReSharper restore EmptyGeneralCatchClause
        }

        /// <summary>
        /// Este m�todo es el encargado de rollbackear la transacci�n actual
        /// en el servicio de persistencia, y luego cierra dicha transacci�n. 
        /// Adem�s se cierra si o si la sesi�n actual y se pierde el log de 
        /// todos los cambios hechos en memoria. Esto es necesario porque el
        /// NHibernate rollbackea solo la base y por lo tanto quedan los objs
        /// en estado inconsistente en memoria contra lo que hay en la base.
        /// Se relanza cualqueir excepci�n que se produsca en el medio (y se
        /// registra mediante el mecanismo de logging).
        /// </summary>
        public void rollbackTransaccion() {
            try {
                if (_transacc != null)
                    _transacc.Rollback();
            } catch (Exception e) {
                throw new PersistErrorException("DB-ROLLBACK-ERROR", e.ToString());
            } finally {
                _transacc = null;
                _scn = 0;
                terminarSsp();
            }
        }

        /// <summary>
        /// Este m�todo ejecuta una consulta contra el servicio de persistencia 
        /// y devuelve un array de objects con los valores obtenidos del primer 
        /// resultado (por ejemplo: la primer fila) �nicamente. No se capturan 
        /// las excepciones (aunque s� las registra con el mecanismo de logging).
        /// </summary>
        /// <param name="sql">
        /// La consulta a ejecutarse contra el servicio de persistencia.
        /// </param>
        /// <param name="cadenaConexion">
        /// La cadena de conexi�n a la base de datos (pq es un m�todo est�tico).
        /// </param> 
        /// <returns>
        /// Un arreglo de objetos con los valores del primer resultado.
        /// </returns>
        public static object[] EjecutarSqlOneRow(string sql, string cadenaConexion) {
            try {
                using (SqlConnection connection = new SqlConnection(cadenaConexion)) {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader != null && reader.HasRows) {
                        object[] retorno = new object[reader.FieldCount];
                        reader.Read();
                        reader.GetValues(retorno);
                        reader.Close();
                        return retorno;
                    }
                    return null;
                }
            } catch (Exception e) {
                throw new PersistErrorException("DB-ERROR", String.Format("==>SQL: {0}\r\n==>ERROR: {1}", sql, e));
            }
        }

        /// <summary>
        /// Este m�todo ejecuta un comando DML contra el servicio de persistencia 
        /// y devuelve un entero que dice cuantas filas afecto dicho comando. No 
        /// se capturan las excepciones (aunque s� las registra con el mecanismo 
        /// de logging).
        /// </summary>
        /// <param name="sql">
        /// Un string con el comando a ejecutarse contra el servicio de persistencia.
        /// </param>
        /// <param name="cadenaConexion">
        /// La cadena de conexi�n a la base de datos (pq es un m�todo est�tico).
        /// </param> 
        /// <returns>
        /// Un entero que dice cuantos registros fueron afectados.
        /// </returns>
        public static long EjecutarSqlDML(string sql, string cadenaConexion) {
            try {
                using (SqlConnection connection = new SqlConnection(cadenaConexion)) {
                    connection.Open();
                    return (new SqlCommand(sql, connection)).ExecuteNonQuery();
                }
            } catch (Exception e) {
                throw new PersistErrorException("DB-ERROR", String.Format("==>SQL: {0}\r\n==>ERROR: {1}", sql, e));
            }
        }

        /// <summary>
        /// Este m�todo ejecuta varios comandos DML contra el servicio de persistencia 
        /// y devuelve un entero que dice cuantas filas se afectaron en conjunto. No se
        /// capturan las excepciones (aunque s� las registra con el mecanismo de logging).
        /// IMPORTANTE: todos los comandos dml se ejcutan dentro de la misma transaccion,
        /// es decir que se comitean todos juntos o nada (se rollbackea).
        /// </summary>
        /// <param name="sql">
        /// UNa coleccion de strings con los comandos a ejecutarse contra el servicio de persistencia.
        /// </param>
        /// <param name="cadenaConexion">
        /// La cadena de conexi�n a la base de datos (pq es un m�todo est�tico).
        /// </param> 
        /// <returns>
        /// Un entero que dice cuantos registros fueron afectados.
        /// </returns>
        public static long EjecutarSqlDML(IList<string> sql, string cadenaConexion) {
            string sq = string.Empty;
            using (SqlConnection connection = new SqlConnection(cadenaConexion)) {
                SqlTransaction sqlt = null;
                try {
                    long resultado = 0;
                    connection.Open();
                    sqlt = connection.BeginTransaction();
                    foreach (string s in sql) {
                        sq = s;
                        SqlCommand command = new SqlCommand(s, connection, sqlt);
                        resultado += command.ExecuteNonQuery();
                    }
                    sqlt.Commit();
                    connection.Close();
                    return resultado;
                } catch (Exception e) {
                    if (sqlt != null) sqlt.Rollback();
                    connection.Close();
                    throw new PersistErrorException("DB-ERROR", String.Format("==>SQL: {0}\r\n==>ERROR: {1}", sq, e));
                }
            }
        }

        /// <summary>
        /// Este m�todo ejecuta una consulta contra el servicio de persistencia 
        /// y devuelve un DataTable con el resultado. No se capturan excepciones 
        /// (aunque s� las registra con el mecanismo de logging).
        /// </summary>
        /// <param name="sql">
        /// La consulta a ejecutarse contra el servicio de persistencia.
        /// </param>
        /// <param name="cadenaConexion">
        /// La cadena de conexi�n a la base de datos (pq es un m�todo est�tico).
        /// </param> 
        /// <returns>
        /// Un DataTable con los registros del resultado (o vacio si no hay nada).
        /// </returns>
        public static DataTable EjecutarSqlSelect(string sql, string cadenaConexion) {
            try {
                using (SqlConnection connection = new SqlConnection(cadenaConexion)) {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);

                    SqlDataReader resultado = command.ExecuteReader(CommandBehavior.CloseConnection);
                    DataTable res = new DataTable();
                    if (resultado != null)
                        res.Load(resultado);

                    return res;
                }
            } catch (Exception e) {
                throw new PersistErrorException("DB-ERROR", String.Format("==>SQL: {0}\r\n==>ERROR: {1}", sql, e));
            }
        }
    }
}