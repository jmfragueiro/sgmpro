///////////////////////////////////////////////////////////
//  PanelAbmvProducto.cs
//  Implementación del panel ABMV para la entidad Relacion
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;
using scioSecureLibrary.dominio;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.scheduler;

namespace cuGenerarJobs {
    public partial class PanelAbmvJob : PanelABMV<Job> {
        private string _crontab;
        protected WinSelect<Usuario> _wsu;
        private readonly CUListSetTipoLista _listTipos;
        private readonly CUListEjecuciones _listExes;
        private IVistaPanelList _panelTipos, _panelExes;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvJob(IControladorEditable<Job> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listTipos = new CUListSetTipoLista {
                    Disponibles = RepositorioGenerico<TipoListaGestion>.GetAliveAll(),
                    Padre = this
                };

                _listExes = new CUListEjecuciones {
                    Padre = this
                };
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                _listTipos.ObjetoMaster = _listExes.ObjetoMaster = _objeto;

                _listTipos.Configurados = _objeto.Listas;
                _listExes.Filtros.Clear();

                cargarDatos();
                cargarTabs();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                setearEstado();
                // Booleanos
                ctrlChkActivo.Checked = _objeto.Activo;
                // Clases
                if (_objeto.Usuario != null) {
                    txtGestor.Tag = _objeto.Usuario;
                    txtGestor.Text = _objeto.Usuario.ToString();
                }
                // Fechas
                txtUltima.Text = (_objeto.Ultima > Fechas.FechaNull)
                                     ? _objeto.Ultima.ToString()
                                     : string.Empty;
                txtSiguiente.Text = (_objeto.Siguiente > Fechas.FechaNull)
                                        ? _objeto.Siguiente.ToString()
                                        : string.Empty;
                // Frecuencia
                setearFrecuencia();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarTabs() {
            try {
                if (_enProceso) {
                    _panelTipos = _listTipos.getPanelListado(_controlador.ModoVista);
                    _panelTipos.Contenedor = this;
                    tabTipos.Controls.Clear();
                    tabTipos.Controls.Add((Control)_panelTipos);
                    tabTipos.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelExes = _listExes.getPanelListado(_controlador.ModoVista);
                    _panelExes.Contenedor = this;
                    tabExes.Controls.Clear();
                    tabExes.Controls.Add((Control)_panelExes);
                    tabExes.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else {
                    _panelTipos.refrescarListado(_listTipos.ColsInvisibles);
                    _panelExes.refrescarListado((_listExes.ColsInvisibles));
                }

                tabTipos.Text = string.Format("Tipos de Lista de Gestión");
                tabTipos.Refresh();

                tabExes.Text = string.Format("Ejecuciones ({0})", _listExes.Cuenta);
                tabExes.Refresh();
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                setearCrontab();

                return !(ctrlTxtDescripcion.Text.Equals(_objeto.Descripcion ?? string.Empty)
                     && ctrlTxtNombre.Text.Equals(_objeto.Nombre)
                     && ctrlChkActivo.Checked == _objeto.Activo
                     && _crontab.Equals(_objeto.Crontab)
                     && txtGestor.Tag == _objeto.Usuario);
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Crontab = _crontab;
                _objeto.Usuario = (Usuario)txtGestor.Tag;
                _objeto.Inicio = ctrlCmbInicio.Value;
                _objeto.Activo = ctrlChkActivo.Checked;
                _objeto.Siguiente = TriggerUtiles.GetSiguienteEjecucion(_objeto.Crontab, _objeto.Inicio);                
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region interfase
        /// <summary>
        ///   Este método responde al botón Buscar Gestor. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindGestor_Click(object sender, EventArgs e) {
            try {
                if (_wsu == null)
                    _wsu = new WinSelect<Usuario>("cuConfigurarUsuarios.CUListUsuarios");

                _wsu.ShowDialog();

                if (_wsu.Seleccion != null) {
                    txtGestor.Tag = _wsu.Seleccion;
                    txtGestor.Text = txtGestor.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }

        /// <summary>
        ///   Este método responde al botón Borrar Gestor. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlDelGestor_Click(object sender, EventArgs e) {
            try {
                txtGestor.Tag = null;
                txtGestor.Text = null;
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }

        /// <summary>
        ///   Este método responde cambio del check Activo. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlChkActivo_CheckedChanged(object sender, EventArgs e) {
            setearEstado();
        }

        /// <summary>
        ///   Este método responde cambio de la hora de inicio. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtHoraEjec_TextChanged(object sender, EventArgs e) {
            int hora = Convert.ToInt32(ctrlTxtHoraEjec.Text);
            if (hora < 0 || hora > 23) {
                Sistema.Controlador.mostrar("ERROR-FORMAT-ELEMENTO", ENivelMensaje.ERROR, null, true);
                ctrlTxtHoraEjec.Text = "0";
            }
        }

        /// <summary>
        ///   Este método responde cambio del minuto de inicio. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtMinEjec_TextChanged(object sender, EventArgs e) {
            int min = Convert.ToInt32(ctrlTxtMinEjec.Text);
            if (min < 0 || min > 59) {
                Sistema.Controlador.mostrar("ERROR-FORMAT-ELEMENTO", ENivelMensaje.ERROR, null, true);
                ctrlTxtMinEjec.Text = "0";
            }
        }

        /// <summary>
        ///   Este método responde cambio de estado del check de ejecucion diaria.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlRdbDiaria_CheckedChanged(object sender, EventArgs e) {
            pnlDiaria.Visible = ctrlRdbDiaria.Checked;
        }

        /// <summary>
        ///   Este método responde cambio de estado del check de ejecucion semanal.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlRdbSemanal_CheckedChanged(object sender, EventArgs e) {
            pnlSemanal.Visible = ctrlRdbSemanal.Checked;
        }

