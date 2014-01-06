///////////////////////////////////////////////////////////
//  PanelPreviewPersona.cs
//  Implementación del panel preview para la entidad Persona.
//  de la aplicación
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmPersona {
    public partial class PanelPreviewPersona : PanelPreview<Persona> {
        private double _saldoActualTotal;
        private double _pagosEfectuados;
        private long _maxDiasDeuda;
        private bool _poseeConvenio;
        private string _strFechaUltGestion;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewPersona(IControladorEditable<Persona> controlador) : base(controlador) {
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
                getDatosPersona();
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDNI.Text = _objeto.DNI;
                ctrlTxtCuit.Text = _objeto.Cuit;
                ctrlTxtProfesion.Text = _objeto.Profesion;
                ctrlTxtComentario.Text = _objeto.Comentario;
                ctrlTxtTrabajo.Text = _objeto.Trabajo;
                txtSaldoTotal.Text = string.Format("{0:C}", _saldoActualTotal);
                txtSaldoVdo.Text = string.Format("{0:C}", _pagosEfectuados);
                txtMaxDiasDeudor.Text = string.Format("{0} días", _maxDiasDeuda);
                txtUltGestion.Text = _strFechaUltGestion;
                ctrlFechaUMod.Text = _objeto.FechaUMod.ToString();
                // Booleano
                chkConvenio.Checked = _poseeConvenio;
                ctrlTxtSexo.Text = (_objeto.Sexo != null) ? _objeto.Sexo.Nombre : "";
                ctrlTxtTipoIVA.Text = (_objeto.TipoIVA != null) ? _objeto.TipoIVA.Nombre : "";
                ctrlTxtEstadoCivil.Text = (_objeto.EstadoCivil != null) ? _objeto.EstadoCivil.Nombre : "";
                ctrlTxtEconomia.Text = (_objeto.Economia != null) ? _objeto.Economia.Nombre : "";
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método calcula los datos de la persona, según
        /// todas sus cuentas (en las que figura como titular)
        /// y según las gestiones en las que fué contactado.
        /// </summary>
        public void getDatosPersona() {
            _saldoActualTotal = 0;
            _pagosEfectuados = 0;
            _maxDiasDeuda = 0;
            _strFechaUltGestion = "";
            _poseeConvenio = false;

            foreach (Cuenta cta in _objeto.getCuentasTitular()) {
                _saldoActualTotal += cta.getMontoSaldoTotalActual();
                foreach (Pago p in cta.getPagos())
                    _pagosEfectuados += p.Total;

                if (_maxDiasDeuda < cta.getAntiguedadDeuda())
                    _maxDiasDeuda = cta.getAntiguedadDeuda();

                if (cta.ConvenioActivo != null)
                    _poseeConvenio = true;
            }

            if (_objeto.getGestionesContactado().Count > 0)
                _strFechaUltGestion = (_objeto.getGestionesContactado()[0]).FechaCierre.ToString();
        }
    }
}