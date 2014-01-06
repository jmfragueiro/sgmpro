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
using scioSecureLibrary.dominio;
using scioToolLibrary;
using sgmpro.dominio.configuracion.repos;

namespace cuConfigurarUsuarios {
    public partial class PanelPreviewUsuario : PanelPreview<Usuario> {
        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewUsuario(IControladorEditable<Usuario> unControlador) : base(unControlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtLegajo.Text = _objeto.Legajo.ToString();
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtEmpleado.Text = _objeto.Empleado;
                ctrlTxtPassword.Text = _objeto.Password;
                txtFechaUMod.Text = (_objeto.FechaUMod == Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FechaUMod.ToString();
                lblCuentas.Text = string.Format(
                    "El Usuario posee {0} cuentas asignadas.", Cuentas.CountByGestor(_objeto));
                // Booleanos
                ctrlChkActivo.Checked = _objeto.Activado;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}