        /// <summary>
        ///   Este método responde cambio de estado del check de ejecucion mensual.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlRdbMensual_CheckedChanged(object sender, EventArgs e) {
            pnlMensual.Visible = ctrlRdbMensual.Checked;
        }

        private void ctrlRdbPrimerDiaMes_CheckedChanged(object sender, EventArgs e) {
            if (ctrlRdbPrimerDiaMes.Checked) {
                ctrlTxtDiaDelMes.Text = string.Empty;
                ctrlTxtDiaDelMes.Enabled = false;
            }
        }

        private void ctrlRdbUltimoDiaMes_CheckedChanged(object sender, EventArgs e) {
            if (ctrlRdbUltimoDiaMes.Checked) {
                ctrlTxtDiaDelMes.Text = string.Empty;
                ctrlTxtDiaDelMes.Enabled = false;
            }
        }

        private void ctrlRdbPeriodoMensual_CheckedChanged(object sender, EventArgs e) {
            if (ctrlRdbPeriodoMensual.Checked) {
                ctrlTxtDiaDelMes.Text = string.Empty;
                ctrlTxtDiaDelMes.Enabled = true;
            }
        }
        #endregion

        #region helpers
        /// <summary>
        ///   Este método establece el texto de estado del job.
        /// </summary>
        private void setearEstado() {
            txtEstado.Text = (_objeto.Ejecutando)
                                 ? "EJECUTANDO"
                                 : (_objeto.Activo)
                                       ? "EN ESPERA"
                                       : "INACTIVO";
        }

        /// <summary>
        ///   Tratamiento de la programacion
        /// </summary>
        private void setearFrecuencia() {
            // setea valores iniciales
            pnlDiaria.Visible = false;
            pnlSemanal.Visible = false;
            pnlMensual.Visible = false;
            ctrlRdbDiaria.Checked = true;

            // carga los datos de la programacion
            cargaCrontab();

            // Establece las caracteristicas de los controles
            if (_controlador.ModoVista == EModoVentana.VIEW) {
                ctrlCmbInicio.Enabled = false;
                ctrlTxtHoraEjec.ReadOnly = true;
                ctrlTxtMinEjec.ReadOnly = true;
                ctrlRdbPrimerDiaMes.Enabled = false;
                ctrlRdbUltimoDiaMes.Enabled = false;
                ctrlRdbPeriodoMensual.Enabled = false;
                ctrlRdbDiaria.Enabled = false;
                ctrlRdbSemanal.Enabled = false;
                ctrlRdbMensual.Enabled = false;
                ctrlChkLunes.Enabled = false;
                ctrlChkMartes.Enabled = false;
                ctrlChkMiercoles.Enabled = false;
                ctrlChkJueves.Enabled = false;
                ctrlChkViernes.Enabled = false;
                ctrlChkSabado.Enabled = false;
                ctrlChkDomingo.Enabled = false;
                ctrlChkActivo.Enabled = false;
                ctrlTxtDiaDelMes.Enabled = false;
            } else {
                ctrlCmbInicio.Enabled = true;
                ctrlTxtHoraEjec.ReadOnly = false;
                ctrlTxtMinEjec.ReadOnly = false;
                ctrlRdbPrimerDiaMes.Enabled = true;
                ctrlRdbUltimoDiaMes.Enabled = true;
                ctrlRdbPeriodoMensual.Enabled = true;
                ctrlRdbDiaria.Enabled = true;
                ctrlRdbSemanal.Enabled = true;
                ctrlRdbMensual.Enabled = true;
                ctrlChkLunes.Enabled = true;
                ctrlChkMartes.Enabled = true;
                ctrlChkMiercoles.Enabled = true;
                ctrlChkJueves.Enabled = true;
                ctrlChkViernes.Enabled = true;
                ctrlChkSabado.Enabled = true;
                ctrlChkDomingo.Enabled = true;
                ctrlChkActivo.Enabled = true;
                ctrlTxtDiaDelMes.Enabled = true;                
            }
        }

