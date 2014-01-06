///////////////////////////////////////////////////////////
//  PanelPreviewFactura.cs
//  Implementación del panel preview para la entidad Factura
//  de la aplicación.
//  Generated Manualmente
//  Created on:      01-sep-2009 12:00:00
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.caja;
using scioToolLibrary;

namespace cuAbmFactura {
    public partial class PanelPreviewFactura : PanelPreview<Factura>
    {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewFactura(IControladorEditable<Factura> controlador) : base(controlador) {
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
                // Booleano
                ctrlChkContado.Checked = _objeto.Contado;
                // Texto
                txtNumero.Text = _objeto.Numero;
                txtIVA.Text = _objeto.IVA.ToString();
                // Fechas
                txtFecha.Text = _objeto.Fecha.ToString();
                txtCliente.Text = _objeto.Cliente.ToString();
                txtTipo.Text = _objeto.Tipo.ToString();
                // totales
                double cantidad = 0, subtotal = 0, total = 0;
                foreach (ItemFactura item in _objeto.Items)
                    if (item.isAlive()) {
                        cantidad++;
                        subtotal += item.Precio;
                        total += item.Precio + (item.Precio*(_objeto.IVA/100));
                    }
                txtSubtotal.Text = subtotal.ToString();
                txtTotal.Text = total.ToString();
                txtItems.Text = cantidad.ToString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Evento del boton imprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReimprimirRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var miCu = (CUAbmFactura) _controlador;
                if (!miCu.imprimeFacturaA((Factura) _objeto,null))
                {
                    MessageBox.Show(Mensaje.TextoMensaje("REPORTE-FALTADATO"), "Error", 
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    Cursor = Cursors.Default;
                    return;
                }
                Cursor = Cursors.Default;
            } catch (Exception ex) {
                this.Cursor = System.Windows.Forms.Cursors.Default;
                throw new CuErrorException("REPORTE-ERROR", ex.ToString());
            }
        }
    }
}