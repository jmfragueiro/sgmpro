using System;
using System.Data;

namespace scioInterfazLibrary {
    /// <summary>
    /// Clase que encapsula los métodos necesarios para importar
    /// información de una fuente de datos externa. Como por ej. 
    /// una tabla Excel.
    /// </summary>
    public class Importador {
        /// <summary>
        /// Devuelve un DataTable desde una tabla Dbf
        /// </summary>
        /// <param name="dbfPath">Path absoluto del archivo</param>
        /// <param name="nombreTabla">Nombre de la tabla a importar</param>
        /// <returns>DataTable</returns>
        public DataTable getTablaFromDbf(String dbfPath, String nombreTabla) {
            string cnxStr = String.Format(
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {0};" +
                "Extended Properties=dBASE IV;User ID=Admin;Password=;",
                dbfPath);
            string sqlStr = String.Format("Select * from {0}", nombreTabla);
            CnxBaseDatos.ConectarOledb(cnxStr);
            DataTable dt = CnxBaseDatos.CargaTablaOleDb(sqlStr);
            CnxBaseDatos.CerrarOleDb();
            return dt;
        }

        /// <summary>
        /// Devuelve un DataTable desde una tabla de Access
        /// </summary>
        /// <param name="dbfPath">Path absoluto del archivo</param>
        /// <param name="nombreTabla">Nombre de la tabla a importar</param>
        /// <returns>DataTable</returns>
        public DataTable getTablaFromAccess(String dbfPath, String nombreTabla) {
            string cnxStr = String.Format(
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};",
                dbfPath);
            string sqlStr = String.Format("Select * from {0}", nombreTabla);
            CnxBaseDatos.ConectarOledb(cnxStr);
            return CnxBaseDatos.CargaTablaOleDb(sqlStr);
        }

        /// <summary>
        /// Devuelve un DataTable desde una tabla de Access 2007
        /// </summary>
        /// <param name="dbfPath">Path absoluto del archivo</param>
        /// <param name="nombreTabla">Nombre de la tabla a importar</param>
        /// <returns>DataTable</returns>
        public DataTable getTablaFromAccess07(String dbfPath, String nombreTabla) {
            string cnxStr = String.Format(
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=False;",
                dbfPath);
            string sqlStr = String.Format("Select * from {0}", nombreTabla);
            CnxBaseDatos.ConectarOledb(cnxStr);
            DataTable dt = CnxBaseDatos.CargaTablaOleDb(sqlStr);
            CnxBaseDatos.CerrarOleDb();
            return dt;
        }

        /// <summary>
        /// Devuelve un DataTable desde una planilla Excel.
        /// Solamente importa desde la primera hoja.
        /// </summary>
        /// <param name="xlsPath">Path absoluto del archivo</param>
        /// <param name="nombreHoja">Nombre de la primera hoja del libro</param>
        /// <returns>DataTable</returns>
        public DataTable getTablaFromXls(String xlsPath, String nombreHoja) {
            string cnxStr = String.Format(
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= {0};" +
                "Extended Properties=Excel 8.0;",
                xlsPath);
            string sqlStr = String.Format("SELECT * FROM [{0}$]", nombreHoja);
            CnxBaseDatos.ConectarOledb(cnxStr);
            DataTable dt = CnxBaseDatos.CargaTablaOleDb(sqlStr);
            CnxBaseDatos.CerrarOleDb();
            return dt;
        }
    }
}