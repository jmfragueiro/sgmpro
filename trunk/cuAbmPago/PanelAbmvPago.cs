///////////////////////////////////////////////////////////
//  PanelAltaPago.cs
//  Implementación del panel de alta para pagos de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cuAbmRecibo;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.enums;
using scioSecureLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmPago {
    public partial class PanelAbmvPago : PanelABMV<Pago> {
        private static readonly Parametro _iva = Parametros.GetByClave("GESTION.IVA");
        protected double _capital, _interes, _honorarios, _gastos, _total, _ivaHonorario;
        protected bool _puedeUnificar;
        protected string _distribucion, _textoImportes;
        protected Cuenta _cuenta;
        protected Convenio _convenio;
        protected WinSelect<Cuenta> _ws;
        private readonly CUListDeudasAsociadas _listDeudasAsociadas;
        private readonly CUListImputaciones _listImputaciones;
        private readonly CUListRecibos _listRecibos;
        private IVistaPanelList _panelDeudas, _panelRecibos, _panelImputaciones;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvPago(IControladorEditable<Pago> controlador) : base(controlador) {
            try {
                InitializeComponent();

                // Luego se inicializan los controladores para los listados
                // (al crearse un pago solamente muestra la lista de deudas
                // pero despues al mirar solamente muestran recibos e imps)                
                if (_controlador.ModoVista == EModoVentana.ADD)
                    _listDeudasAsociadas = new CUListDeudasAsociadas(this);
                else {
                    _listRecibos = new CUListRecibos();
                    _listImputaciones = new CUListImputaciones();
                }
            } catch (Exception e) {
                throw new DataErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void preSetObjeto() {
            _cuenta = null;
            _convenio = null;

            // Antes de setear el objeto se borran las listas
            // que dependen de si el pago existe o no existe
            // (el tab de deudas se usa para deudas e imputs)
            tabRecibos.Controls.Clear();
            tabRecibos.Visible = false;
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                if (_objeto.Cuenta != null) {
                    _cuenta = _objeto.Cuenta;
                    _convenio = _cuenta.ConvenioActivo;
                    _distribucion = _cuenta.Producto.FormulaImputacion;

                    // Esto solo se establece si se ve un pago ya creado
                    if (_controlador.ModoVista == EModoVentana.ADD) {
                        _listDeudasAsociadas.ObjetoMaster = _cuenta;
                        _listDeudasAsociadas.Filtros.Clear();
                    } else {
                        _listImputaciones.ObjetoMaster = _objeto;
                        _listImputaciones.Filtros.Clear();
                        _listRecibos.ObjetoMaster = _objeto;
                        _listRecibos.Filtros.Clear();
                    }

                    //////////////////////////////////////////////////////////////
                    // AGREGADO POR FITO EL 03/11/2013:                         //
                    // Porque la posterior generacion de un recibo cuando no se //
                    // tiene contactos cargados (o uno ppal) no se podra hacer, //
                    // salvo que sea de tipo NINGUNO.                           //
                    //////////////////////////////////////////////////////////////
                    if (_objeto.Cuenta.Titular.getContactoPrincipal() == null) {
                        Sistema.Controlador.mostrar("ERROR-PAGO-CTA-SIN-CTOPPAL", ENivelMensaje.INFORMACION, null, false);
                    }
                    //////////////////////////////////////////////////////////////

                    cargarControles();
                    cargarDatos();
                    cargarTabs();
                }

                // Actualiza lo que se muestra y activa
                grpImportes.Text = "Importes Globales:";
                findCuenta.Enabled = _cuenta == null;
                txtTotal.ReadOnly = _controlador.ModoVista != EModoVentana.ADD;
                lblPagar.Visible = _controlador.ModoVista == EModoVentana.ADD;
                txtPagar.Visible = _controlador.ModoVista == EModoVentana.ADD;

                // Verifica si debe mostrar el botón de generar recibo
                // (solo lo muestra si se esta viendo un pago ya grabado
                // y si dicho pago no posee un recibo por alguna razon)
                if (_controlador.ModoVista == EModoVentana.VIEW 
                    && Sistema.Controlador.SecurityService.usuarioActualPoseePermiso("BOTON.RECIBO.GENERAR", ETipoPermiso.EJECUTAR)) {
                    Recibo rec = RepositorioGenerico<Recibo>.GetUniqueByCriteria(true, new [] {Criterios.Igual("Pago", _objeto)});
                    btnGenerarRecibo.Visible = (rec == null);
                } else {
                    btnGenerarRecibo.Visible = false;
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboFormaPago();
            cargarComboTipo();
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                // Números
                txtCapital.Text = _objeto.Capital.ToString();
                txtInteres.Text = _objeto.Interes.ToString();
                txtHonor.Text = _objeto.Honorarios.ToString();
                txtGastos.Text = _objeto.Gastos.ToString();
                txtTotal.Text = _objeto.Total.ToString();
                // Fechas
                DateTime fecha = Parametros.GetByClave("GESTION.FECHARECIBO").Valordate;
                if (_objeto.Fecha == Fechas.FechaNull)
                    _objeto.Fecha = DateTime.Now.Date < fecha.Date
                                        ? fecha.Date.AddHours(8)
                                        : DateTime.Now;
                txtFecha.Text = _objeto.Fecha.ToString();
                txtFechaUMod.Text = (_objeto.FechaUMod <= Fechas.FechaNull)
                                        ? DateTime.Now.ToString()
                                        : _objeto.FechaUMod.ToString();
                txtFechaBaja.Text = (_objeto.FechaBaja <= Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FechaBaja.ToString();
                // Clases
                if (_objeto.Estado != null)
                    txtEstado.Text = _objeto.Estado.Nombre;
                if (_cuenta != null) {
                    txtCuenta.Tag = _cuenta;
                    txtCuenta.Text = txtCuenta.Tag.ToString();
                    txtPagosAHoy.Text = _cuenta.getMontoPagadoTotal().ToString();
                }
                if (_convenio != null) {
                    txtConvenio.Tag = _convenio;
                    txtConvenio.Text = txtConvenio.Tag.ToString();
                }
                // Verifica que debe mostrar en cuanto a checks
                chkAjustar.Visible = (_controlador.ModoVista == EModoVentana.ADD)
                                     && Sistema.Controlador.SecurityService.usuarioActualPoseePermiso
                                            ("ENTIDAD.PAGO", ETipoPermiso.EJECUTAR);
                chkAjustar.Checked = true;

                // Finalmente inicia recalculando los importes
                resetearCamposImportes();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarTabs() {
            try {
                if (_enProceso) {
                    if (_controlador.ModoVista == EModoVentana.ADD) {
                        _panelDeudas = _listDeudasAsociadas.getPanelListado(EModoVentana.VIEW);
                        _panelDeudas.setMultiSelect(true);
                        _panelDeudas.Contenedor = this;
                        tabRecibos.Visible = false;
                        tabDeudas.Controls.Clear();
                        tabDeudas.Controls.Add((Control)_panelDeudas);
                        tabDeudas.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                    } else {
                        _panelImputaciones = _listImputaciones.getPanelListado(EModoVentana.VIEW);
                        _panelImputaciones.Contenedor = this;
                        tabDeudas.Controls.Clear();
                        tabDeudas.Controls.Add((Control)_panelImputaciones);
                        tabDeudas.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                        _panelRecibos = _listRecibos.getPanelListado(EModoVentana.VIEW);
                        _panelRecibos.Contenedor = this;
                        tabRecibos.Visible = true;
                        tabRecibos.Controls.Clear();
                        tabRecibos.Controls.Add((Control)_panelRecibos);
                        tabRecibos.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                    }
                } else {
                    if (_controlador.ModoVista == EModoVentana.ADD) {
                        _panelDeudas.refrescarListado(_listDeudasAsociadas.ColsInvisibles);
                    } else {
                        _panelImputaciones.refrescarListado(_listImputaciones.ColsInvisibles);
                        _panelRecibos.refrescarListado(_listRecibos.ColsInvisibles);
                    }
                }

                if (_controlador.ModoVista == EModoVentana.ADD) {
                    tabDeudas.Text = "Deuda Seleccionable";
                    tabDeudas.Refresh();
                } else {
                    tabDeudas.Text = string.Format("Imputaciones Hechas ({0})", _listImputaciones.Cuenta);
                    tabRecibos.Text = string.Format("Recibos Asociados ({0})", _listRecibos.Cuenta);
                    tabDeudas.Refresh();
                    tabRecibos.Refresh();
                }
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? "")
                         && txtCapital.Text == _objeto.Capital.ToString()
                         && txtHonor.Text == _objeto.Honorarios.ToString()
                         && txtGastos.Text == _objeto.Gastos.ToString()
                         && txtInteres.Text == _objeto.Interes.ToString()
                         && ctrlTxtComboFormaPago.SelectedItem ==
                            (_objeto.FormaPago ?? ctrlTxtComboFormaPago.SelectedItem)
                         && ctrlTxtComboTipoPago.SelectedItem ==
                            (_objeto.Tipo ?? ctrlTxtComboTipoPago.SelectedItem));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Tipo = (Parametro)ctrlTxtComboTipoPago.SelectedItem;
                _objeto.FormaPago = (Parametro)ctrlTxtComboFormaPago.SelectedItem;
                _objeto.FechaUMod = DateTime.Now;
                _objeto.Cuenta = (Cuenta)txtCuenta.Tag;
                _objeto.Estado = Parametros.GetByClave("ESTADOPAGO.PENDIENTE");
                _objeto.Capital = !string.IsNullOrEmpty(txtCapital.Text)
                                      ? Math.Round(Convert.ToDouble(txtCapital.Text), 2)
                                      : 0;
                _objeto.Interes = !string.IsNullOrEmpty(txtInteres.Text)
                                      ? Math.Round(Convert.ToDouble(txtInteres.Text), 2)
                                      : 0;
                _objeto.Gastos = !string.IsNullOrEmpty(txtGastos.Text)
                                     ? Math.Round(Convert.ToDouble(txtGastos.Text), 2)
                                     : 0;
                _objeto.Honorarios = !string.IsNullOrEmpty(txtHonor.Text)
                                         ? Math.Round(Convert.ToDouble(txtHonor.Text), 2)
                                         : 0;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region controles
        /// <summary>
        /// Este método carga el combo de las Formas de Pago. 
        /// Podría lanzar una VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboFormaPago() {
            ctrlTxtComboFormaPago.Items.Clear();
            try {
                foreach (Parametro p in _cuenta.Entidad.FormasPago) {
                    ctrlTxtComboFormaPago.Items.Add(p);

                    if (_objeto.FormaPago != null && _objeto.FormaPago.Equals(p))
                        ctrlTxtComboFormaPago.SelectedItem = p;
                }

                if (ctrlTxtComboFormaPago.SelectedItem == null && ctrlTxtComboFormaPago.Items.Count >= 1)
                    ctrlTxtComboFormaPago.SelectedItem = ctrlTxtComboFormaPago.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método carga el combo de Tipo de Pago.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipo() {
            ctrlTxtComboTipoPago.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "TIPOPAGO")))
                    // Agrega solo si es seleccionable a 'mano'
                    // (es decir si tiene un Orden MENOR A 11)
                    if (p.Orden < 11 || (_objeto.Tipo != null && _objeto.Tipo.Equals(p))) {
                        ctrlTxtComboTipoPago.Items.Add(p);

                        if (_objeto.Tipo != null && _objeto.Tipo.Equals(p))
                            ctrlTxtComboTipoPago.SelectedItem = p;
                    }

                if (ctrlTxtComboTipoPago.SelectedItem == null && ctrlTxtComboTipoPago.Items.Count >= 1)
                    ctrlTxtComboTipoPago.SelectedItem = ctrlTxtComboTipoPago.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion controles

        #region publics
        /// <summary>
        /// Método que reestablece las características de habilitado o no
        /// en los diferentes campos de importes de la ventana de pagos
        /// </summary>
        public void resetearCamposImportes() {
            // Solo si se esta creando un pago vale resetear
            // (sino simplemente se muestra lo que ya tiene)
            if (_controlador.ModoVista != EModoVentana.ADD)
                return;

            // Inicializa el campos de iva
            _ivaHonorario = 0;

            // Setea el flag de en proceso para evitar refresh de pantalla
            bool booltemp = _enProceso;
            _enProceso = true;       

            // Obtiene el tipo de pago para ver que habilita
            Parametro tipo = (Parametro)ctrlTxtComboTipoPago.SelectedItem;

            // Recalcula los importes
            recalcularImporte();     
        
            txtCapital.Text = (tipo.Nombre.Equals("GASTOS")||tipo.Nombre.Equals("HONORARIOS"))
                                ? "0"
                                : _capital.ToString(); 
            txtInteres.Text = (tipo.Nombre.Equals("GASTOS")||tipo.Nombre.Equals("HONORARIOS"))
                                ? "0"
                                : _interes.ToString();
            txtHonor.Text = (tipo.Nombre.Equals("GASTOS"))
                                ? "0"
                                : _honorarios.ToString();
            txtGastos.Text = (tipo.Nombre.Equals("HONORARIOS"))
                                ? "0"
                                : _gastos.ToString();
            txtTotal.Text = (tipo.Nombre.Equals("GASTOS"))
                                ? _gastos.ToString()
                                : (tipo.Nombre.Equals("HONORARIOS"))
                                    ? _honorarios.ToString()
                                    : _total.ToString();

            // Finalmente muestra el total a pagar
            txtPagar.Text = (getIVAHonorarios()
                                + Convert.ToDouble(string.IsNullOrEmpty(txtTotal.Text) ? "0" : txtTotal.Text))
                                    .ToString();

            // Vuelve a actival los refresh de pantalla y eso
            _enProceso = booltemp;
        }

        /// <summary>
        /// Método que reestablece las características de habilitado o no
        /// en los diferentes campos de importes de la ventana de pagos
        /// </summary>
        public void redistribuirCamposImportes() {
            // Solo si se esta creando un pago vale resetear
            // (sino simplemente se muestra lo que ya tiene)
            if (_controlador.ModoVista != EModoVentana.ADD)
                return;

            // Inicializa el campos de iva
            _ivaHonorario = 0;

            // Setea el flag de en proceso para evitar refresh de pantalla
            bool booltemp = _enProceso;
            _enProceso = true;

            // Obtiene el tipo de pago para ver que habilita
            Parametro tipo = (Parametro)ctrlTxtComboTipoPago.SelectedItem;

            // Actua de acuerdo a si se puede o no ajustar importes
            if (chkAjustar.Checked) {
                _total = Math.Round(Convert.ToDouble(txtTotal.Text), 2);

                // Ditribuye el total
                ditribuirTotal();

                txtCapital.Text = (tipo.Nombre.Equals("GASTOS") || tipo.Nombre.Equals("HONORARIOS"))
                                    ? "0"
                                    : _capital.ToString();
                txtInteres.Text = (tipo.Nombre.Equals("GASTOS") || tipo.Nombre.Equals("HONORARIOS"))
                                    ? "0"
                                    : _interes.ToString();
                txtHonor.Text = (tipo.Nombre.Equals("GASTOS"))
                                    ? "0"
                                    : (tipo.Nombre.Equals("HONORARIOS"))
                                        ? _total.ToString()
                                        : _honorarios.ToString(); 
                txtGastos.Text = (tipo.Nombre.Equals("HONORARIOS"))
                                    ? "0"
                                    : (tipo.Nombre.Equals("GASTOS"))
                                        ? _total.ToString()
                                        : _gastos.ToString();
                txtTotal.Text = _total.ToString(); 
            } else {
                txtTotal.Text =
                    (Convert.ToDouble(string.IsNullOrEmpty(txtCapital.Text) ? "0" : txtCapital.Text)
                        + Convert.ToDouble(string.IsNullOrEmpty(txtInteres.Text) ? "0" : txtInteres.Text)
                        + Convert.ToDouble(string.IsNullOrEmpty(txtHonor.Text) ? "0" : txtHonor.Text)
                        + Convert.ToDouble(string.IsNullOrEmpty(txtGastos.Text) ? "0" : txtGastos.Text))
                        .ToString();
            }

            // Finalmente muestra el total a pagar
            txtPagar.Text = (getIVAHonorarios()
                                + Convert.ToDouble(string.IsNullOrEmpty(txtTotal.Text) ? "0" : txtTotal.Text))
                                    .ToString();

            // Vuelve a actival los refresh de pantalla y eso
            _enProceso = booltemp;
        }

        /// <summary>
        /// Este método retorna el listado de cuotas seleccionadas
        /// para pagar (en un momento determinado) en la ventana.
        /// Verifica si debe generar deuda de punitorios asociada.
        /// </summary>
        /// <returns>
        /// El listado actual de cuotas seleccionadas para pagar.
        /// </returns>
        public List<Deuda> getCuotas() {
            List<Deuda> cuotas = new List<Deuda>();
            foreach (Deuda cuota in _listDeudasAsociadas.getSeleccion())
                cuotas.Add(cuota);
            return cuotas;
        }

        /// <summary>
        /// Este método retorna si se pueden unificar los gastos al capital,
        /// lo que depende de que TODAS las deudas seleccionadas a pagar sean
        /// deudas informadas.
        /// </summary>
        /// <returns>
        /// El estado del flag que indica si se puede unificar.
        /// </returns>
        public bool puedeUnificar() {
            return _puedeUnificar;
        }

        /// <summary>
        /// Este método retorna el iva de honorarios calculado para el pago.
        /// 08/03/2013: El IVA ahora se calcula a partir del % que se toma
        ///             desde el campo par_double de la forma de pago.
        /// </summary>
        /// <returns>
        /// El IVA de honorarios calculado para el pago.
        /// </returns>
        public double getIVAHonorarios() {
            _ivaHonorario = Convert.ToDouble(string.IsNullOrEmpty(txtHonor.Text) ? "0" : txtHonor.Text);
            //_ivaHonorario *= Math.Round((_iva.Valordouble / 100), 2);
            //return (_ivaHonorario < 0) ? 0 : Math.Round(_ivaHonorario, 2);
            // Obtiene el tipo de pago para ver que habilita
            Parametro tipo = (Parametro)ctrlTxtComboFormaPago.SelectedItem;
            _ivaHonorario *= Math.Round((tipo.Valordouble / 100), 2);
            return (_ivaHonorario < 0) ? 0 : Math.Round(_ivaHonorario, 2);
        }
        #endregion publics

        #region helpers
        /// <summary>
        /// Este método se encarga de recalcular los importes a partir de 
        /// la lista de deudas pasada como argumento. Verifica el check de
        /// punitorios y los calcula se debe (los punitorios van a gastos
        /// y, al final, se crean objetos Deuda para el punitorio de cada 
        /// Deuda seleccionada para pagar).
        /// </summary>
        protected void recalcularImporte() {
            _puedeUnificar = _cuenta.Producto.UnificaGastos;
            _capital = _interes = _honorarios = _gastos = 0;

            foreach (Deuda cuota in _listDeudasAsociadas.getSeleccion()) {
                _capital += cuota.Capital;
                _interes += cuota.Interes;
                _honorarios += cuota.Honorarios;
                _gastos += cuota.Gastos;
                _puedeUnificar &= cuota.Informada;
            }

            _total = _capital + _interes + _honorarios + _gastos;

            grpImportes.Text = _textoImportes + 
                ((_controlador.ModoVista == EModoVentana.ADD && _puedeUnificar)
                ? " (Unifica Gastos con Capital en el Recibo)" : string.Empty);
        }

        /// <summary>
        /// Distribuye el total en los componentes de importes del pago, y de
        /// acuerdo a la configuración dada para el producto de la cuenta.
        /// </summary>
        protected void ditribuirTotal() {
            double porc, resto, aplicar;
            double capi = 0, inte = 0, hono = 0, gast = 0, tot1 = 0, tot2 = 0;

            double saldo = _total;
            recalcularImporte();

            foreach (string cad in _distribucion.ToUpper().Split(':')) {
                char comp = cad.ToCharArray()[0];                               // verifica el tipo de componente de deuda (o subtotal) a calcular
                char comp1 = cad.ToCharArray()[1];                              // si es un calculo de subtotal (T) verifica cual de los dos

                // establece el porcentaje a utilizar en este cálculo (esta iteracion) 
                porc = aplicar = 0;
                if (cad.Length > 2) {
                    if (cad.Contains("T1")) {
                        if (cad.ToCharArray()[3] == '-') {
                            porc = Math.Round(Convert.ToDouble(cad.Substring(4)) / 100, 3);
                            aplicar = tot1 - Math.Round(tot1*porc, 2);
                        } else {
                            porc = Math.Round(Convert.ToDouble(cad.Substring(3)) / 100, 3);
                            aplicar = Math.Round(tot1 * porc, 2);                            
                        }
                    } else if (cad.Contains("T2")) {
                        if (cad.ToCharArray()[3] == '-') {
                            porc = Math.Round(Convert.ToDouble(cad.Substring(4)) / 100, 3);
                            aplicar = tot2 - Math.Round(tot1 * porc, 2);
                        } else {
                            porc = Math.Round(Convert.ToDouble(cad.Substring(3)) / 100, 3);
                            aplicar = Math.Round(tot2 * porc, 2);
                        }
                    } 
                }

                // si no calculo el procentaje es porque es un caso 'normal'
                if (porc < 0.001) {
                    porc = Math.Round(Convert.ToDouble(cad.Substring(1)) / 100, 3);
                    aplicar = Math.Round(saldo * porc, 2);  
                }

                switch (comp) {
                    case 'C':
                        resto = aplicar - _capital;
                        capi = (resto > 0) ? _capital : aplicar;
                        saldo -= capi;
                        break;
                    case 'I':
                        resto = aplicar - _interes;
                        inte = (resto > 0) ? _interes : aplicar;
                        saldo -= inte;
                        break;
                    case 'H':
                        resto = aplicar - _honorarios;
                        hono = (resto > 0) ? _honorarios : aplicar;
                        saldo -= hono;
                        break;
                    case 'G':
                        resto = aplicar - _gastos;
                        gast = (resto > 0) ? _gastos : aplicar;
                        saldo -= gast;
                        break;
                    case 'T':
                        if (comp1 == '1')
                            tot1 = saldo;
                        if (comp1 == '2')
                            tot2 = saldo;
                        break;
                }
                if (saldo <= 0)
                    break;
            }
            _capital = capi;
            _interes = inte;
            _honorarios = hono;
            _gastos = gast;
            _total = _capital + _interes + _honorarios + _gastos;
        }

        /// <summary>
        /// Este método reorganiza los importes al cambiar la cabecera.
        /// </summary>
        protected void alCambiarCabecera() {
            // Obtiene el tipo de pago para ver que habilita
            Parametro tipo = (Parametro)ctrlTxtComboTipoPago.SelectedItem;

            // Para empezar blanquea todos los campos
            txtCapital.ReadOnly = chkAjustar.Checked || tipo.Nombre.Equals("GASTOS")
                                  || tipo.Nombre.Equals("HONORARIOS");
            txtInteres.ReadOnly = chkAjustar.Checked || tipo.Nombre.Equals("GASTOS")
                                  || tipo.Nombre.Equals("HONORARIOS");
            txtHonor.ReadOnly = chkAjustar.Checked || tipo.Nombre.Equals("GASTOS");
            txtGastos.ReadOnly = chkAjustar.Checked || tipo.Nombre.Equals("HONORARIOS");
            txtTotal.ReadOnly = !(chkAjustar.Checked);

            resetearCamposImportes();

            Sistema.Controlador.mostrar("INFO-PAGO-MODIFICADO", ENivelMensaje.INFORMACION, null, false);            
        }
        #endregion helpers

        #region interface
        /// <summary>
        /// Este método responde al botón Ver Cuenta. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerCuenta_Click(object sender, EventArgs e) {
            try {
                if (txtCuenta.Tag != null)
                    CUCaller.CallCU("cuAbmCuenta", this, new[] {EModoVentana.VIEW, txtCuenta.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Convenio. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerConvenio_Click(object sender, EventArgs e) {
            try {
                if (txtConvenio.Tag != null)
                    CUCaller.CallCU("cuAbmConvenio", this, new[] {EModoVentana.VIEW, txtConvenio.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Buscar Cuenta. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindCuenta_Click(object sender, EventArgs e) {
            try {
                if (_ws == null)
                    _ws = new WinSelect<Cuenta>("cuAbmCuenta.CUListCuentas");

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    _cuenta = _ws.Seleccion;
                    _objeto.Cuenta = _cuenta;
                    setearObjeto(_objeto);
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al cambio de valor en algun campo de importe de pago. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtTotal_KeyDown(object sender, EventArgs e) {
            // verifica si debe resetar los totales calculados al momento
            // (solo si no esta en proceso de cambio por ingresar al panel)
            if (!_enProceso) {
                if ((chkAjustar.Checked 
                    && Math.Abs((Convert.ToDouble(string.IsNullOrEmpty(txtTotal.Text) ? "0" : txtTotal.Text)) 
                        - _listDeudasAsociadas.getTotalSeleccionado()) > 0)   
                    ||
                    (!chkAjustar.Checked
                    && Math.Abs((Convert.ToDouble(string.IsNullOrEmpty(txtCapital.Text) ? "0" : txtCapital.Text)
                                 + Convert.ToDouble(string.IsNullOrEmpty(txtInteres.Text) ? "0" : txtInteres.Text)
                                 + Convert.ToDouble(string.IsNullOrEmpty(txtHonor.Text) ? "0" : txtHonor.Text)
                                 + Convert.ToDouble(string.IsNullOrEmpty(txtGastos.Text) ? "0" : txtGastos.Text)) 
                                 - _listDeudasAsociadas.getTotalSeleccionado()) > 0)) 
                    redistribuirCamposImportes();
            }                
        }

        /// <summary>
        /// Este método responde al cambio de valor en el combo del tipo de pago. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtComboTipoPago_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlTxtComboTipoPago.SelectedItem == null)
                return;

            if (!_enProceso)
                alCambiarCabecera();           
        }

        /// <summary>
        /// Este método responde al cambio de valor en el combo de la forma de pago. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtComboFormaPago_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlTxtComboFormaPago.SelectedItem == null)
                return;

            if (!_enProceso)
                alCambiarCabecera();
        }

        /// <summary>
        /// Este método responde al cambio de valor en el chebox del IVA. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void chkAjustar_CheckedChanged(object sender, EventArgs e) {
            // verifica si debe resetar los totales de cuotas seleccionadas
            // (solo si no esta en proceso de cambio por ingresar al panel)
            if (!_enProceso) {
                alCambiarCabecera(); 
            }
        }

        /// <summary>
        /// Este método responde al click en el botón de generar recibo. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnGenerarRecibo_Click(object sender, EventArgs e) {
            Parametro _honorario = Parametros.GetByClave("TIPOPAGO.HONORARIOS");
            Parametro _gastos = Parametros.GetByClave("TIPOPAGO.GASTOS");
            Parametro _dorigen = Parametros.GetByClave("CONCEPTODEUDA.ORIGEN");
            Parametro _dgastos = Parametros.GetByClave("CONCEPTODEUDA.GASTO");
            Parametro _dhonorario = Parametros.GetByClave("CONCEPTODEUDA.HONORARIO");
            Parametro concepto = _dorigen;

            double importe = Math.Round((_objeto.Capital + _objeto.Interes), 2);
            if (_puedeUnificar)
                importe += Math.Round(_objeto.Gastos, 2);

            if (_objeto.Tipo.Equals(_honorario)) {
                concepto = _dhonorario;
                importe = Math.Round(_objeto.Honorarios, 2);
            } else if (_objeto.Tipo.Equals(_gastos)) {
                concepto = _dgastos;
                importe = Math.Round(_objeto.Gastos, 2);
            }

            Recibo rc = new Recibo {
                Concepto = concepto,
                Fecha = _objeto.Fecha,
                Importe = importe,
                Pago = _objeto
            };

            try {
                CUCaller.CallCU("cuAbmRecibo", this, new object[] { EModoVentana.ADD, rc });
            } catch (Exception ex) {
                Sistema.Controlador.logear("ERROR-PAGO-RECIBO", ENivelMensaje.ERROR, ex.ToString());
            }
        }
        #endregion interface
    }
}