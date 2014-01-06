///////////////////////////////////////////////////////////
//  PanelPreviewEntidad.cs
//  Implementación del panel preview para la entidad Entidad
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
using sgmpro.dominio.configuracion.repos;

namespace cuAbmEntidad {
    public partial class PanelPreviewEntidad : PanelPreview<Entidad> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewEntidad(IControladorEditable<Entidad> unControlador) : base(unControlador) {
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
                ctrlTxtCodigo.Text = _objeto.Codigo;
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtCuit.Text = _objeto.Cuit;
                ctrlTxtDireccion.Text = _objeto.Direccion;
                ctrlTxtCodigoPostal.Text = _objeto.Cp;
                ctrlTxtTelefono.Text = _objeto.Telefono;
                ctrlTxtFax.Text = _objeto.Fax;
                ctrlTxtContacto.Text = _objeto.Contacto;
                ctrlTxtEmail.Text = _objeto.Email;
                ctrlChkActiva.Checked = _objeto.Activada;
                txtCtdadCuentas.Text = Cuentas.CountByEntidad(_objeto).ToString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}