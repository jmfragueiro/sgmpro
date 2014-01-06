///////////////////////////////////////////////////////////
//  PanelAbmvPredicado.cs
//  Implementación del panel ABMV para la entidad Predicado
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmPredicado {
    public partial class PanelGUIPredicado : UserControl
    {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelGUIPredicado()
        {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        private void ctrlRdbValor_CheckedChanged(object sender, EventArgs e)
        {
            if (!ctrlRdbValor.Checked)
                return;
            ctrlTxtValor.Visible = true;
            cmbVariable.Visible = false;
            if (!ctrlTxtValor.ReadOnly)
                ctrlTxtValor.Clear();
        }

        private void ctrlRdbVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (!ctrlRdbVariable.Checked)
                return;
            cmbVariable.Visible = true;
            ctrlTxtValor.Visible = false;
            if (!cmbVariable.ReadOnly)
                cmbVariable.SelectedIndex = 0;
        }
        
    }
}