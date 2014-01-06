///////////////////////////////////////////////////////////
//  PanelPreviewGestion.cs
//  Implementación del panel de preview para la entidad Gestion
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.gestion;

namespace cuAbmGestion {
    public partial class PanelPreviewGestion : PanelPreview<Gestion> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewGestion(IControladorEditable<Gestion> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                Sistema.Controlador.logear("PANEL-NOK", ENivelMensaje.ERROR, e.ToString());
                throw new VistaErrorException("PANEL-NOK");
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                txtFechaInicio.Text = (_objeto.FechaInicio <= Fechas.FechaNull) ? "" : _objeto.FechaInicio.ToString();
                txtFechaCierre.Text = (_objeto.FechaCierre <= Fechas.FechaNull) ? "" : _objeto.FechaCierre.ToString();
                txtFechaRes.Text = (_objeto.ResultadoFecha <= Fechas.FechaNull) ? "" : _objeto.ResultadoFecha.ToString();
                txtDescripcion.Text = _objeto.ResultadoDesc;
                ctrlTxtTipo.Text = (_objeto.Tipo != null) ? _objeto.Tipo.Nombre : "";
                if (_objeto.Estado != null)
                    txtEstado.Text = _objeto.Estado.Nombre;
                if (_objeto.Contactado != null) {
                    ctrlTxtPersona.Text = _objeto.Contactado.ToString();
                }
                if (_objeto.Contacto != null) {
                    ctrlTxtContacto.Text = _objeto.Contacto.ToString();
                }
                if (_objeto.Usuario != null) {
                    txtUsuario.Text = _objeto.Usuario.ToString();
                }
                if (_objeto.Lista != null) {
                    txtLista.Text = _objeto.Lista.ToString();
                }
                if (_objeto.Cuenta != null) {
                    txtCuenta.Text = _objeto.Cuenta.ToString();
                }
                if (_objeto.Resultado != null) {
                    txtResultado.Text = _objeto.Resultado.ToString();
                }
            } catch (Exception e) {
                Sistema.Controlador.logear("DATA-LOADNOK", ENivelMensaje.ERROR, e.ToString());
                throw new DataErrorException("DATA-LOADNOK");
            }
        }
    }
}