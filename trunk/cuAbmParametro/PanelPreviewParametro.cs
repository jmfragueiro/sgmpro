///////////////////////////////////////////////////////////
//  PanelPreviewParametro.cs
//  Implementación del panel de preview para la entidad Parametro
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioToolLibrary;

namespace cuAbmParametro {
    public partial class PanelPreviewParametro : PanelPreview<Parametro> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewParametro(IControladorEditable<Parametro> controlador) : base(controlador) {
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
                txtClave.Text = _objeto.Clave;
                txtNombre.Text = _objeto.Nombre;
                txtValorString.Text = _objeto.Valorstring;
                txtValorChar.Text = _objeto.Valorchar.ToString();
                // Clases
                txtClase.Text = _objeto.Clase.ToString();
                txtTipo.Text = _objeto.Tipo.ToString();
                // Números
                txtOrden.Text = _objeto.Orden.ToString();
                txtValorLong.Text = _objeto.Valorlong.ToString();
                txtValorDouble.Text = _objeto.Valordouble.ToString();
                // Booleanos
                valorBool.Checked = _objeto.Valorbool;
                // Fechas
                txtValorFecha.Text = (_objeto.Valordate <= Fechas.FechaNull) ? "" : _objeto.Valordate.ToString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}