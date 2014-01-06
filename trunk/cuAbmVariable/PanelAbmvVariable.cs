///////////////////////////////////////////////////////////
//  PanelAbmvVariable.cs
//  Implementación del panel ABMV para la entidad Variable
//  de la aplicación.
//  Generated Manualmente
//  Created on:      01-sep-2009 12:00:00
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmVariable {
    /// <summary>
    /// Implementación del panel ABMV para la
    /// entidad Variable de la aplicación.
    /// </summary>
    public partial class PanelAbmvVariable : PanelABMV<Variable> {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvVariable(IControladorEditable<Variable> controlador) : base(controlador) {
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
                // Textos
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtValor.Text = _objeto.Valor;
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtDescripcion.Text == _objeto.Descripcion
                         && ctrlTxtNombre.Text == _objeto.Nombre
                         && ctrlTxtValor.Text == _objeto.Valor);
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Valor = ctrlTxtValor.Text;
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }
        #endregion
    }
}