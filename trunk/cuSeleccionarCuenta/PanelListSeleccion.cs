///////////////////////////////////////////////////////////
//  PanelListSeleccion.cs
//  Implementación del panel de listado para la seleccion
//  manual de cuenta a gestionar.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;

namespace cuSeleccionarCuenta {
    public partial class PanelListSeleccion<T> : PanelListABMV<T> where T : EntidadIdentificada<T> {
        /// <summary>
        /// Constructor de la clase que primero ejecuta la inicialización
        /// por defecto y luego asigna el controlador y panel asociado al 
        /// listado (para agregar, mostrar, editar o borrar). Debería lanzar 
        /// una VistaErrorExcetion si hay un problema.
        /// </summary>
        /// <param name="controlador">
        /// El objeto controlador de la ventana.
        /// </param>
        public PanelListSeleccion(IControladorListable<T> controlador) : base(controlador) {}

        /// <summary>
        /// Este método es llamado cuando se presiona enter sobre el listado.
        /// esta creado para que reaccione de alguna forma, por defecto es
        /// como si fuera un doble click, pero el método puede ser sobrepasado.
        /// </summary>
        protected override void alPresionarEnter() {}
    }
}