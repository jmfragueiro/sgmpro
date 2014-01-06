///////////////////////////////////////////////////////////
//  PanelPreviewPago.cs
//  Implementación del panel de preview para la entidad Pago
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

namespace cuAbmPago {
    public partial class PanelPreviewPago : PanelPreview<Pago> {
        protected Cuenta _cuenta;
        protected Convenio _convenio;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewPago(IControladorEditable<Pago> controlador) : base(controlador) {
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
                _cuenta = _objeto.Cuenta;
                _convenio = _cuenta.ConvenioActivo;
                // Texto
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                txtFormaPago.Text = (_objeto.FormaPago != null) ? _objeto.FormaPago.Nombre : "";
                txtConcepto.Text = (_objeto.Tipo != null) ? _objeto.Tipo.Nombre : "";
                txtEstado.Text = (_objeto.Estado != null) ? _objeto.Estado.Nombre : "";
                // Números
                txtCapital.Text = _objeto.Capital.ToString();
                txtInteres.Text = _objeto.Interes.ToString();
                txtHonor.Text = _objeto.Honorarios.ToString();
                txtGastos.Text = _objeto.Gastos.ToString();
                txtTotal.Text = _objeto.Total.ToString();
                // Fechas
                txtFecha.Text = (_objeto.Fecha <= Fechas.FechaNull)
                                    ? ""
                                    : _objeto.Fecha.ToShortDateString();
                txtFechaUMod.Text = (_objeto.FechaUMod <= Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FechaUMod.ToShortDateString();
                txtFechaBaja.Text = (_objeto.FechaBaja <= Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FechaBaja.ToShortDateString();
                // Clases
                if (_cuenta != null) {
                    txtCuenta.Tag = _cuenta;
                    txtCuenta.Text = txtCuenta.Tag.ToString();
                }
                if (_convenio != null) {
                    txtConvenio.Tag = _convenio;
                    txtConvenio.Text = txtConvenio.Tag.ToString();
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}