        /// <summary>
        ///   Carga los datos correspondientes a la programacion
        /// </summary>
        private void cargaCrontab() {
            // Fecha de inicio de ejecucion
            ctrlCmbInicio.Value = (_objeto.Inicio != Fechas.FechaNull)
                                      ? _objeto.Inicio
                                      : DateTime.Now;

            // Si no tiene ninguna expresión de tiempo, termina
            if (!string.IsNullOrEmpty(_objeto.Crontab)) {
                // Arma la expresion de programacion (CronExpression)
                // <segundo> <minuto> <hora> <dia_del_mes> <mes> <dia_de_semana>
                string cronExpres = _objeto.Crontab;
                string[] cron = cronExpres.Split(' ');
                string minuto = cron[1];
                string hora = cron[2];
                string diaMes = cron[3];
                string diaSemana = cron[5];

                // Determinacion de los campos a completar
                ctrlTxtHoraEjec.Text = hora;
                ctrlTxtMinEjec.Text = minuto;

                // Determina que tipo de programacion es (mensual, semanal, diaria)
                // A/ Si contiene 'C' es mensual y es el primer dia del mes
                // B/ Si contiene L es mensual y es el ultimo dia del mes
                // C/ Si el dia del mes es != '?' es mensual y toma el dia del mes
                // D/ Si dia de la semana es = '?' es diaria y todos los dias
                // E/ Es semanal y para alguno de los siguientes dias de la semana
                if (diaMes.Contains("C")) {
                    ctrlRdbPrimerDiaMes.Checked = true;
                    ctrlRdbMensual.Checked = true;
                } else if (diaMes.Contains("L")) {
                    ctrlRdbUltimoDiaMes.Checked = true;
                    ctrlRdbMensual.Checked = true;
                } else if (diaMes != "?") {
                    ctrlRdbPeriodoMensual.Checked = true;
                    ctrlRdbMensual.Checked = true;
                    ctrlTxtDiaDelMes.Text = diaMes;
                } else if (diaSemana == "?")
                    ctrlRdbDiaria.Checked = true;
                else {
                    if (diaSemana.Contains("MON"))
                        ctrlChkLunes.Checked = true;
                    if (diaSemana.Contains("TUE"))
                        ctrlChkMartes.Checked = true;
                    if (diaSemana.Contains("WED"))
                        ctrlChkMiercoles.Checked = true;
                    if (diaSemana.Contains("THU"))
                        ctrlChkJueves.Checked = true;
                    if (diaSemana.Contains("FRI"))
                        ctrlChkViernes.Checked = true;
                    if (diaSemana.Contains("SAT"))
                        ctrlChkSabado.Checked = true;
                    if (diaSemana.Contains("SUN"))
                        ctrlChkDomingo.Checked = true;
                    ctrlRdbSemanal.Checked = true;
                }
            }
        }

        /// <summary>
        /// Setea los adtos correspondientes a la programacion
        /// </summary>
        private void setearCrontab() {
            // Arma el plan generando el string de la expresion de tiempo
            _crontab = string.Empty;

            // Tratamiento programación diaria
            if (ctrlRdbDiaria.Checked)
                _crontab = TriggerUtiles.ToCronExpresDiaria(ctrlTxtHoraEjec.Text, ctrlTxtMinEjec.Text);
                // Programacion semanal
            else if (ctrlRdbSemanal.Checked)
                _crontab = TriggerUtiles.ToCronExpresSemanal(
                    ctrlTxtHoraEjec.Text,
                    ctrlTxtMinEjec.Text,
                    ctrlChkLunes.Checked,
                    ctrlChkMartes.Checked,
                    ctrlChkMiercoles.Checked,
                    ctrlChkJueves.Checked,
                    ctrlChkViernes.Checked,
                    ctrlChkSabado.Checked,
                    ctrlChkDomingo.Checked);
                // Programacion mensual
            else if (ctrlRdbMensual.Checked)
                _crontab = TriggerUtiles.ToCronExpresMensual(
                    ctrlTxtHoraEjec.Text,
                    ctrlTxtMinEjec.Text,
                    ctrlTxtDiaDelMes.Text,
                    ctrlRdbPrimerDiaMes.Checked,
                    ctrlRdbUltimoDiaMes.Checked);

            // Primero verifica que sea correcto
            if (!Validador.ValidarDiasCrontab(_crontab))
                throw new DataErrorException("CAMPO-NOK", Mensaje.TextoValidacion("JOB-CRONTAB"));           
        }
        #endregion
    }
}