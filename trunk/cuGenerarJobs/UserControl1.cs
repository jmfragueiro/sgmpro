using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cuGenerarJobs
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

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
        private void ctrlFindGestor_Click(object sender, EventArgs e)
        {
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
        private void ctrlDelGestor_Click(object sender, EventArgs e)
        {

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
        private void ctrlChkActivo_CheckedChanged(object sender, EventArgs e)
        {

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
        private void ctrlTxtHoraEjec_TextChanged(object sender, EventArgs e)
        {

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
        private void ctrlTxtMinEjec_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void ctrlRdbPrimerDiaMes_CheckedChanged(object sender, EventArgs e)
        {
            if (ctrlRdbPrimerDiaMes.Checked)
            {
                ctrlTxtDiaDelMes.Text = string.Empty;
                ctrlTxtDiaDelMes.Enabled = false;
            }
        }

        private void ctrlRdbUltimoDiaMes_CheckedChanged(object sender, EventArgs e)
        {
            if (ctrlRdbUltimoDiaMes.Checked)
            {
                ctrlTxtDiaDelMes.Text = string.Empty;
                ctrlTxtDiaDelMes.Enabled = false;
            }
        }

        private void ctrlRdbPeriodoMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (ctrlRdbPeriodoMensual.Checked)
            {
                ctrlTxtDiaDelMes.Text = string.Empty;
                ctrlTxtDiaDelMes.Enabled = true;
            }
        }
    }
}
