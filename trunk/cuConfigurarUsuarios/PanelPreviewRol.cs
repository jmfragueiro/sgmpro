///////////////////////////////////////////////////////////
//  PanelPreviewRol.cs
//  Implementación del panel preview para la entidad Rol
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
using scioSecureLibrary.dominio.repos;

namespace cuConfigurarUsuarios {
    public partial class PanelPreviewRol : PanelPreview<Rol> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewRol(IControladorEditable<Rol> controlador) : base(controlador) {
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
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                txtRoles.Text = _objeto.Roles.Count.ToString();
                txtPermisos.Text = _objeto.Permisos.Count.ToString();
                txtUsuarios.Text = Usuarios.GetAliveByRol(_objeto).Count.ToString();
                // Booleanos
                ctrlChkActivo.Checked = _objeto.Activado;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}