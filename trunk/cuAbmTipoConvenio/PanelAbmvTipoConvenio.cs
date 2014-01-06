///////////////////////////////////////////////////////////
//  PanelAbmvEntidad.cs
//  Implementación del panel ABMV para la entidad Entidad
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

namespace cuAbmTipoConvenio {
    public partial class PanelAbmvTipoConvenio : PanelABMV<TipoConvenio> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvTipoConvenio(IControladorEditable<TipoConvenio> unControlador) : base(unControlador) {
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
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                ctrlTxtHonorarios.Text = _objeto.FormulaHonorarios;
                ctrlTxtCuota.Text = _objeto.FormulaCuota;
                ctrlTxtInteres.Text = _objeto.FormulaInteres;
                ctrlTxtGastos.Text = _objeto.FormulaGastos;
                ctrlTxtHonAnt.Text = _objeto.FormulaBaseConvenio;
                // Numeros
                ctrlTxtTasa.Text = _objeto.TasaPura.ToString();
                ctrlTxtMaxCuotas.Text = _objeto.MaxCuotas.ToString();
                ctrlTxtCtaGracia.Text = _objeto.MaxCuotasCaidas.ToString();
                ctrlTxtMinCuotas.Text = _objeto.MinCuotas.ToString();
                ctrlTxtAntMinimo.Text = _objeto.ValorMinimoAnticipo.ToString();
                ctrlTxtCuotaMinima.Text = _objeto.ValorMinimoCuota.ToString();
                ctrlTxtPunitorio.Text = _objeto.Punitorio.ToString();
                ctrlTxtMaxQuita.Text = _objeto.MaxQuita.ToString();
                ctrlTxtReglaHA.Text = _objeto.ReglaHA.ToString();
                ctrlTxtActHon.Text = _objeto.Honorarios.ToString();
                // Booleanos
                ctrlChkActivo.Checked = _objeto.Activo;
                ctrlChkIva.Checked = _objeto.IVAsobreTP;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtNombre.Text == _objeto.Nombre &&
                         ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? string.Empty) &&
                         ctrlTxtMaxCuotas.Text == _objeto.MaxCuotas.ToString() &&
                         ctrlTxtMinCuotas.Text == _objeto.MinCuotas.ToString() &&
                         ctrlTxtMaxQuita.Text == _objeto.MaxQuita.ToString() &&                    
                         ctrlTxtCtaGracia.Text == _objeto.MaxCuotasCaidas.ToString() &&
                         ctrlTxtPunitorio.Text == _objeto.Punitorio.ToString() &&
                         ctrlTxtReglaHA.Text == _objeto.ReglaHA.ToString() &&
                         ctrlTxtAntMinimo.Text == _objeto.ValorMinimoAnticipo.ToString() &&
                         ctrlTxtCuotaMinima.Text == _objeto.ValorMinimoCuota.ToString() &&
                         ctrlTxtTasa.Text == _objeto.TasaPura.ToString() &&
                         ctrlTxtHonorarios.Text == _objeto.FormulaHonorarios &&
                         ctrlTxtCuota.Text == _objeto.FormulaCuota &&
                         ctrlTxtInteres.Text == _objeto.FormulaInteres &&
                         ctrlTxtGastos.Text == _objeto.FormulaGastos &&
                         ctrlTxtHonAnt.Text == _objeto.FormulaBaseConvenio &&
                         ctrlTxtActHon.Text == _objeto.Honorarios.ToString() &&
                         ctrlChkActivo.Checked == _objeto.Activo &&
                         ctrlChkIva.Checked == _objeto.IVAsobreTP);
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.MaxCuotas = string.IsNullOrEmpty(ctrlTxtMaxCuotas.Text) ? 0 : Convert.ToInt32(ctrlTxtMaxCuotas.Text);
                _objeto.MaxCuotasCaidas = string.IsNullOrEmpty(ctrlTxtCtaGracia.Text) ? 0 : Convert.ToInt32(ctrlTxtCtaGracia.Text);
                _objeto.MinCuotas = string.IsNullOrEmpty(ctrlTxtMinCuotas.Text) ? 0 : Convert.ToInt32(ctrlTxtMinCuotas.Text);
                _objeto.TasaPura = string.IsNullOrEmpty(ctrlTxtTasa.Text) ? 0 : Convert.ToDouble(ctrlTxtTasa.Text);
                _objeto.ValorMinimoAnticipo = string.IsNullOrEmpty(ctrlTxtAntMinimo.Text) ? 0 : Convert.ToDouble(ctrlTxtAntMinimo.Text);
                _objeto.ValorMinimoCuota = string.IsNullOrEmpty(ctrlTxtCuotaMinima.Text) ? 0 : Convert.ToDouble(ctrlTxtCuotaMinima.Text);
                _objeto.Punitorio = string.IsNullOrEmpty(ctrlTxtPunitorio.Text) ? 0 : Convert.ToDouble(ctrlTxtPunitorio.Text);
                _objeto.MaxQuita = string.IsNullOrEmpty(ctrlTxtMaxQuita.Text) ? 0 : Convert.ToDouble(ctrlTxtMaxQuita.Text);
                _objeto.ReglaHA = string.IsNullOrEmpty(ctrlTxtReglaHA.Text) ? 0 : Convert.ToDouble(ctrlTxtReglaHA.Text);
                _objeto.FormulaCuota = ctrlTxtCuota.Text;
                _objeto.FormulaHonorarios = ctrlTxtHonorarios.Text;
                _objeto.FormulaInteres = ctrlTxtInteres.Text;
                _objeto.FormulaGastos = ctrlTxtGastos.Text;
                _objeto.FormulaBaseConvenio = ctrlTxtHonAnt.Text;
                _objeto.Honorarios = string.IsNullOrEmpty(ctrlTxtActHon.Text) ? 0 : Convert.ToDouble(ctrlTxtActHon.Text);
                _objeto.Activo = ctrlChkActivo.Checked;
                _objeto.IVAsobreTP = ctrlChkIva.Checked;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion
    }
}