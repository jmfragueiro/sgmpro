///////////////////////////////////////////////////////////
//  PanelPreviewPerfil.cs
//  Implementación del panel preview para la entidad Perfil
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

namespace cuConfigurarUsuarios {
    public partial class PanelPreviewPerfil : PanelPreview<Perfil> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewPerfil(IControladorEditable<Perfil> controlador) : base(controlador) {
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
                // Booleanos
                ctrlChkActivo.Checked = _objeto.Activado;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}