using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.enums;
using Application = System.Windows.Forms.Application;

namespace cuGenerarInformes {
    public partial class PanelSeleccionTemplate : UserControl {
        /// <summary>
        ///   Controlador
        /// </summary>
        private readonly CUGenerarCarta _control;

        public PanelSeleccionTemplate(CUGenerarCarta unCtrl) {
            InitializeComponent();
            _control = unCtrl;
            cargaComboTemplates();
        }

        /// <summary>
        ///   Almacena el nombre de la carta seleccionada.
        ///   Es pública para poder ser recuperada desde afuera.
        /// </summary>
        public String NombreCarta { get; set; }

        /// <summary>
        ///   Carga el combobox con los templates disponibles.
        ///   Por cada template existente se carga un parámetro
        ///   con base 'CARTA'.
        /// </summary>
        private void cargaComboTemplates() {
            IList<Parametro> templates = Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "CARTA");
            txtCmbNombre.DataSource = templates;
        }

        /// <summary>
        /// Asigna los datos de la carta seleccionada a la cuenta.
        /// </summary>
        private void txtCmbNombre_SelectedIndexChanged(object sender, EventArgs e) {
            // Muestra el nombre del template que va a utilizar
            txtDescTemplate.Text = ((Parametro) txtCmbNombre.SelectedItem).Valorstring;
            // Asigna la descripción a un campo que luego sera leido desde afuera
            // para asignarle a la descripcion de la gestion. Se coloca el nombre
            // entre {} para poder identificarla en consultas posteriores.
            NombreCarta = "{" + ((Parametro) txtCmbNombre.SelectedItem).Nombre + "}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e) {
            if (ParentForm != null) ParentForm.DialogResult = DialogResult.OK;

            object oMissing = Missing.Value;
            String nombreTemplate = String.Format("{0}\\Templates\\{1}", Application.StartupPath, txtDescTemplate.Text);

            // Abre el Word
            _Application oWordApp = new Microsoft.Office.Interop.Word.Application();
            object oTemplate = nombreTemplate;
            _Document oWordDoc = oWordApp.Documents.Add(
                ref oTemplate,
                ref oMissing,
                ref oMissing,
                ref oMissing);

            oWordApp.Visible = true;

            if (oWordDoc.Bookmarks.Exists("NombreDeudor")) {
                // Setea el valor del Bookmark          
                object oBookMark = "NombreDeudor";
                string texto = String.Format("{0}", _control.getNombrePersona());
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
            }

            if (oWordDoc.Bookmarks.Exists("DireccionDeudor")) {
                // Setea el valor del Bookmark          
                object oBookMark = "DireccionDeudor";
                string texto = String.Format("{0}", _control.getDireccionDeudor());
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
            }

            if (oWordDoc.Bookmarks.Exists("CpDeudor")) {
                // Setea el valor del Bookmark          
                object oBookMark = "CpDeudor";
                string texto = String.Format("{0}", _control.getCpDeudor());
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
            }
            if (oWordDoc.Bookmarks.Exists("LocalidadProvincia")) {
                // Setea el valor del Bookmark          
                object oBookMark = "LocalidadProvincia";
                string texto = String.Format("{0}", _control.getLocalidadDeudor());
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
            }

            if (oWordDoc.Bookmarks.Exists("NombreCliente")) {
                // Setea el valor del Bookmark          
                object oBookMark = "NombreCliente";
                string texto = String.Format("{0}", _control.getNombreCliente());
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
            }

            if (oWordDoc.Bookmarks.Exists("CodigoCuenta")) {
                // Setea el valor del Bookmark          
                object oBookMark = "CodigoCuenta";
                string texto = String.Format("{0}", _control.getCodigoCuenta());
                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
            }
        }

        /// <summary>
        ///   Cierra el formulario contenedor
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e) {
            if (ParentForm == null) return;
            ParentForm.DialogResult = DialogResult.Cancel;
            ParentForm.Close();
        }
    }
}