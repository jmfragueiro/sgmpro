///////////////////////////////////////////////////////////
//  PanelPreviewConvenio.cs
//  Implementación del panel de preview para la entidad Convenio
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmConvenio {
    public partial class PanelPreviewConvenio : PanelPreview<Convenio> {
        protected Cuenta _cuenta;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewConvenio(IControladorEditable<Convenio> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException(Mensaje.TextoMensaje("PANEL-NOK"), e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                _cuenta = _objeto.Cuenta;
                txtCuenta.Text = _cuenta.ToString();
                txtDescripcion.Text = _objeto.Descripcion;
                txtOrigen.Text = _objeto.DeudaBase.ToString();
                txtAnticipo.Text = _objeto.Anticipo.ToString();
                txtQuita.Text = _objeto.Quita.ToString();
                txtCuotas.Text = _objeto.CtdadCuotas.ToString();
                txtMontoFinal.Text = _objeto.MontoFinal.ToString();
                txtFechaAlta.Text = _objeto.FechaAlta.ToString();
                txtFechaInicio.Text = _objeto.FechaInicio.ToString();
                chkActivo.Checked = _objeto.Activo;
                txtTipo.Text = _objeto.Tipo.ToString();

                double mf = _objeto.MontoFinal - _objeto.getMontoSaldoTotalActual();
                txtMontoPago.Text = (mf < 0) ? "0" : mf.ToString();

                txtCuotasPagas.Text = _objeto.getCuotasCanceladas().Count.ToString();
                txtSaldo.Text = _objeto.getMontoSaldoTotalActual().ToString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}