using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scioToolLibrary;

namespace cuAbmParametro
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        #region interfase
        private void ctrlValorFecha_ValueChanged(object sender, EventArgs e)
        {
            string fecha = (ctrlValorFecha.Value <= Fechas.FechaNull)
                               ? DateTime.Now.ToString()
                               : ctrlValorFecha.Value.ToString();

            if (!txtValorFecha.Text.Equals(fecha))
                txtValorFecha.Text = fecha;
        }
        #endregion interfase
    }
}
