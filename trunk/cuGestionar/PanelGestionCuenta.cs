﻿///////////////////////////////////////////////////////////
//  PanelGestionCuenta.cs
//  Clase de implementación del panel de Cuenta en la 
//  ventana de gestión de una cuenta morosa.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary.enums;
using scioSecureLibrary.enums;
using scioSecureLibrary.excepciones;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuGestionar {
    public partial class PanelGestionCuenta : UserControl {
        protected Cuenta _cuenta;
        protected Convenio _convenioActivo;
        protected WinGestionCuenta _ventanaPadre;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes.
        /// </summary>
        public PanelGestionCuenta() {
            try {
                InitializeComponent();
                tabCtaDeudasPagos.BackColor = SystemColors.ControlLight;
                aplicarPermisos(this);
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panel
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        /// <param name="ventana">
        /// El objeto cuyos datos se muestran en el panel.
        /// </param>  
        public void setVentanaPadre(Form ventana) {
            _ventanaPadre = (WinGestionCuenta)ventana;
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary> 
        public void setObjeto(Cuenta cuenta) {
            try {
                _cuenta = cuenta;
                _convenioActivo = _cuenta.ConvenioActivo;

                cargarDatos();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public void cargarDatos() {
            try {
                // Textos
                txtDescripcion.Text = _cuenta.Descripcion;
                txtCodigo.Text = _cuenta.Codigo;
                // Fechas
                fechaElegible.Text = (_cuenta.FechaElegible <= Fechas.FechaNull)
                                         ? ""
                                         : _cuenta.FechaElegible.ToShortDateString();
                txtFechaAsignada.Text = (_cuenta.FechaAlta <= Fechas.FechaNull)
                                            ? ""
                                            : _cuenta.FechaAlta.ToShortDateString();
                txtAntCta.Text = (DateTime.Now.Date - _cuenta.FechaAsignacion).Days.ToString();
                Tramo tr = _cuenta.Producto.getTramoCorrespondiente(_cuenta);
                txtTramo.Text = (tr == null) 
                                    ? "N/D"
                                    : tr.ToString();
                // Booleanos
                ctrlChkActivada.Checked = _cuenta.Activada;
                // Numeros
                cargarResumen(chkInformada.Checked);
                // Clases                
                if (_cuenta.Producto != null) {
                    txtEntidad.Text = _cuenta.Producto.Entidad.ToString();
                    txtProducto.Text = _cuenta.Producto.ToString();
                }
                if (_cuenta.Estado != null)
                    txtEstado.Text = _cuenta.Estado.Nombre;
                txtConvenio.Tag = null;
                txtConvenio.Text = string.Empty;
                if (_convenioActivo != null) {
                    txtConvenio.Tag = _convenioActivo;
                    txtConvenio.Text = txtConvenio.Tag.ToString();
                }

                txtGestor.Text = (_cuenta.Gestor != null) ? _cuenta.Gestor.ToString() : null;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
        #endregion

        #region helpers
        /// <summary>
        /// Este método carga el cuadro de resumen de panel.
        /// </summary>
        /// <param name="soloOrigen">
        /// Especifica si debe tomar solo la deuda origen o 
        /// si debe tomar toda la deuda activa existente.
        /// </param>
        public void cargarResumen(bool soloOrigen) {
            double capital = 0, interes = 0, honorarios = 0, gastos = 0;
            double pcapital = 0, phonorarios = 0, pinteres = 0, pgastos = 0;

            foreach (Deuda dd in _cuenta.getDeudaInformada()) {
                capital += dd.Capital;
                interes += dd.Interes;
                honorarios += dd.Honorarios;
                gastos += dd.Gastos;
            }
            
            if (!soloOrigen)
                foreach (Deuda dd in _cuenta.getDeudaNoInformada()) {
                    capital += dd.Capital;
                    interes += dd.Interes;
                    honorarios += dd.Honorarios;
                    gastos += dd.Gastos;
                }

            foreach (Pago p in _cuenta.getPagos()) {
                pcapital += p.getImputadoCapital();
                pinteres += p.getImputadoInteres();
                pgastos += p.getImputadoGastos();
                phonorarios += p.getImputadoHonorarios();
            }
            // Agrega un texto en el tooltip del botón de impresión de estado de cta.
            var unToolt = new ToolTip();
            unToolt.SetToolTip(btnPrintCta,"Imprime estado de cuenta");

            txtCapital.Text = capital.ToString();
            txtHonorarios.Text = honorarios.ToString();
            txtInteres.Text = interes.ToString();
            txtGastos.Text = gastos.ToString();
            txtTotal.Text = (capital + interes + gastos + honorarios).ToString();

            txtPCapital.Text = pcapital.ToString();
            txtPHonorarios.Text = phonorarios.ToString();
            txtPInteres.Text = pinteres.ToString();
            txtPGastos.Text = pgastos.ToString();
            txtPTotal.Text = (pcapital + pinteres + pgastos + phonorarios).ToString();

            txtAntiguedad.Text = _cuenta.getAntiguedadDeuda().ToString();
            txtAntiguedadP.Text = _cuenta.getAntiguedadPago().ToString();
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void aplicarPermisos(Control contenedor) {
            try {
                foreach (Control ctrl in contenedor.Controls)
                    if (ctrl is ScrollableControl || ctrl is TabControl || ctrl is GroupBox)
                        aplicarPermisos(ctrl);
                    else if (ctrl is Button && ctrl.Tag is string && ctrl.Tag.ToString().StartsWith("BOTON"))
                        if (
                            !Sistema.Controlador.SecurityService.usuarioActualPoseePermiso(
                                 (string)ctrl.Tag,
                                 ETipoPermiso.EJECUTAR))
                            ctrl.Visible = false;
            } catch (Exception e) {
                throw new SecurityErrorException("PANEL-NOK", e.ToString());
            }
        }
        #endregion helpers

        #region interface
        /// <summary>
        /// Este método responde al botón Ver Convenio. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerCuenta_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmCuenta", this, new object[] {EModoVentana.VIEW, _cuenta});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Convenio. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnEditCuenta_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmCuenta", this, new object[] {EModoVentana.EDIT, _cuenta});
                _cuenta.refrescar();
                setObjeto(_cuenta);
                _ventanaPadre.refrescarVentana();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Convenio. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerConvenio_Click(object sender, EventArgs e) {
            try {
                if (txtConvenio.Tag != null)
                    CUCaller.CallCU("cuAbmConvenio", this, new[] {EModoVentana.VIEW, txtConvenio.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Solo Origen. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void chkInformada_CheckedChanged(object sender, EventArgs e) {
            cargarResumen(chkInformada.Checked);
        }

        /// <summary>
        /// Este método responde al botón Ver Tramo. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void button1_Click(object sender, EventArgs e) {
            try {
                Tramo tr = _cuenta.Producto.getTramoCorrespondiente(_cuenta);
                if (tr != null)
                    CUCaller.CallCU("cuAbmTramo", this, new object[] {EModoVentana.VIEW, tr});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }
        #endregion interface

        private void btnPrintCta_Click(object sender, EventArgs e)
        {
            try
            {
                CUCaller.CallCU("cuGenerarInformes.CUEstadoCuentaDeudor", this, new object[] { txtEntidad.Text,txtCodigo.Text,_cuenta.Titular.Nombre,Convert.ToDouble(txtCapital.Text),
                Convert.ToDouble(txtInteres.Text),Convert.ToDouble(txtHonorarios.Text),Convert.ToDouble(txtGastos.Text),Convert.ToDouble(txtTotal.Text)});
            }
            catch (Exception ex)
            {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }
    }
}