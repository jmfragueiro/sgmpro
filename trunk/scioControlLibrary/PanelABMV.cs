///////////////////////////////////////////////////////////
//  PanelABMV.cs
//  Implementación del padre de todos los paneles ABMV.
//  de la aplicación
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.interfases;
using scioSecureLibrary.enums;
using scioSecureLibrary.excepciones;
using scioThirdPartLibrary;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace scioControlLibrary {
    /// <summary>
    /// Esta clase representa un panel de ABMV genérico. Se espera que las subclases 
    /// (necesarias porque la clase es abstracta) manejen el att _objeto conteniendo
    /// el objeto bajo tratamiento y que se setearía en la implementación del método 
    /// setearObjeto(T).
    /// </summary>
    public abstract partial class PanelABMV<T> : UserControl, IVistaPanelAbmv where T : EntidadIdentificada<T> {
        /// <summary>
        /// Este atributo debería utilizarse para marcar el tiempo en que
        /// el panel se encuentra bajo procesos especiales, como seteos 
        /// iniciales (como setearObjeto) de manera de que si mientras eso
        /// sucede no deben ejecutarse ciertas acciones específicas, se 
        /// pueda saber cuándo empieza y cuándo termina. 
        /// </summary>
        protected bool _enProceso;
        /// <summary>
        /// Este atributo establece si se pasan a mayusculas todos los 
        /// campos de texto del panel, para que toda entrada quede en
        /// mayusculas. Esto incluso impacta cuando se esta editando
        /// algo que ya fue creado (sube todos a mayusculas). Para 
        /// evitar éste forzado hay que poner en falso el atributo.
        /// </summary>
        protected bool _forzarMayusculas = true;
        /// <summary>
        /// En contenedor del panel actual.
        /// </summary>
        public IVistaContenedor Contenedor {
            get {
                if (_contenedor == null)
                    throw new VistaErrorException("VISTA-NO-PARENT");
                return _contenedor;
            }
            set { _contenedor = value; }
        }
        protected IVistaContenedor _contenedor;
        /// <summary>
        /// Controlador asociado al panel de edición, es decir aquel que
        /// maneja la capa de negocio utilizando a éste panel como vista.
        /// </summary>
        protected IControladorEditable<T> _controlador;
        /// <summary>
        /// Este atributo contiene al objeto que se está trabajando dentro
        /// del panel. Debería ser reemplazada en las subclases por el que
        /// tenga la clase de objeto que se desea.
        /// </summary>
        protected T _objeto;

        /// <summary>
        /// Constructor de clase que inicializa componentes visuales.
        /// Debería lanzar VistaErrorException si hay un problema.
        /// </summary>     
        protected PanelABMV(IControladorEditable<T> controlador) {
            try {
                InitializeComponent();
                _controlador = controlador;
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método devuelve el controlador asociado a la instancia.
        /// </summary>
        /// <returns>
        /// El controlador asociado al panel de edición.
        /// </returns>
        public IControladorEditable<T> getControlador() {
            return _controlador;
        }

        /// <summary>
        /// Este método actúa como un wrapper a la accion de setear el objeto
        /// dentro del panel, a efectos de generar un entorno de mensajes pre
        /// y post y de establecer el flag _enSeteo, que permite saber si el 
        /// panel está bajo un proceso de seteo inicial, de manera de no dejar
        /// ejecutar o repetir ciertas acciones que puedan darse en ese estado.
        /// Este es el método que debe ser llamado siempre desde afuera.
        /// NOTA: !!!SIEMPRE!!! ESTE MÉTODO REALIZA UN REFRESH DEL OBJETO CONTRA 
        /// LA BASE DE DATOS PARA ASEGURARSE DE QUE LO QUE SE ESTA VIENDO ES LO 
        /// ULTIMO (OJO SI SE ESTA MODIFICANDO EL OBJETO EN MEMORIA Y NO GRABO).
        /// </summary>
        /// <param name="objeto">
        /// El objeto cuyos datos se pasan al método setObjeto().
        /// </param>  
        public void setearObjeto(IEntidadIdentificable objeto) {
            if (!(objeto is T))
                throw new VistaErrorException("PANEL-SETOBJECT-NOK", _controlador.getTitulo());

            _enProceso = true;

            aplicarPermisos(this);
            setClear();

            preSetObjeto();
            _objeto = (T)objeto;
            _objeto.refrescar();
            postSetObjeto();

            _enProceso = false;
        }

        /// <summary>
        /// Este método debería limpiar las cosas particulares del panel 
        /// antes realizarse la asignación del nuevo objeto al mismo.
        /// </summary> 
        protected virtual void preSetObjeto() {}

        /// <summary>
        /// Este método debe asignar el objeto que se trabaja desde el 
        /// panel e inicializar el mismo cargando los controles y datos
        /// de este. Las subclases de PanelABMV podrían castear el arg
        /// a una clase específica para el panel heredado. Es además, si 
        /// es que existen tabs, el método encargado de asignar el atrib
        /// ObjetoMaster de las clases CUList... asociadas a los tabs del 
        /// panel (para que se pueda filtrar por dicho objeto). Este es
        /// el m;etodo que podría utilziarse desde adentro del panel si
        /// no existe necesidad de actualizar el flag _enSeteo.
        /// </summary> 
        protected abstract void postSetObjeto();

        /// <summary>
        /// Este método se debe encargar de cargar los controles comunes 
        /// necesarios para dejar al panel presentable y que dependen de
        /// parametros de la base de datos del sistema (como combos tipo
        /// 'EstadoCivil').Se recomienda que en los combos se establezca
        /// desde aqui el valor seleccionado, según el valor que posee el
        /// objeto con el que se está trabajando. Debería lanzarse una 
        /// VistaErrorException si hay algún problema.
        /// </summary>
        public virtual void cargarControles() {}

        /// <summary>
        /// Este método se debe encargar de cargar en el panel los datos
        /// propios del objeto con el que se está trabajando. Estos son
        /// los controles de texto y checkboxes, etc. Los combos deberían
        /// quedar seleccionados desde el método 'cargarControles()'. Se
        /// debería lanzar una VistaErrorExcetion si hay algún problema.
        /// </summary>
        public abstract void cargarDatos();

        /// <summary>
        /// Este método se debe encargar de cargar en el panel los tabs
        /// de listados con información asociada al objeto con el que se 
        /// está trabajando. Se debería lanzar una VistaErrorExcetion si 
        /// hay algún problema.
        /// </summary>
        public virtual void cargarTabs() {}

        /// <summary>
        /// Este método se debe encargar de verificar los datos ingresados
        /// o editados en el panel, antes de guardarlos, para asegurar su 
        /// validez. Debería lanzar una AppErrorExcetion si hay problema o 
        /// si algún dato no pasa la validación. No lanza nada si hay algun
        /// problema porque se lo deja a la funcion de verify() de interfaz
        /// IControladorEditable (a quien debería llamar).
        /// </summary>
        public virtual void validarDatos() {
            _controlador.verify();
        }

        /// <summary>
        /// Este método se debe encargar de verificar si se han modificado
        /// datos en el panel respecto de los datos guardarlos en el objeto. 
        /// Debería lanzar una VistaErrorExcetion si hay problema.
        /// </summary>
        /// <returns>
        /// Retorna 'true' si se han modificado datos, o si no 'false'.
        /// </returns>
        public abstract bool isDirty();

        /// <summary>
        /// Este método se debe encargar de pasar los datos del panel al 
        /// objeto con el que se está trabajando. Se debería lanzar una 
        /// VistaErrorExcetion si hay problema.
        /// </summary>
        public abstract void actualizarObjeto();

        /// <summary>
        /// Este método debe encargarse de rearmar y verificar el
        /// objeto con el que se trabaja en el panel. Para ello se
        /// deben primero validar los datos ingresados/editados y, 
        /// si está ok, se cargan los datos en el objeto. 
        /// </summary>
        /// <returns>
        /// El objeto armado con los datos del panel.
        /// </returns>
        public virtual void refrescarDatos() {
            if (isDirty())
                actualizarObjeto();
            validarDatos();
        }

        /// <summary>
        /// Este método se encarga de devolver el objeto con el 
        /// que se trabaja en el panel (p/vista, edición, etc.). 
        /// </summary>
        /// <returns>
        /// El objeto con el que se trabaja dentro del panel.
        /// </returns>
        public T getObjeto() {
            return _objeto;
        }

        /// <summary>
        /// Este método es el encargado de colocar a todos los
        /// compenentes en modo solo lectura, evitando modificar
        /// sus datos. Algo que se puede poner ReadOnly debe
        /// tener un nombre de control que comienza con 'ctrl'.
        /// Debería lanzar una VistaErrorException si hay problemas.
        /// </summary>
        public virtual void setNoEditable() {
            try {
                foreach (Control ctrl in Controls)
                    if (ctrl.Name.StartsWith("ctrlTxt")) {
                        if (ctrl is TextBox)
                            ((TextBox)ctrl).ReadOnly = true;
                        else if (ctrl is ReadOnlyComboBox)
                            ((ReadOnlyComboBox)ctrl).ReadOnly = true;
                    } else if (ctrl.Name.StartsWith("ctrl"))
                        ctrl.Enabled = false;
                    else if (ctrl.Name.StartsWith("grp"))
                        foreach (Control ctrlgr in ctrl.Controls)
                            if (ctrlgr.Name.StartsWith("ctrlTxt")) {
                                if (ctrlgr is TextBox)
                                    ((TextBox)ctrlgr).ReadOnly = true;
                                else if (ctrlgr is ReadOnlyComboBox)
                                    ((ReadOnlyComboBox)ctrlgr).ReadOnly = true;
                            } else if (ctrlgr.Name.StartsWith("ctrl"))
                                ctrlgr.Enabled = false;
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método debe encargarse de colocar todos los controles
        /// en modo de edición, permitiendo así modificar sus datos. 
        /// CONVENCION: algo que se puede poner Editable debe tener un 
        /// nombre de control que comienza con 'ctrl'. Debería lanzar
        /// VistaErrorExcetion si hay algún problema.
        /// </summary>
        public virtual void setEditable() {
            try {
                foreach (Control ctrl in Controls)
                    if (ctrl.Name.StartsWith("ctrlTxt")) {
                        if (ctrl is TextBox)
                            ((TextBox)ctrl).ReadOnly = false;
                        else if (ctrl is ReadOnlyComboBox)
                            ((ReadOnlyComboBox)ctrl).ReadOnly = false;
                    } else if (ctrl.Name.StartsWith("ctrl"))
                        ctrl.Enabled = true;
                    else if (ctrl.Name.StartsWith("grp"))
                        foreach (Control ctrlgr in ctrl.Controls)
                            if (ctrlgr.Name.StartsWith("ctrlTxt")) {
                                if (ctrlgr is TextBox)
                                    ((TextBox)ctrlgr).ReadOnly = false;
                                else if (ctrlgr is ReadOnlyComboBox)
                                    ((ReadOnlyComboBox)ctrlgr).ReadOnly = false;
                            } else if (ctrlgr.Name.StartsWith("ctrl"))
                                ctrlgr.Enabled = true;
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método debe encargarse de colocar a todos los
        /// componentes en blanco ó en su estado inicial. Esto
        /// permite iniciar desde cero una modificación de datos.
        /// Debería lanzar VistaErrorExcetion si hay un problema.
        /// </summary>
        public void setClear() {
            try {
                foreach (Control ctrl in Controls)
                    if (ctrl is TextBox) {
                        ctrl.Text = "";
                        ctrl.Tag = null;
                        if (_forzarMayusculas)
                            if (((TextBox)ctrl).PasswordChar != '*')
                                ((TextBox)ctrl).CharacterCasing = CharacterCasing.Upper;
                    } else if (ctrl is ReadOnlyComboBox) {
                        ((ReadOnlyComboBox)ctrl).SelectedIndex = -1;
                        ctrl.Tag = null;
                    } else if (ctrl is DateTimePicker)
                        ((DateTimePicker)ctrl).Value = Fechas.FechaNull;
                    else if (ctrl is CheckBox)
                        ((CheckBox)ctrl).Checked = false;
                    else if (ctrl.Name.StartsWith("grp"))
                        foreach (Control ctrlgr in ctrl.Controls)
                            if (ctrlgr is TextBox) {
                                ctrlgr.Text = "";
                                ctrlgr.Tag = null;
                            } else if (ctrlgr is ReadOnlyComboBox) {
                                ((ReadOnlyComboBox)ctrlgr).SelectedIndex = -1;
                                ctrlgr.Tag = null;
                            } else if (ctrlgr is DateTimePicker)
                                ((DateTimePicker)ctrlgr).Value = Fechas.FechaNull;
                            else if (ctrlgr is CheckBox)
                                ((CheckBox)ctrlgr).Checked = false;
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region helpers
        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void aplicarPermisos(Control contenedor) {
            try {
                foreach (Control ctrl in contenedor.Controls)
                    if (ctrl is ScrollableControl
                        || ctrl is TabControl
                        || ctrl is GroupBox)
                        aplicarPermisos(ctrl);
                    else if (ctrl is Button && ctrl.Tag is string && ctrl.Tag.ToString().StartsWith("BOTON"))
                        if (!Sistema.Controlador.SecurityService
                                 .usuarioActualPoseePermiso((string)ctrl.Tag, ETipoPermiso.EJECUTAR))
                            ctrl.Visible = false;
            } catch (Exception e) {
                throw new SecurityErrorException("PANEL-NOK", e.ToString());
            }
        }
        #endregion helpers

        #region IVistaContenedor members
        /// <summary>
        /// Implementación de método de la interfaz.
        /// </summary>
        public virtual void setModoVista() {}

        /// <summary>
        /// Este método permite actualizar todos los datos del panel, pero
        /// sin tocar el objeto seteado, es decir que solamente recarga los
        /// controles (si hay), luego recarga los datos y luego recarga los 
        /// tabs (si hay).
        /// </summary>
        public virtual void actualizarDatos() {
            cargarControles();
            cargarDatos();
            cargarTabs();
        }

        /// <summary>
        /// Este método permite guardar los datos del panel sin la
        /// necesidad de cerrar la ventana (como se hace cuando se
        /// graba vía el botón del menú) y es para los casos en que 
        /// se quiere agregar un nuevo registro en un listado detail 
        /// de un panelABMV y todavía no se grabó el master que se 
        /// está agregando.
        /// </summary>
        public virtual void guardarDatos() {
            refrescarDatos();
            _controlador.save();
            Sistema.Controlador.mostrar("DATA-SAVEOK", ENivelMensaje.INFORMACION, null, false);
        }

        /// <summary>
        /// Este método es el que le dice al contenedor de una vista 
        /// que el usuario a determinado que la misma debe cerrarse.
        /// </summary>
        public void cerrar() {
            Contenedor.cerrar();
        }
        #endregion IVistaContenedor members
    }
}