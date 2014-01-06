///////////////////////////////////////////////////////////
//  PanelAbmvExes.cs
//  Implementación del panel ABMV para la entidad Ejecución
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.scheduler;

namespace cuGenerarJobs {
    public partial class PanelAbmvExes : PanelABMV<Ejecucion> {
        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvExes(IControladorEditable<Ejecucion> controlador) : base(controlador) {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        protected override void postSetObjeto() {
            cargarDatos();
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                txtJob.Text = _objeto.Job.ToString();
                txtInicio.Text = _objeto.Inicio.ToString();
                txtFin.Text = _objeto.Fin.ToString();
                txtResultado.Text = _objeto.Resultado;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            return false;
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {}
        #endregion
    }
}