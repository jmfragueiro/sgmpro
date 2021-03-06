﻿using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using scioBaseLibrary;
using scioPersistentLibrary;
using scioReportLibrary;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuGenerarInformes {
    /// <summary>
    /// Panel que contiene los filtros correspondientes al 
    /// Reporte de Cobranzas ingresadas.
    /// Implementa la Interfaz IPanelFiltros.
    /// </summary>
    public partial class PanelFiltroListaCuentas : UserControl, IPanelFiltros {
        /// <summary>
        /// Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;

        /// <summary>
        /// Constructor
        /// </summary>
        public PanelFiltroListaCuentas() {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles() {
            // Carga los datos iniciales
            var strCnx = Sistema.Controlador.CadenaConexion;
            string strSql;

            // Carga el check list de usuarios
            if (chkListaEntidades.Items.Count <= 0) {
                strSql = "select distinct(ent_nombre+' ('+ent_cuit+')') from entidad order by 1";
                var usuarios = Persistencia.EjecutarSqlSelect(strSql, strCnx);
                for (int i = 0; i < usuarios.Rows.Count; i++)
                    chkListaEntidades.Items.Add(usuarios.Rows[i][0]);
            }

            // Carga el check list de Estados
            if (chkEstadosGestion.Items.Count > 0) return;
            strSql = "select distinct(par_nombre) from parametro where par_clave like 'ESTADOCUENTA%' order by par_nombre";
            var estados = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (var i = 0; i < estados.Rows.Count; i++)
                chkEstadosGestion.Items.Add(estados.Rows[i][0]);

            // Setea todas las opciones por default
            chkTodasEntidades.Checked = true;
            chkTodosEstado.Checked = true;
        }

        /// <summary>
        /// Arma los filtros que se aplicarán para regenerar
        /// el reporte. Depende de cada implementación del 
        /// IPanelFiltros.
        /// </summary>
        private string armaFiltro() {
            var sb = new StringBuilder();

            // Filtros de fecha
            // Si no selecciona ningún filtro, genera una excepción.
            if (chkListaEntidades.CheckedItems.Count != 0 &&
                chkEstadosGestion.CheckedItems.Count != 0)
            {
                // Filtros de entidades
                sb.Append("(");
                foreach (object item in chkListaEntidades.CheckedItems)
                    sb.Append(string.Format("Entidad = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                // Filtros de estados de cuenta
                sb.Append(" and (");
                foreach (object item in chkEstadosGestion.CheckedItems)
                    sb.Append(string.Format("Estado = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                return sb.ToString();
            }

            throw new Exception(Mensaje.TextoMensaje("REPORTE-NOFILTRO"));
        }

        /// <summary>
        /// Setea el control para el manejo del panel
        /// de filtros.
        /// </summary>
        public void setControl(ICUReportes unControl) {
            // Carga el control
            _control = unControl;
            // Carga los componentes
            cargaControles();
        }

        /// <summary>
        /// Evento del boton Filtrar
        /// </summary>
        private void btnFiltrar_Click(object sender, EventArgs e) {
            Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("REPORTE-AYUDA"));
            Cursor = Cursors.WaitCursor;

            try {
                _control.filtrarDatos(armaFiltro(), rbDetalle.Checked);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("REPORTE-ERROR", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                Cursor = Cursors.Default;
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));                
            }
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Entidades
        /// </summary>
        private void chkTodosEntidades_CheckedChanged(object sender, EventArgs e) {
            // Recorre toda la lista seteando el mismo estado que el
            // check "Todos"
            for (int i = 0; i < chkListaEntidades.Items.Count; i++)
                chkListaEntidades.SetItemCheckState(i, chkTodasEntidades.CheckState);
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Tipos de Pago
        /// </summary>
        private void chkTodosTipoPago_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < chkEstadosGestion.Items.Count; i++)
                chkEstadosGestion.SetItemCheckState(i, chkTodosEstado.CheckState);
        }
    }
}