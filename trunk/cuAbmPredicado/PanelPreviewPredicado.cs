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
using sgmpro.dominio.configuracion;

namespace cuAbmPredicado {
    public partial class PanelPreviewPredicado : PanelPreview<Predicado> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewPredicado(IControladorEditable<Predicado> controlador) : base(controlador) {
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
                ctrlTxtNroOrden.Text = _objeto.NroOrden.ToString();
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                // Combos
                cmbSelector.SelectedItem = _objeto.Selector;
                cmbVocablo.SelectedItem = _objeto.VocabloPredicado;
                cmbCriterio.SelectedItem = _objeto.Criterio;
                cmbConector.SelectedItem = _objeto.Conector;

                if (_objeto.Valor == null) {
                    cmbVariable.SelectedItem = _objeto.Variable;
                    ctrlRdbVariable.Checked = true;
                } else {
                    ctrlTxtValor.Text = _objeto.Valor;
                    ctrlRdbValor.Checked = true;
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}