﻿///////////////////////////////////////////////////////////
//  PanelGestionPersonas.cs
//  Clase de implementación del panel de personas en la 
//  ventana de gestión de una cuenta morosa.
//  Generated by Fito
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary.enums;
using scioSecureLibrary.enums;
using scioSecureLibrary.excepciones;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuGestionar {
    public partial class PanelGestionPersonas : UserControl {
        protected Cuenta _cuenta;
        protected Persona _titular;
        protected Persona _garante;
        protected Contacto _ctoActualTitular;
        protected Contacto _ctoActualGarante;
        protected bool _inLoad;
        protected WinGestionCuenta _ventanaPadre;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes.
        /// </summary>
        public PanelGestionPersonas() {
            try {
                InitializeComponent();
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
            try {
                _ventanaPadre = (WinGestionCuenta)ventana;
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        /// <param name="cuenta">
        /// El objeto cuyos datos se muestran en el panel.
        /// </param>  
        public void setObjeto(Cuenta cuenta) {
            try {
                _cuenta = cuenta;

                if (_cuenta.Titular != null) {
                    _titular = _cuenta.Titular;
                    txtTitular.Text = _titular.ToString();
                    tabPagTitular.Enabled = true;
                    cargarComboTitular();
                    cargarDatosTitular();
                    btnVerTitular.Enabled = true;
                    btnEditTitular.Enabled = true;
                    btnVerCtoTitular.Enabled = true;
                    btnEditCtoTitular.Enabled = true;
                } else {
                    _titular = null;
                    txtTitular.Clear();
                    tabPagTitular.Enabled = false;
                    btnVerTitular.Enabled = false;
                    btnEditTitular.Enabled = false;
                    btnVerCtoTitular.Enabled = false;
                    btnEditCtoTitular.Enabled = false;
                }

                if (_cuenta.Garante != null) {
                    _garante = _cuenta.Garante;
                    txtGarante.Text = _garante.ToString();
                    tabPagGarante.Enabled = true;
                    cargarComboGarante();
                    cargarDatosGarante();
                    btnVerGarante.Enabled = true;
                    btnEditGarante.Enabled = true;
                    btnVerCtoGte.Enabled = true;
                    btnEditCtoGte.Enabled = true;
                } else {
                    _garante = null;
                    txtGarante.Clear();
                    tabPagGarante.Enabled = false;
                    btnVerGarante.Enabled = false;
                    btnEditGarante.Enabled = false;
                    btnVerCtoGte.Enabled = false;
                    btnEditCtoGte.Enabled = false;
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }
        #endregion

        #region helpers
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void aplicarPermisos(Control contenedor) {
            try {
                foreach (Control ctrl in contenedor.Controls)
                    if (ctrl is ScrollableControl
                        || ctrl is TabControl
                        || ctrl is GroupBox)
                        aplicarPermisos(ctrl);
                    else if (ctrl is Button && ctrl.Tag is string && ctrl.Tag.ToString().StartsWith("BOTON"))
                        if (!Sistema.Controlador.SecurityService
                                 .usuarioActualPoseePermiso((string) ctrl.Tag, ETipoPermiso.EJECUTAR))
                            ctrl.Visible = false;
            } catch (Exception e) {
                throw new SecurityErrorException("PANEL-NOK", e.ToString());
            }
        }
        #endregion helpers

        #region controles
        /// <summary>
        /// Este método carga los datos del contacto actual del titular 
        /// (el seleccionado en el combo de contactos del titular).
        /// </summary>
        private void cargarDatosTitular() {
            try {
                if (_ctoActualTitular != null) {                    
                    fechaUModCtoTitular.Text = _ctoActualTitular.FechaUMod.ToShortDateString();
                    txtDescCtoTitular.Text = _ctoActualTitular.Descripcion;
                    txtCalleCtoTitular.Text = _ctoActualTitular.Calle;
                    txtPuertaCtoTitular.Text = _ctoActualTitular.Puerta;
                    txtPDCtoTitular.Text = _ctoActualTitular.PisoDepto;
                    txtCPCtoTitular.Text = _ctoActualTitular.Cp;
                    txtTel1CtoTitular.Text = _ctoActualTitular.Telefono1;
                    txtTel2CtoTitular.Text = _ctoActualTitular.Telefono2;
                    txtCelCtoTitular.Text = _ctoActualTitular.Celular;
                    txtCtoTitularVP.Text = (_ctoActualTitular.VerificadoPor != null)
                                               ? _ctoActualTitular.VerificadoPor.Nombre
                                               : "";
                    if (_ctoActualTitular.Origen != null)
                        txtOrigenCtoTitular.Text = _ctoActualTitular.Origen.Nombre;
                    if (_ctoActualTitular.Provincia != null)
                        txtProvCtoTitular.Text = _ctoActualTitular.Provincia.Nombre;
                    if (_ctoActualTitular.Localidad != null)
                        txtLocCtoTitular.Text = _ctoActualTitular.Localidad.Nombre;
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método carga los datos del contacto actual del garante 
        /// (el seleccionado en el combo de contactos del garante).
        /// </summary>
        private void cargarDatosGarante() {
            try {
                if (_ctoActualGarante != null) {                    
                    fechaUModCtoGte.Text = _ctoActualGarante.FechaUMod.ToShortDateString();
                    txtDescCtoGte.Text = _ctoActualGarante.Descripcion;
                    txtCalleCtoGte.Text = _ctoActualGarante.Calle;
                    txtPuertaCtoGte.Text = _ctoActualGarante.Puerta;
                    txtPDCtoGte.Text = _ctoActualGarante.PisoDepto;
                    txtCPCtoGte.Text = _ctoActualGarante.Cp;
                    txtTelef1CtoGte.Text = _ctoActualGarante.Telefono1;
                    txtTelef2CtoGte.Text = _ctoActualGarante.Telefono2;
                    txtCelCtoGarante.Text = _ctoActualGarante.Celular;
                    txtCtoGteVP.Text = (_ctoActualGarante.VerificadoPor != null)
                                           ? _ctoActualGarante.VerificadoPor.Nombre
                                           : "";
                    if (_ctoActualGarante.Origen != null)
                        txtOrigenCtoGte.Text = _ctoActualGarante.Origen.Nombre;
                    if (_ctoActualGarante.Provincia != null)
                        txtProvCtoGte.Text = _ctoActualGarante.Provincia.Nombre;
                    if (_ctoActualGarante.Localidad != null)
                        txtLocCtoGte.Text = _ctoActualGarante.Localidad.Nombre;
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método carga el combo de contactos del titular.
        /// </summary>
        private void cargarComboTitular() {
            _inLoad = true;
            cmbTitularCtos.Items.Clear();
            try {
                foreach (Contacto p in _titular.getContactosActivos())
                    cmbTitularCtos.Items.Add(p);

                if (cmbTitularCtos.SelectedItem == null && cmbTitularCtos.Items.Count >= 1) {
                    cmbTitularCtos.SelectedItem = cmbTitularCtos.Items[0];
                    _ctoActualTitular = (Contacto)cmbTitularCtos.SelectedItem;
                }
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
            }
            _inLoad = false;
        }

        /// <summary>
        /// Este método carga el combo de contactos del garante.
        /// </summary>
        private void cargarComboGarante() {
            _inLoad = true;
            cmbGranteCtos.Items.Clear();
            try {
                foreach (Contacto p in _garante.getContactosActivos())
                    cmbGranteCtos.Items.Add(p);

                if (cmbGranteCtos.SelectedItem == null && cmbGranteCtos.Items.Count >= 1) {
                    cmbGranteCtos.SelectedItem = cmbGranteCtos.Items[0];
                    _ctoActualGarante = (Contacto)cmbGranteCtos.SelectedItem;
                }
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
            }
            _inLoad = false;
        }
        #endregion

        #region interfase
        /// <summary>
        /// Este método responde al cambio de Contacto de titular para mostrar
        /// los nuevos datos. Debería 'mostrar' cualquier error que ocurriese 
        /// y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void cmbTitularCtos_SelectedIndexChanged(object sender, EventArgs e) {
            if (!_inLoad) {
                _ctoActualTitular = (Contacto)cmbTitularCtos.SelectedItem;
                cargarDatosTitular();
            }
        }

        /// <summary>
        /// Este método responde al cambio de Contacto de garante para mostrar
        /// los nuevos datos. Debería 'mostrar' cualquier error que ocurriese 
        /// y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void cmbGranteCtos_SelectedIndexChanged(object sender, EventArgs e) {
            if (!_inLoad) {
                _ctoActualGarante = (Contacto)cmbGranteCtos.SelectedItem;
                cargarDatosGarante();
            }
        }

        private void btnVerTitular_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmPersona", this, new object[] {EModoVentana.VIEW, _titular});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnVerGarante_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmPersona", this, new object[] {EModoVentana.VIEW, _garante});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnEditTitular_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmPersona", this, new object[] {EModoVentana.EDIT, _titular});
                cargarComboTitular();
                cargarDatosTitular();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnEditGarante_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmPersona", this, new object[] {EModoVentana.EDIT, _garante});
                cargarComboGarante();
                cargarDatosGarante();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnVerCtoTitular_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmContacto", this, new object[] {EModoVentana.VIEW, _ctoActualTitular});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnVerCtoGte_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmContacto", this, new object[] {EModoVentana.VIEW, _ctoActualGarante});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnEditCtoTitular_Click(object sender, EventArgs e) {
            try {
                // Si hay un contacto para editar y valorbool de su 
                // Origen es falso entonces el tipo no puede modificarse
                if (!_ctoActualTitular.Origen.Valorbool)
                    Sistema.Controlador.mostrar("ERROR-TIPOCONTACTO-NOEDITABLE", ENivelMensaje.ERROR, null, false);
                else {
                    CUCaller.CallCU("cuAbmContacto", this, new object[] {EModoVentana.EDIT, _ctoActualTitular});
                    cargarComboTitular();
                    cargarDatosTitular();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnEditCtoGte_Click(object sender, EventArgs e) {
            try {
                // Si hay un contacto para editar y valorbool de su 
                // Origen es falso entonces el tipo no puede modificarse
                if (!_ctoActualTitular.Origen.Valorbool)
                    Sistema.Controlador.mostrar("ERROR-TIPOCONTACTO-NOEDITABLE", ENivelMensaje.ERROR, null, false);
                else {
                    CUCaller.CallCU("cuAbmContacto", this, new object[] {EModoVentana.EDIT, _ctoActualGarante});
                    cargarComboGarante();
                    cargarDatosGarante();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnNvoCtoTitular_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmContacto", this, new object[] {EModoVentana.ADD, new Contacto {Persona = _titular}});
                cargarComboTitular();
                cargarDatosTitular();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        private void btnNvoCtoGte_Click(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuAbmContacto", this, new object[] {EModoVentana.ADD, new Contacto {Persona = _garante}});
                cargarComboGarante();
                cargarDatosGarante();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }
        #endregion interface
    }
}