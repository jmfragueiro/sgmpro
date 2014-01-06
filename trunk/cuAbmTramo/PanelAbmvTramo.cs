///////////////////////////////////////////////////////////
//  PanelAbmvTramo.cs
//  Implementación del panel ABMV para la entidad Relacion
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

namespace cuAbmTramo {
    public partial class PanelAbmvTramo : PanelABMV<Tramo> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvTramo(IControladorEditable<Tramo> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                cargarDatos();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto               
                txtModo.Text = (_objeto.Producto.TramosTemporales)
                                          ? "TEMPORAL"
                                          : "GESTIONES";
                ctrlTxtNombre.Text = _objeto.Nombre;
                labelModo.Text = (_objeto.Producto.TramosTemporales)
                                     ? "días de mora (antig. deuda)"
                                     : "cantidad de gestiones";
                // Números
                ctrlTxtLimite.Text = _objeto.Limite.ToString();
                ctrlTxtHonorario.Text = _objeto.Honorario.ToString();
                ctrlTxtPunitorio.Enabled = _objeto.Producto.Actualizar;
                ctrlTxtPunitorio.Text = _objeto.Punitorio.ToString();
                // Clases
                if (_objeto.Producto != null) {
                    txtProducto.Text = _objeto.Producto.ToString();
                    txtEntidad.Text = _objeto.Producto.Entidad.ToString();
                    lblActualizacion.Text = (_objeto.Producto.Actualizar)
                        ? "La actualización de saldos se encuentra activa!"
                        : "La actualización de saldos no se encuentra activada en el Producto!";
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtLimite.Text == (_objeto.Limite.ToString() ?? "0")
                         && ctrlTxtHonorario.Text == (_objeto.Honorario.ToString() ?? "0")
                         && ctrlTxtPunitorio.Text == (_objeto.Punitorio.ToString() ?? "0")
                         && ctrlTxtNombre.Text == _objeto.Nombre);
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Limite = Convert.ToInt64(
                    string.IsNullOrEmpty(ctrlTxtLimite.Text)
                        ? "0"
                        : ctrlTxtLimite.Text);
                _objeto.Honorario =
                    Convert.ToDouble(
                        string.IsNullOrEmpty(ctrlTxtHonorario.Text)
                            ? "0"
                            : ctrlTxtHonorario.Text);
                _objeto.Punitorio =
                    Convert.ToDouble(
                        string.IsNullOrEmpty(ctrlTxtPunitorio.Text)
                            ? "0"
                            : ctrlTxtPunitorio.Text);
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion
    }
}