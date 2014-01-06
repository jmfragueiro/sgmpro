///////////////////////////////////////////////////////////
//  PanelAbmvDeuda.cs
//  Implementación del panel ABMV para la entidad Deuda
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

namespace cuAbmDeuda {
    public partial class PanelPreviewDeuda : PanelPreview<Deuda> {
        protected Cuenta _cuenta;
        protected Convenio _convenio;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewDeuda(IControladorEditable<Deuda> controlador) : base(controlador) {
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
                // Texto
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                // Números
                txtCapital.Text = _objeto.Capital.ToString();
                txtInteres.Text = _objeto.Interes.ToString();
                txtGastos.Text = _objeto.Gastos.ToString();
                txtHonorarios.Text = _objeto.Honorarios.ToString();
                txtTotal.Text = _objeto.Total.ToString();
                // Booleano
                chkInformada.Checked = _objeto.Informada;
                // Fechas
                txtFecha.Text = (_objeto.FechaVencimiento <= Fechas.FechaNull)
                    ? ""
                    : _objeto.FechaVencimiento.ToString();
                txtFechaAlta.Text = (_objeto.FechaAlta <= Fechas.FechaNull)
                    ? ""
                    : _objeto.FechaAlta.ToString();
                txtFechaBaja.Text = (_objeto.FechaBaja <= Fechas.FechaNull)
                    ? ""
                    : _objeto.FechaBaja.ToString();
                // Clases
                if (_objeto.Cuenta != null)
                    ctrlTxtCuenta.Text = _objeto.Cuenta.ToString();
                if (_objeto.Estado != null)
                    txtEstado.Text = _objeto.Estado.ToString();
                if (_objeto.Concepto != null)
                    txtConcepto.Text = _objeto.Concepto.ToString();
                if (_objeto.Detalle != null)
                    txtDetalle.Text = _objeto.Detalle.ToString();
                if (_objeto.Convenio != null) {
                    txtConvenio.Text = _objeto.Convenio.ToString();
                    txtCuota.Text = _objeto.Cuota.ToString();
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}