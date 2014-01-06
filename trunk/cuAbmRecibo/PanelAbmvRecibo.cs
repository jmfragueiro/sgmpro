///////////////////////////////////////////////////////////
//  PanelAbmvRecibo.cs
//  Implementación del panel de alta para recibos de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////

using System;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioSecureLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmRecibo {
    public partial class PanelAbmvRecibo : PanelABMV<Recibo> {
        private readonly Parametro _honorario = Parametros.GetByClave("TIPOPAGO.HONORARIOS");

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvRecibo(IControladorEditable<Recibo> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new DataErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                cargarDatos();
                cargarControles();
                cargarPanelPersonas();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                ctrlTxtDescripcion.Text = (_objeto.Descripcion == String.Empty)
                                              ? _objeto.Descripcion
                                              : _objeto.Pago.Descripcion;
                // Números
                txtImporte.Text = _objeto.Importe.ToString();
                ctrlTxtNumero.Text = _objeto.Numero ?? "";
                // Fechas
                txtFecha.Text = (_objeto.Fecha <= Fechas.FechaNull)
                                    ? DateTime.Now.ToString()
                                    : _objeto.Fecha.ToString();
                // Clases
                if (_objeto.Pago != null) {
                    txtPago.Tag = _objeto.Pago;
                    txtPago.Text = txtPago.Tag.ToString();
                }
                if (_objeto.Concepto != null) {
                    txtConcepto.Tag = _objeto.Concepto;
                    txtConcepto.Text = txtConcepto.Tag.ToString();
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboTipoRecibo();
            cargarPanelPersonas();

            if (_controlador.ModoVista == EModoVentana.VIEW) {
                btnReimprimirRecibo.Visible = 
                    Sistema.Controlador.SecurityService
                        .usuarioActualPoseePermiso("BOTON.RECIBO.REIMPRIMIR",ETipoPermiso.EJECUTAR);

                btnImprimirCopia.Visible = 
                    Sistema.Controlador.SecurityService
                        .usuarioActualPoseePermiso("BOTON.RECIBO.COPIAFIEL", ETipoPermiso.EJECUTAR);

                setNoEditable();
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtNumero.Text == (_objeto.Numero ?? "")
                         && ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? "")
                         && ctrlTxtComboTipoRecibo.SelectedItem ==
                         (_objeto.Tipo ?? ctrlTxtComboTipoRecibo.SelectedItem));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Numero = ctrlTxtNumero.Text;
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Tipo = (Parametro) ctrlTxtComboTipoRecibo.SelectedItem;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region controles
        /// <summary>
        /// Este método carga el combo de tipo de recibo.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipoRecibo() {
            ctrlTxtComboTipoRecibo.Items.Clear();
            try {
                foreach (Parametro p in _objeto.Pago.Cuenta.Entidad.TiposRecibo) {
                    if (_controlador.ModoVista != EModoVentana.VIEW) {
                        // Controla que no se visualicen comprobantes que discriminan el IVA para aquellos 
                        // titulares que no tengan condición correspondiente en AFIP. Las condiciones que
                        // utilizan el IVA son aquellas que tienen Valorbool true (TipoIVA) y comprobantes 
                        // que discriminan el IVA, son los que tienen Valordouble distinto de cero.
                        if (p.Valordouble == 0 && !_objeto.Pago.Cuenta.Titular.TipoIVA.Valorbool) 
                            // Controla que si se eligió una forma de pago que no tiene IVA entonces
                            // solo puede utilizarse el tipo de recibo X (marcado con X en valorchar)
                            // NOTA: Aqui solo se toman los pagos de honorarios
                            if ((_objeto.Pago.Tipo.Equals(_honorario)
                                    && (_objeto.Pago.FormaPago.Valordouble == 0 && p.Valorchar == 'X')
                                        || _objeto.Pago.FormaPago.Valordouble > 0)
                                || !_objeto.Pago.Tipo.Equals(_honorario)) {
                                    //////////////////////////////////////////////////////////////
                                    // AGREGADO POR FITO EL 03/11/2013:                         //
                                    // Porque la posterior generacion de un recibo cuando no se //
                                    // tiene contactos cargados (o uno ppal) no se podra hacer, //
                                    // salvo que sea de tipo NINGUNO.                           //
                                    //////////////////////////////////////////////////////////////
                                    if (_objeto.Pago.Cuenta.Titular.getContactoPrincipal() != null
                                        || (_objeto.Pago.Cuenta.Titular.getContactoPrincipal() == null
                                            && p.Nombre.Equals("NINGUNO")))
                                    //////////////////////////////////////////////////////////////
                                        ctrlTxtComboTipoRecibo.Items.Add(p);                                    
                                }
                    } else {
                        ctrlTxtComboTipoRecibo.Items.Add(p);
                    }

                    if (_objeto.Tipo != null && _objeto.Tipo.Equals(p))
                        ctrlTxtComboTipoRecibo.SelectedItem = p;
                }
                if (ctrlTxtComboTipoRecibo.SelectedItem == null && ctrlTxtComboTipoRecibo.Items.Count >= 1)
                    ctrlTxtComboTipoRecibo.SelectedItem = ctrlTxtComboTipoRecibo.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Carga el panel con los datos de las personas
        /// relacionadas con las cuentas.
        /// </summary>
        private void cargarPanelPersonas() {
            panelAbmvContacto1.setNoEditable();
            Contacto cto = _objeto.Pago.Cuenta.Titular.getContactoPrincipal();           
            //////////////////////////////////////////////////////////////
            // AGREGADO POR FITO EL 03/11/2013:                         //
            // Porque la posterior generacion de un recibo cuando no se //
            // tiene contactos cargados (o uno ppal) no se podra hacer, //
            // salvo que sea de tipo NINGUNO.                           //
            //////////////////////////////////////////////////////////////
            if (cto != null)
            //////////////////////////////////////////////////////////////
                panelAbmvContacto1.setearObjeto(cto);
        }
        #endregion

        #region interface
        /// <summary>
        /// Este método responde al botón Reimprimir Recibo. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnReimprimirRecibo_Click(object sender, EventArgs e) {
            CUCaller.CallCU("cuGenerarInformes.CUGenerarRecibo", null, new object[] {_objeto, _objeto});
        }

        /// <summary>
        /// Este método responde al botón Imprimir Copia Fiel. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnImprimirCopia_Click(object sender, EventArgs e) {
            CUCaller.CallCU("cuGenerarInformes.CUGenerarRecibo", null, new object[] {_objeto, _objeto, true});
        }

        /// <summary>
        /// Este método responde al cambio de tipo de recibo. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtComboTipoRecibo_SelectedIndexChanged(object sender, EventArgs e) {
            ctrlTxtNumero.Text = "";

            if (ctrlTxtComboTipoRecibo.SelectedItem != null) {
                if (((Parametro) ctrlTxtComboTipoRecibo.SelectedItem).Nombre.Equals("NINGUNO")) {
                    ctrlTxtNumero.Text = "0";
                    ctrlTxtNumero.Enabled = false;
                } else
                    ctrlTxtNumero.Enabled = ((Parametro) ctrlTxtComboTipoRecibo.SelectedItem).Valorlong <= 0;
            }
        }
        #endregion interface
    }
}