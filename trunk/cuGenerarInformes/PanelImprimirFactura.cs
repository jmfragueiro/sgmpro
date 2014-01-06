using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using scioBaseLibrary;
using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace cuGenerarInformes
{
    public partial class PanelImprimirFactura : UserControl
    {
        private const double _IVA21 = 21;
        /// <summary>
        /// Factura en edicion, el contenedor tendra una factura cargada por vez.
        /// </summary>
        private Factura _miFactura;
        /// <summary>
        /// Linea en edicion. La linea que se encuentra siendo editada, estara
        /// cargada en este atributo, luego de la edicion se carga nuevamente 
        /// en la factura, o se elimina.
        /// </summary>
        private Linea _miLinea;

        public PanelImprimirFactura()
        {
            InitializeComponent();
            cargaControles();
        }

        private void cargaControles()
        {
            // Carga los datos iniciales
            string strCnx = Sistema.Controlador.CadenaConexion;
            
            // Carga el combo de entidades
            string strSql = "select e.ent_nombre Nombre, e.ent_cuit Cuit, e.ent_direccion Direccion, e.ent_cp CP from Entidad e";
            var entidades = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            cmbHEntidad.DataSource = entidades;
            cmbHEntidad.DisplayMember = "Nombre";

            // Carga el combo de tipo
            cmbHTipo.Items.Add("A");
            cmbHTipo.SelectedIndex = 0;

            // Carga la fecha
            rbEntidad.Checked = true;

            // Valores por default
            chkHResponsable.Checked = true;
            chkHContado.Checked = true;
        }

        internal class Factura
        {
            public String Numero { get; set; }
            public DateTime Fecha { get; set; }
            public String Senhores { get; set; }
            public String Domicilio { get; set; }
            public bool Responsable { get; set; }
            public String Cuit { get; set; }
            public bool Contado { get; set; }
            public IList<Linea> MisLineas { get; set; }

            public double getSubTotal()
            {
                return MisLineas.Sum(linea => linea.getTotal());
            }

            public double getTotal()
            {
                return getSubTotal() + _IVA21;
            }
            /// <summary>
            /// Implementa el save de cualquier objeto utilizando
            /// consultas sql.
            /// </summary>
            public void Save()
            {
                
            }
        }


        internal class Linea
        {
            public int Nro { get; set; }
            public double Cantidad { get; set; }
            public String Detalle { get; set; }
            public double Precio { get; set; }

            public double getTotal()
            {
                return Cantidad*Precio;
            }
        }

        /// <summary>
        /// Crea una  nueva linea, para su edicion y posterior carga a
        /// la factura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUnitario.Enabled = true;
            txtCantidad.Enabled = true;
            txtDescri.Enabled = true;

            txtUnitario.Clear();
            txtDescri.Clear();
            txtCantidad.Clear();
            _miLinea = new Linea();
        }
        /// <summary>
        /// Guarda los cambios de la linea en edicion
        /// y actualiza en la factura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text) || String.IsNullOrEmpty(txtUnitario.Text)) return;

            _miLinea.Cantidad = Convert.ToDouble(txtCantidad.Text);
            _miLinea.Detalle = txtDescri.Text;
            _miLinea.Precio = Convert.ToDouble(txtUnitario.Text);

            if (! _miFactura.MisLineas.Contains(_miLinea)) _miFactura.MisLineas.Add(_miLinea);
            dgvListado.Update();

            txtUnitario.Enabled = false;
            txtCantidad.Enabled = false;
            txtDescri.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_miFactura.MisLineas.Contains(_miLinea))
                _miFactura.MisLineas.Remove(_miLinea);
            dgvListado.Update();
        }

        private void toolBtnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void ctrlCmbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var unItem = (DataRowView) cmbHEntidad.SelectedItem;
            txtHCuit.Text = unItem[1].ToString();
            txtHDomicilio.Text = unItem[2].ToString();
        }

        private void rbEntidad_CheckedChanged(object sender, EventArgs e)
        {
            txtHCliente.Enabled = !rbEntidad.Checked;
            cmbHEntidad.Enabled = rbEntidad.Checked;
            txtHDomicilio.Clear();
            txtHCuit.Clear();
        }

        private void cmbHFecha_ValueChanged(object sender, EventArgs e)
        {
            txtHFecha.Text = cmbHFecha.Text;
        }

        
    }
}
