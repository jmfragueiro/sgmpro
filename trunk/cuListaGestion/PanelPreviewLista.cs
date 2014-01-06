///////////////////////////////////////////////////////////
//  PanelPreviewLista.cs
//  Implementación del panel preview para la entidad Lista 
//  de Gestión de la aplicación.
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
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.criterios;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.gestion;

namespace cuListaGestion {
    public partial class PanelPreviewLista : PanelPreview<ListaGestion> {
        private readonly Parametro _descartada = Parametros.GetByClave("ESTADOGESTION.DESCARTADA");
        private readonly Parametro _creada = Parametros.GetByClave("ESTADOGESTION.CREADA");

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelPreviewLista(IControladorEditable<ListaGestion> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                Sistema.Controlador.logear("PANEL-NOK", ENivelMensaje.ERROR, e.ToString());
                throw new VistaErrorException("PANEL-NOK");
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Textos
                txtDescripcion.Text = _objeto.Descripcion;
                txtNombre.Text = _objeto.Nombre;
                // Clases
                if (_objeto.TipoLista != null)
                    txtTipo.Text = _objeto.TipoLista.ToString();
                // Fechas
                txtFechaUMod.Text = (_objeto.FchCreacion <= Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FchCreacion.ToString();
                txtFechaCierre.Text = (_objeto.FechaBaja <= Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FechaBaja.ToString();
                // Resumen
                cargarResumen();
            } catch (Exception e) {
                Sistema.Controlador.logear("DATA-LOADNOK", ENivelMensaje.ERROR, e.ToString());
                throw new DataErrorException("DATA-LOADNOK");
            }
        }

        // Este método carga los valores de resumen de la lista
        private void cargarResumen() {
            long cgf = (long)RepositorioGenerico<Gestion>.GetAggByCriteria(
                false,
                EFuncionAgregacion.COUNT,
                "Id",
                new[] {Criterios.Igual("Lista", _objeto), 
                       Criterios.Distinto("Estado", _descartada),
                       Criterios.Distinto("Estado", _creada)});
            txtEjecutadas.Text = cgf.ToString();
        }
    }
}