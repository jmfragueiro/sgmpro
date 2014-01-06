///////////////////////////////////////////////////////////
//  PanelPreviewVariable.cs
//  Implementación del panel ABMV para la entidad Variable
//  de la aplicación.
//  Generated Manualmente
//  Created on:      01-sep-2009 12:00:00
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmVariable {
    /// <summary>
    /// Implementación del panel ABMV para la
    /// entidad Variable de la aplicación.
    /// </summary>
    public partial class PanelGUIVariable: UserControl
    {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelGUIVariable()
        {
            try {
                InitializeComponent();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }
        
    }
}