///////////////////////////////////////////////////////////
//  PanelAbmvFactura.cs
//  Implementación del panel ABMV para la entidad Factura
//  de la aplicación.
//  Generated Manualmente
//  Created on:      01-sep-2009 12:00:00
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.caja;
using sgmpro.dominio.configuracion;

namespace cuAbmFactura {
    public partial class PanelAbmvFactura : PanelABMV<Factura> {
        private double _subtotal, _total;
        private readonly CUListItemFactura _listItems;
        private IVistaPanelList _panelItems;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvFactura(IControladorEditable<Factura> controlador) : base(controlador) {
            try {
                InitializeComponent();
                _listItems = new CUListItemFactura {Padre = this};
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                _listItems.ObjetoMaster = _objeto;
                _listItems.Filtros.Clear();

                cargarControles();
                cargarDatos();
                cargarTabs();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboCliente();
            cargarComboTipo();
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Booleano
                ctrlChkContado.Checked = _objeto.Contado;
                // Texto
                ctrlTxtNumero.Text = _objeto.Numero;
                if (_objeto.Items.Count <= 0)
                    _objeto.IVA = ((Parametro)ctrlCmbTipo.SelectedItem).Valordouble;
                ctrlTxtIVA.Text = _objeto.IVA.ToString("0.#0");
                // Fechas
                ctrlFecha.Value = _objeto.Fecha;
                ctrlTxtFecha.Text = ctrlFecha.Value.ToString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarTabs() {
            try {
                if (_enProceso) {
                    _panelItems = _controlador.ModoVista <= EModoVentana.VIEW
                                      ? _listItems.getPanelListado(EModoVentana.VIEW)
                                      : _listItems.getPanelListado(EModoVentana.EDIT);
                    _panelItems.Contenedor = this;
                    tabItems.Controls.Clear();
                    tabItems.Controls.Add((Control)_panelItems);
                    tabItems.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else
                    _panelItems.refrescarListado(_listItems.ColsInvisibles);

                tabItems.Text = string.Format("Items ({0})", _listItems.Cuenta);
                tabItems.Refresh();

                refrescarTotales();
                reiniciarItem(null);
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Contado = ctrlChkContado.Checked;
                _objeto.Numero = ctrlTxtNumero.Text;
                _objeto.IVA = Convert.ToDouble(ctrlTxtIVA.Text ?? "0");
                _objeto.Tipo = (Parametro)ctrlCmbTipo.SelectedItem;
                _objeto.Cliente = (Entidad)ctrlCmbCliente.SelectedItem;
                _objeto.Fecha = (ctrlFecha.Value <= Fechas.FechaNull) ? Fechas.FechaNull : ctrlFecha.Value;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return
                    !(ctrlTxtNumero.Text.Equals(_objeto.Numero ?? string.Empty) && ctrlFecha.Value == _objeto.Fecha &&
                      ctrlTxtIVA.Text.Equals(_objeto.IVA.ToString() ?? string.Empty) &&
                      ctrlCmbCliente.SelectedItem.Equals(_objeto.Cliente ?? ctrlCmbCliente.SelectedItem) &&
                      ctrlCmbTipo.SelectedItem.Equals(_objeto.Tipo ?? ctrlCmbTipo.SelectedItem) &&
                      ctrlChkContado.Checked == _objeto.Contado);
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }
        #endregion panelabmv

        #region IVistaContenedor members
        /// <summary>
        ///   Ver descripcion en clase base.
        /// </summary>
        public override void actualizarDatos() {
            cargarControles();
            cargarDatos();
        }
        #endregion

        #region controles
        /// <summary>
        ///   Este método carga el combo de Entidades de la cuenta.
        ///   Lanza una VistaErrorException si tiene algún problema.
        /// </summary>
        private void cargarComboCliente() {
            ctrlCmbCliente.Items.Clear();
            ctrlCmbCliente.ReadOnly = false;
            try {
                foreach (Entidad ent in RepositorioGenerico<Entidad>.GetAll()) {
                    ctrlCmbCliente.Items.Add(ent);

                    if (_objeto.Cliente != null && _objeto.Cliente.Equals(ent)) {
                        ctrlCmbCliente.SelectedItem = ent;
                        ctrlCmbCliente.ReadOnly = true;
                    }
                }

                if (ctrlCmbCliente.SelectedItem == null && ctrlCmbCliente.Items.Count >= 1)
                    ctrlCmbCliente.SelectedItem = ctrlCmbCliente.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método carga el combo de tipo de recibo.
        ///   Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipo() {
            ctrlCmbTipo.Items.Clear();
            try {
                foreach (Parametro p in Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "TIPOFACTURA"))
                    // Controla que no se visualice la opción de 
                    // comprobantes que no tengan 'F' en valorchar.
                    if (p.Valorchar.Equals('F')) {
                        ctrlCmbTipo.Items.Add(p);

                        if (_objeto.Tipo != null && _objeto.Tipo.Equals(p))
                            ctrlCmbTipo.SelectedItem = p;
                    }

                if (ctrlCmbTipo.SelectedItem == null && ctrlCmbTipo.Items.Count >= 1)
                    ctrlCmbTipo.SelectedItem = ctrlCmbTipo.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion

        #region helpers
        /// <summary>
        ///   Calcula y refresca los totales de la factura.
        /// </summary>
        public void refrescarTotales() {
            // totales       
            _subtotal = _total = 0;
            foreach (ItemFactura item in _objeto.Items)
                if (item.isAlive()) {
                    _subtotal += item.Total;
                    _total += item.Total + (item.Total*(_objeto.IVA/100));
                }
            txtSubtotal.Text = _subtotal.ToString("0.#0");
            txtTotal.Text = _total.ToString("0.#0");
        }

        /// <summary>
        ///   En caso que se modifique el valor del IVA en el formulario
        ///   y es diferente al de la Cliente.
        /// </summary>
        public void recalculaIva() {
            ctrlTxtIVA.Text = Convert.ToDouble(ctrlTxtIVA.Text).ToString("0.#0");
            _total = _subtotal*(1 + (Convert.ToDouble(ctrlTxtIVA.Text)/100));
            txtTotal.Text = _total.ToString("0.#0");
        }

        /// <summary>
        ///   Este método reinicia la carga de un item.
        /// </summary>
        public void reiniciarItem(ItemFactura item) {
            if (item == null) {
                ctrlTxtItem.Text = "1"; //(++_cantidad).ToString();
                ctrlTxtConcepto.Text = string.Empty;
                ctrlTxtPrecio.Text = string.Empty;
            } else {
                ctrlTxtItem.Text = item.Numero.ToString();
                ctrlTxtConcepto.Text = item.Concepto;
                ctrlTxtPrecio.Text = item.Precio.ToString();
            }
            ctrlTxtItem.Focus();
        }

        /// <summary>
        ///   Este método crea un item para la factura, pero
        ///   primero verifica que no exista, ya que si existe 
        ///   simplemente actualiza los datos del mismo.
        /// </summary>
        private void crearItem() {
            // Una vez que esta todos grabado y limpio...
            try {
                if (string.IsNullOrEmpty(ctrlTxtItem.Text) || string.IsNullOrEmpty(ctrlTxtConcepto.Text) ||
                    string.IsNullOrEmpty(ctrlTxtPrecio.Text) || Convert.ToInt64(ctrlTxtItem.Text) <= 0 ||
                    Convert.ToDouble(ctrlTxtPrecio.Text) <= 0)
                    return;

                // Controla si tiene cargado un nro de factura
                if (ctrlTxtNumero.Text == String.Empty) {
                    ctrlTxtNumero.BackColor = Color.DeepPink;
                    return;
                }

                // Primero verifica si hay algo para guardar
                if (isDirty())
                    if (Sistema.Controlador.mostrar("PREGUNTA-SAVE-FOR-ADD", ENivelMensaje.PREGUNTA, null, false) ==
                        DialogResult.Yes)
                        Contenedor.guardarDatos();
                    else
                        return;

                ItemFactura item = new ItemFactura {
                    Concepto = ctrlTxtConcepto.Text,
                    Numero = Convert.ToInt64(ctrlTxtItem.Text),
                    Precio = Convert.ToDouble(ctrlTxtPrecio.Text)
                };
                item.save();
                _objeto.Items.Add(item);
                _objeto.save();
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            } finally {
                cargarTabs();
                refrescarTotales();
                reiniciarItem(null);
            }
        }

        /// <summary>
        ///   Si es un nro devuelve true
        /// </summary>
        private static bool EsNro(KeyEventArgs unaTecla) {
            if (unaTecla.KeyData == Keys.Space || //unaTecla.KeyData == Keys.Decimal || 
                unaTecla.KeyData == Keys.Subtract || unaTecla.KeyData == Keys.NumPad0 ||
                unaTecla.KeyData == Keys.NumPad1 || unaTecla.KeyData == Keys.NumPad2 || unaTecla.KeyData == Keys.NumPad3 ||
                unaTecla.KeyData == Keys.NumPad4 || unaTecla.KeyData == Keys.NumPad5 || unaTecla.KeyData == Keys.NumPad6 ||
                unaTecla.KeyData == Keys.NumPad7 || unaTecla.KeyData == Keys.NumPad8 || unaTecla.KeyData == Keys.NumPad9 ||
                unaTecla.KeyData == Keys.D0 || unaTecla.KeyData == Keys.D1 || unaTecla.KeyData == Keys.D2 ||
                unaTecla.KeyData == Keys.D3 || unaTecla.KeyData == Keys.D4 || unaTecla.KeyData == Keys.D5 ||
                unaTecla.KeyData == Keys.D6 || unaTecla.KeyData == Keys.D7 || unaTecla.KeyData == Keys.D8 ||
                unaTecla.KeyData == Keys.D9 || unaTecla.KeyData == Keys.ShiftKey || unaTecla.KeyValue == 50 ||
                unaTecla.KeyValue == 189 || unaTecla.KeyData == Keys.Delete || unaTecla.KeyData == Keys.Back ||
                unaTecla.KeyValue == 188)
                return true;
            return false;
        }
        #endregion

        #region interfase
        /// <summary>
        ///   Este método responde al del datetimepicker de Fecha Inicio. 
        ///   Debería 'mostrar' cualquier error que ocurriese y no propagar 
        ///   ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFecha_ValueChanged(object sender, EventArgs e) {
            string fecha = (ctrlFecha.Value <= Fechas.FechaNull) ? DateTime.Now.ToString() : ctrlFecha.Value.ToString();

            if (!ctrlTxtFecha.Text.Equals(fecha))
                ctrlTxtFecha.Text = fecha;
        }

        /// <summary>
        ///   Este método responde al cambio de fecha del convenio desde el 
        ///   propio campo. Debería 'mostrar' cualquier error que ocurriese y 
        ///   no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtFecha_Validated(object sender, EventArgs e) {
            DateTime fecha = Convert.ToDateTime(ctrlTxtFecha.Text);
            if (ctrlFecha.Value != fecha) {
                _objeto.Fecha = fecha;
                ctrlFecha.Value = fecha;
            }
        }

        /// <summary>
        ///   Este método responde al enter en el campo precio, el cual da 
        ///   definitivamente de alta un nuevo registro de item. Se debería 
        ///   'mostrar' cualquier error que ocurriese y no propagar ninguna 
        ///   excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtPrecio_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                crearItem();
            } else if (!EsNro(e))
                e.SuppressKeyPress = true;
        }

        /// <summary>
        ///   Este método responde al enter en el campo nro de item. Debería 
        ///   'mostrar' cualquier error que ocurriese y no propagar ninguna 
        ///   excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtItem_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                ctrlTxtConcepto.Focus();
            }
        }

