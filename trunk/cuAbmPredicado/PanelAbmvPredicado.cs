///////////////////////////////////////////////////////////
//  PanelAbmvPredicado.cs
//  Implementación del panel ABMV para la entidad Predicado
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;
using sgmpro.dominio.configuracion;
using sgmpro.enums;
using toolsGestion;

namespace cuAbmPredicado {
    public partial class PanelAbmvPredicado : PanelABMV<Predicado> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvPredicado(IControladorEditable<Predicado> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                cargarControles();
                cargarDatos();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto               
                ctrlTxtNroOrden.Text = _objeto.NroOrden.ToString();
                ctrlTxtDescripcion.Text = _objeto.Descripcion;

                // Combos
                cmbSelector.SelectedItem = (_objeto.VocabloPredicado == null) || _objeto.Selector;
                cmbVocablo.SelectedItem = _objeto.VocabloPredicado;
                cmbCriterio.SelectedItem = _objeto.Criterio;
                cmbConector.SelectedItem = (_objeto.VocabloPredicado == null) ? ETipoConector.NULL : _objeto.Conector;

                if (_objeto.Valor == null && cmbVariable.Items.Count > 0) {
                    cmbVariable.SelectedItem = _objeto.Variable;
                    ctrlRdbVariable.Checked = true;
                } else {
                    ctrlTxtValor.Text = (_objeto.Valor ?? "");
                    ctrlRdbValor.Checked = true;
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            ctrlRdbValor.Checked = true;
            cargaComboVariable();
            cargaComboCriterio();
            cargaComboVocablo();
            cargaComboSelector();
            cargaComboConector();
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.NroOrden = Convert.ToInt32(ctrlTxtNroOrden.Text);
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Selector = (Boolean)cmbSelector.SelectedItem;
                _objeto.VocabloPredicado = cmbVocablo.Text;
                _objeto.Criterio = cmbCriterio.Text;
                if (ctrlRdbValor.Checked) {
                    _objeto.Valor = ctrlTxtValor.Text;
                    _objeto.Variable = null;
                } else {
                    _objeto.Variable = (Variable)cmbVariable.SelectedItem;
                    _objeto.Valor = null;
                }
                _objeto.Conector = cmbConector.Text;
                _objeto.FechaAlta = DateTime.Now;
                _objeto.FechaUMod = DateTime.Now;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                if (ctrlTxtNroOrden.Text == _objeto.NroOrden.ToString() &&
                    ctrlTxtDescripcion.Text == _objeto.Descripcion && cmbConector.SelectedItem.Equals(_objeto.Conector) &&
                    cmbVocablo.SelectedItem.Equals(_objeto.VocabloPredicado) &&
                    cmbCriterio.SelectedItem.Equals(_objeto.Criterio) &&
                    (ctrlTxtValor.Text == _objeto.Valor ||
                     (cmbVariable.SelectedItem != null && cmbVariable.SelectedItem.Equals(_objeto.Variable))) &&
                    cmbSelector.SelectedItem.Equals(_objeto.Selector))
                    return false;
                return true;
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }
        #endregion

        #region controles
        private void cargaComboVariable() {
            cmbVariable.DataSource = RepositorioGenerico<Variable>.GetAliveAll();
        }

        private void cargaComboCriterio() {
            cmbCriterio.DataSource = ECriterioComparacion.GetTodos();
            cmbCriterio.Text = ECriterioComparacion.IGUAL;
        }

        private void cargaComboVocablo() {
            cmbVocablo.DataSource = VocabloFactory.GetTodos();
            cmbVocablo.Text = VocabloFactory.GetTodos().GetEnumerator().Current;
        }

        private void cargaComboSelector() {
            cmbSelector.DataSource = (new object[] {true, false});
            cmbSelector.SelectedIndex = 0;
        }

        private void cargaComboConector() {
            cmbConector.DataSource = ETipoConector.GetTodos();
        }
        #endregion controles

        #region interfase
        private void ctrlRdbValor_CheckedChanged(object sender, EventArgs e) {
            if (!ctrlRdbValor.Checked)
                return;
            ctrlTxtValor.Visible = true;
            cmbVariable.Visible = false;
        }

        private void ctrlRdbVariable_CheckedChanged(object sender, EventArgs e) {
            if (!ctrlRdbVariable.Checked)
                return;
            cmbVariable.Visible = true;
            ctrlTxtValor.Visible = false;
        }

        private void cmbVocablo_SelectedIndexChanged(object sender, EventArgs e) {
            txtDescVocablo.Text = (cmbVocablo.SelectedItem != null)
                                    ? VocabloLibrary.GetDescripcion((string)cmbVocablo.SelectedItem)
                                    : "Seleccione un Vocablo para ver su descripción...";
        }
        #endregion
    }
}