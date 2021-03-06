﻿///////////////////////////////////////////////////////////
//  WinCargaResultado.cs
//  Implementation of the Class WinCargaResultado.
//  Generated by Fito
//  Created on:      13-abr-2009 17:23:41
//  Original author: Fito
///////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuListaGestion {
    public partial class WinCargaResultado : Form {
        public Parametro Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Constructor que inicializa los componentes internos.
        /// </summary>
        public WinCargaResultado() {
            InitializeComponent();
            cargarComboResultado();
            cargaFecha();
            Tipo = null;
            Descripcion = null;
            Fecha = Fechas.FechaNull;
        }

        /// <summary>
        /// Este método inicializa la fecha del resultado.
        /// </summary>
        private void cargaFecha() {
            ctrlFechaRes.Value = DateTime.Now;
            ctrlTxtResFecha.Text = ctrlFechaRes.Value.ToString();
        }

        /// <summary>
        /// Este método carga el combo de tipos de resultados.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboResultado() {
            ctrlTxtComboResultado.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "RESULTADOGESTION")))
                    ctrlTxtComboResultado.Items.Add(p);

                if (ctrlTxtComboResultado.SelectedItem == null && ctrlTxtComboResultado.Items.Count >= 1)
                    ctrlTxtComboResultado.SelectedItem = ctrlTxtComboResultado.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Close();
            }
        }

        /// <summary>
        /// Implementación del método que verifica los datos cargados.
        /// </summary>
        public void verify(params object[] parametros) {
            string campo = "La Descripción de la Gestión es obligatoria";
            if (string.IsNullOrEmpty(Descripcion))
                throw new DataErrorException("CAMPO-NOK", campo + Mensaje.TERMINADOR);

            campo = "El Resultado de la Gestión es obligatorio";
            if (Tipo == null)
                throw new DataErrorException("CAMPO-NOK", campo + Mensaje.TERMINADOR);

            campo = "La Fecha Indicada para el Resultado de la Gestión es obligatoria para este Resultado";
            if (Tipo.Valorstring != null && Fecha == Fechas.FechaNull)
                throw new DataErrorException("CAMPO-NOK", campo + Mensaje.TERMINADOR);
        }

        #region interfase
        /// <summary>
        /// Este método se ejecuta cuando se presiona el botón aceptar y
        /// arma la gestion para que sea tomada desde la ventana llamante.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param> 
        private void btnAceptar_Click(object sender, EventArgs e) {
            try {
                Descripcion = ctrlTxtDescripcion.Text;
                Tipo = (Parametro) ctrlTxtComboResultado.SelectedItem;
                Fecha = ctrlFechaRes.Value;
                verify();
                Close();
            } catch (Exception ex) {
                throw new DataErrorException("DATA-SAVENOK", ex.ToString());
            }
        }

        /// <summary>
        /// Este método responde al cambio de fecha del resultado desde el 
        /// datetimepicker. Debería 'mostrar' cualquier error que ocurriese 
        /// y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFechaRes_ValueChanged(object sender, EventArgs e) {
            string fecha = (ctrlFechaRes.Value <= Fechas.FechaNull)
                               ? ""
                               : ctrlFechaRes.Value.ToString();

            if (!ctrlTxtResFecha.Text.Equals(fecha))
                ctrlTxtResFecha.Text = fecha;
        }

        /// <summary>
        /// Este método responde al cambio de fecha del resultado desde el 
        /// propio campo. Debería 'mostrar' cualquier error que ocurriese y 
        /// no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtResFecha_Validated(object sender, EventArgs e) {
            DateTime fecha = Convert.ToDateTime(ctrlTxtResFecha.Text);
            if (ctrlFechaRes.Value != fecha)
                ctrlFechaRes.Value = fecha;
        }

        /// <summary>
        /// Este método responde al cambio del tipo de resultado de la gestion
        /// para verificar si debe o no mostrar una fecha asociada. Debería 
        /// 'mostrar' cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtComboResultado_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlTxtComboResultado.SelectedItem != null) {
                var tipores = (Parametro) ctrlTxtComboResultado.SelectedItem;
                if (tipores.Valorstring != null && !tipores.Valorstring.Equals("")) {
                    label12.Visible = true;
                    label12.Text = tipores.Valorstring;
                    ctrlFechaRes.Visible = true;
                    ctrlTxtResFecha.Visible = true;
                } else {
                    label12.Visible = false;
                    ctrlFechaRes.Visible = false;
                    ctrlFechaRes.Value = Fechas.FechaNull;
                    ctrlTxtResFecha.Text = "";
                    ctrlTxtResFecha.Visible = false;
                }
            }
        }
        #endregion interfase
    }
}