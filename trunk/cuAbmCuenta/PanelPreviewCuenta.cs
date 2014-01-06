///////////////////////////////////////////////////////////
//  PanelPreviewCuenta.cs
//  Implementación del panel preview para la entidad Cuenta
//  de la aplicación
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmCuenta {
    public partial class PanelPreviewCuenta : PanelPreview<Cuenta> {
        protected IList<Deuda> _deudaActiva;
        protected Convenio _convenioActivo;
        private readonly Parametro _cdOriginal = Parametros.GetByClave("CONCEPTODEUDA.ORIGEN");
        private readonly Parametro _cdGasto = Parametros.GetByClave("CONCEPTODEUDA.GASTO");
        private readonly Parametro _cdHonorario = Parametros.GetByClave("CONCEPTODEUDA.HONORARIO");

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewCuenta(IControladorEditable<Cuenta> controlador) : base(controlador) {
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
                _deudaActiva = _objeto.getDeudaInformada();
                _convenioActivo = _objeto.ConvenioActivo;

                // Texto
                ctrlTxtCodigo.Text = _objeto.Codigo;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                txtVigencia.Text = _objeto.Vigencia.ToString();
                // Fechas
                fechaElegible.Text = (_objeto.FechaElegible <= Fechas.FechaNull)
                    ? ""
                    : _objeto.FechaElegible.ToString();
                txtFechaUMod.Text = (_objeto.FechaAlta <= Fechas.FechaNull)
                    ? ""
                    : _objeto.FechaAlta.ToString();
                // Booleanos
                ctrlChkActivada.Checked = _objeto.Activada;
                // Numero
                double capital = 0;
                double honorarios = 0;
                double interes = 0;
                double gastos = 0;
                double punit = 0;
                double total = 0;
                if (_deudaActiva != null)
                    foreach (Deuda dd in _deudaActiva) {
                        if (dd.Concepto.Equals(_cdOriginal)) {
                            capital += dd.Capital;
                            interes += dd.Interes;
                            honorarios += dd.Honorarios;
                            gastos += dd.Gastos;
                        } else if (dd.Concepto.Equals(_cdHonorario)) {
                            honorarios += dd.Honorarios;
                        } else if (dd.Concepto.Equals(_cdGasto)) {
                            gastos += dd.Gastos;
                        }
                        total += dd.Total;
                        punit += dd.calcularPunitorios();
                    }
                txtCapital.Text = capital.ToString();
                txtHonorarios.Text = honorarios.ToString();
                txtInteres.Text = interes.ToString();
                txtGastos.Text = gastos.ToString();
                txtPunitorios.Text = punit.ToString();
                txtTotal.Text = total.ToString();
                // Clases
                if (_objeto.Titular != null) {
                    ctrlTxtTitular.Tag = _objeto.Titular;
                    ctrlTxtTitular.Text = ctrlTxtTitular.Tag.ToString();
                }
                if (_objeto.Garante != null) {
                    ctrlTxtGarante.Tag = _objeto.Garante;
                    ctrlTxtGarante.Text = ctrlTxtGarante.Tag.ToString();
                }
                if (_convenioActivo != null) {
                    txtConvenio.Tag = _convenioActivo;
                    txtConvenio.Text = txtConvenio.Tag.ToString();
                }
                if (_objeto.ListaAsignada != null) {
                    txtLista.Tag = _objeto.ListaAsignada;
                    txtLista.Text = txtLista.Tag.ToString();
                }
                if (_objeto.Gestor != null)
                    txtGestor.Text = _objeto.Gestor.ToString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}