        /// <summary>
        ///   Este método responde al enter en el campo concepto. Debería 
        ///   'mostrar' cualquier error que ocurriese y no propagar ninguna 
        ///   excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtConcepto_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                ctrlTxtPrecio.Focus();
            }
        }

        /// <summary>
        ///   Evento del boton imprimir.
        /// </summary>
        private void btnReimprimirRecibo_Click(object sender, EventArgs e) {
            try {
                refrescarDatos();
                _objeto.save();
                Cursor = Cursors.WaitCursor;
                CUAbmFactura miCu = (CUAbmFactura)_controlador;
                if (!miCu.imprimeFacturaA(_objeto, _listItems)) {
                    MessageBox.Show(
                        Mensaje.TextoMensaje("REPORTE-FALTADATO"),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Cursor = Cursors.Default;
                    return;
                }
                Cursor = Cursors.Default;
            } catch (Exception ex) {
                Cursor = Cursors.Default;
                throw new CuErrorException("REPORTE-ERROR", ex.ToString());
            }
        }

        /// <summary>
        ///   Si se modifica el valor del IVA y se presiona ENTER
        ///   se recalcula el total.
        /// </summary>
        private void ctrlTxtIVA_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                recalculaIva();
            } else if (!EsNro(e))
                e.SuppressKeyPress = true;
        }

        /// <summary>
        ///   Si se modifica el IVA y se sale del cuadro de texto
        ///   se recalcula el total
        /// </summary>
        private void ctrlTxtIVA_Leave(object sender, EventArgs e) {
            recalculaIva();
        }

        /// <summary>
        ///   Este método responde al evento de enter en el numero.
        /// </summary>
        private void ctrlTxtNumero_Enter(object sender, EventArgs e) {
            ctrlTxtNumero.BackColor = Color.Empty;
        }
        #endregion
    }
}