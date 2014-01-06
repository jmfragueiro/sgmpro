///////////////////////////////////////////////////////////
//  PanelPreviewJob.cs
//  Implementación del panel preview para la entidad Job
//  de la aplicación
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Drawing;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioPersistentLibrary;
using scioToolLibrary;
using sgmpro.dominio.scheduler;

namespace cuGenerarJobs {
    public partial class PanelPreviewJob : PanelPreview<Job> {
        /// <summary>
        /// Constructor de la Direction que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewJob(IControladorEditable<Job> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Strings
                txtNombre.Text = _objeto.Nombre;
                txtDescripcion.Text = _objeto.Descripcion;
                txtFrecuencia.Text = _objeto.Crontab;
                // Fechas
                txtInicio.Text = (_objeto.Inicio <= Fechas.FechaNull)
                                     ? string.Empty
                                     : _objeto.Inicio.ToString();
                txtUltima.Text = (_objeto.Ultima <= Fechas.FechaNull)
                                     ? string.Empty
                                     : _objeto.Ultima.ToString();
                txtSiguiente.Text = (_objeto.Siguiente <= Fechas.FechaNull)
                                        ? string.Empty
                                        : _objeto.Siguiente.ToString();
                // Booleanos
                chkActivo.Checked = _objeto.Activo;
                // Clases
                txtUsuario.Text = (_objeto.Usuario == null) 
                                    ? string.Empty 
                                    : _objeto.Usuario.ToString();
                // Verifica si el job esta corriendo
                string sql = "select isnull(job_ejecutando, 0) as job ";
                sql += " from job where job_id = '" + _objeto.Id + "'";
                object[] res = Persistencia.EjecutarSqlOneRow(sql, Persistencia.Controlador.CadenaConexion);
                if (res != null && res.Length > 0 && ((int) res[0] == 1)) {
                    lblCorriendo.Visible = true;
                    lblCorriendo.ForeColor = Color.Red;
                } else {
                    lblCorriendo.Visible = false;
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}