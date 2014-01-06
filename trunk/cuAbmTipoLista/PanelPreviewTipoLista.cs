///////////////////////////////////////////////////////////
//  PanelAbmvTipoLista.cs
//  Implementación del panel ABMV para la entidad 
//  TipoListaGestion de la aplicación.
//  Generated Manualmente
//  Created on:      01-sep-2009 12:00:00
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioToolLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmTipoLista {
    public partial class PanelPreviewTipoLista : PanelPreview<TipoListaGestion> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewTipoLista(IControladorEditable<TipoListaGestion> controlador) : base(controlador) {
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
                // Textos
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                txtMaxCuentas.Text = _objeto.MaxCuentas.ToString();
                ctrlTxtPerfil.Text = _objeto.Perfil.Nombre;
                txtTipoGestion.Text = _objeto.TipoGestion.ToString();
                txtCtdadEstrategias.Text = _objeto.ListaEstrategias.Count.ToString();
                txtCtdadEntidades.Text = _objeto.ListaEntidades.Count.ToString();
                txtPrioridad.Text = _objeto.Prioridad.ToString();
                // Boleanos
                chkElegibilidad.Checked = _objeto.Elegibilidad;
                chkPendientes.Checked = _objeto.Pendiente;
                chkEstados.Checked = _objeto.Cancelacion;
                // Fechas
                txtFechaAlta.Text = (_objeto.FechaAlta <= Fechas.FechaNull)
                                        ? string.Empty
                                        : _objeto.FechaAlta.ToShortDateString();
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }
    }
}