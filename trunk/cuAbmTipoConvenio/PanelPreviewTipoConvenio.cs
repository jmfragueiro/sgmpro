///////////////////////////////////////////////////////////
//  PanelPreviewTipoConvenio.cs
//  Implementación del panel preview para la entidad TipoConvenio
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
    public partial class PanelPreviewTipoConvenio : PanelPreview<TipoConvenio> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewTipoConvenio(IControladorEditable<TipoConvenio> controlador) : base(controlador) {
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
                txtNombre.Text = _objeto.Nombre;
                txtDescripcion.Text = _objeto.Descripcion;
                txtHonorarios.Text = _objeto.FormulaHonorarios;
                txtCuota.Text = _objeto.FormulaCuota;
                txtInteres.Text = _objeto.FormulaInteres;
                txtGastos.Text = _objeto.FormulaGastos;
                txtHonAnt.Text = _objeto.FormulaBaseConvenio;
                // Numeros
                txtTasa.Text = _objeto.TasaPura.ToString();
                txtMaxCuotas.Text = _objeto.MaxCuotas.ToString();
                txtCtaGracia.Text = _objeto.MaxCuotasCaidas.ToString();
                txtMinCuotas.Text = _objeto.MinCuotas.ToString();
                txtAntMinimo.Text = _objeto.ValorMinimoAnticipo.ToString();
                txtCuotaMinima.Text = _objeto.ValorMinimoCuota.ToString();
                txtPunitorio.Text = _objeto.Punitorio.ToString();
                txtMaxQuita.Text = _objeto.MaxQuita.ToString();
                txtReglaHA.Text = _objeto.ReglaHA.ToString();
                txtActHon.Text = _objeto.Honorarios.ToString();
                // Booleanos
                chkActivo.Checked = _objeto.Activo;
                chkIva.Checked = _objeto.IVAsobreTP;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}