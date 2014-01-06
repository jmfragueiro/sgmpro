///////////////////////////////////////////////////////////
//  PanelAbmvParametro.cs
//  Implementación del panel ABMV para la entidad Deuda
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuAbmParametro {
    public partial class PanelAbmvParametro : PanelABMV<Parametro> {
        private readonly EClaseParametro[] _listaClase = {
            EClaseParametro.NINGUNO,
            EClaseParametro.SISTEMA,
            EClaseParametro.GLOBAL,
            EClaseParametro.USUARIO
        };

        private readonly ETipoParametro[] _listaTipo = {
            ETipoParametro.NINGUNO,
            ETipoParametro.BASE,
            ETipoParametro.RECURSO,
            ETipoParametro.MENU,
            ETipoParametro.SUBMENU,
            ETipoParametro.TRIMENU,
            ETipoParametro.GESTION
        };

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvParametro(IControladorEditable<Parametro> controlador) : base(controlador) {
            try {
                InitializeComponent();

                // esto evita el forzado de mayusculas dentro del panel
                _forzarMayusculas = false;
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
                cargarControles();
                cargarDatos();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboClase();
            cargarComboTipo();
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtClave.Text = _objeto.Clave;
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtValorString.Text = _objeto.Valorstring;
                ctrlTxtValorChar.Text = _objeto.Valorchar.ToString();
                // Números
                ctrlTxtOrden.Text = _objeto.Orden.ToString();
                ctrlTxtValorLong.Text = _objeto.Valorlong.ToString();
                ctrlTxtValorDouble.Text = _objeto.Valordouble.ToString();
                // Booleanos
                ctrlChkValorBool.Checked = _objeto.Valorbool;
                // Fechas
                ctrlValorFecha.Value = _objeto.Valordate;
                txtValorFecha.Text = (ctrlValorFecha.Value <= Fechas.FechaNull)
                                         ? ""
                                         : ctrlValorFecha.Value.ToString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            return !((_objeto.Clave ?? "") == ctrlTxtClave.Text
                     && (_objeto.Nombre ?? "") == ctrlTxtNombre.Text
                     && (_objeto.Valorstring ?? "") == ctrlTxtValorString.Text
                     && ((_objeto.Valorchar.ToString() ?? string.Empty) == ctrlTxtValorChar.Text)
                     && _objeto.Valorbool == ctrlChkValorBool.Checked
                     && _objeto.Valorlong == Convert.ToInt64(ctrlTxtValorLong.Text)
                     && _objeto.Valordouble == Convert.ToDouble(ctrlTxtValorDouble.Text)
                     && ctrlValorFecha.Value == _objeto.Valordate
                     && (EClaseParametro) ctrlTxtComboClase.SelectedItem == _objeto.Clase
                     && (ETipoParametro) ctrlTxtComboTipo.SelectedItem == _objeto.Tipo);
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Clase = (EClaseParametro) ctrlTxtComboClase.SelectedItem;
                _objeto.Tipo = (ETipoParametro) ctrlTxtComboTipo.SelectedItem;
                _objeto.Clave = ctrlTxtClave.Text;
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Orden = Convert.ToInt64(ctrlTxtOrden.Text);
                _objeto.Valorbool = ctrlChkValorBool.Checked;
                _objeto.Valorchar = (ctrlTxtValorChar.Text == null || ctrlTxtValorChar.Text.Equals(""))
                                        ? new char()
                                        : Convert.ToChar(ctrlTxtValorChar.Text.Substring(0, 1));
                _objeto.Valordate = ctrlValorFecha.Value;
                _objeto.Valorlong = Convert.ToInt64(ctrlTxtValorLong.Text);
                _objeto.Valordouble = Convert.ToDouble(ctrlTxtValorDouble.Text);
                _objeto.Valorstring = ctrlTxtValorString.Text;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region helpers
        /// <summary>
        /// Este método carga el combo de las Formas de Parametro. 
        /// Podría lanzar una VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboClase() {
            ctrlTxtComboClase.Items.Clear();
            try {
                foreach (EClaseParametro p in _listaClase) {
                    ctrlTxtComboClase.Items.Add(p);

                    if (_objeto.Clase.Equals(p))
                        ctrlTxtComboClase.SelectedItem = p;
                }

                if (ctrlTxtComboClase.SelectedItem == null && ctrlTxtComboClase.Items.Count >= 1)
                    ctrlTxtComboClase.SelectedItem = ctrlTxtComboClase.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método carga el combo de tipo de recibo.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipo() {
            ctrlTxtComboTipo.Items.Clear();
            try {
                foreach (ETipoParametro p in _listaTipo) {
                    ctrlTxtComboTipo.Items.Add(p);

                    if (_objeto.Tipo.Equals(p))
                        ctrlTxtComboTipo.SelectedItem = p;
                }

                if (ctrlTxtComboTipo.SelectedItem == null && ctrlTxtComboTipo.Items.Count >= 1)
                    ctrlTxtComboTipo.SelectedItem = ctrlTxtComboTipo.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion helpers

        #region interfase
        /// <summary>
        /// Este netodo responde al evento de cambio en el valor del
        /// control asociado a Valordate del parámetro.
        /// </summary>
        /// <param name="sender">
        /// El objeto que lanza el evento.
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado.
        /// </param>
        private void ctrlValorFecha_ValueChanged(object sender, EventArgs e) {
            string fecha = (ctrlValorFecha.Value <= Fechas.FechaNull)
                               ? DateTime.Now.ToString()
                               : ctrlValorFecha.Value.ToString();

            if (!txtValorFecha.Text.Equals(fecha))
                txtValorFecha.Text = fecha;
        }
        #endregion interfase
    }
}