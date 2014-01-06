///////////////////////////////////////////////////////////
//  PanelPreview.cs
//  Implementación del padre de todos los paneles Preview.
//  de la aplicación
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;
using scioThirdPartLibrary;
using scioToolLibrary;

namespace scioControlLibrary {
    /// <summary>
    /// Esta clase representa un panel de Preview genérico. Se espera que subclases 
    /// (necesarias porque la clase es abstracta) carguen el att _objeto conteniendo
    /// el objeto que se previsualiza y que se setearía en la implementación interna
    /// del método setearObjeto(T).
    /// </summary>
    public abstract partial class PanelPreview<T> : UserControl where T : EntidadIdentificada<T> {
        /// <summary>
        /// Este atributo debería utilizarse para marcar el tiempo en que
        /// el panel se encuentra bajo seteos iniciales (como el setearObjeto)
        /// de manera de que si no deben ejecutarse ciertas acciones en ese
        /// lapzo, se pueda saber cuándo empieza y cuándo termina. Debería
        /// setearse dentro de setearObjeto.
        /// </summary>
        protected bool _enSeteo;
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
        /// Debería lanzar VistaErrorExcetion si hay un problema.
        /// </summary>     
        protected PanelPreview(IControladorEditable<T> controlador) {
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
        /// Este método actúa como un wrapper de setObjeto() a efectos de
        /// establecer el flag _enSeteo que permite saber si el panel esta
        /// bajo un proceso de seteo inicial, de manera de no ejecutar o
        /// repetir ciertas acciones que puedan darse en ese estado. Este
        /// es el método que debe ser llamado siempre desde afuera.
        /// </summary>
        /// <param name="objeto">
        /// El objeto cuyos datos se pasan al método setObjeto().
        /// </param>  
        public void setearObjeto(T objeto) {
            setClear();
            if (objeto != null) {
                _enSeteo = true;
                _objeto = objeto;
                postSetObjeto();
                _enSeteo = false;
            }
            setNoEditable();
        }

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
        protected virtual void postSetObjeto() {
            try {
                cargarDatos();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método se debe encargar de cargar en el panel los datos
        /// propios del objeto con el que se está trabajando. Estos son
        /// los controles de texto y checkboxes, etc. Los combos deberían
        /// quedar seleccionados desde el método 'cargarControles()'. Se
        /// debería lanzar una VistaErrorExcetion si hay algún problema.
        /// </summary>
        public abstract void cargarDatos();

        /// <summary>
        /// Este método es el encargado de colocar a todos los
        /// compenentes en modo solo lectura, evitando modificar
        /// sus datos. Algo que se puede poner ReadOnly debe
        /// tener un nombre de control que comienza con 'ctrl'.
        /// Debería lanzar una VistaErrorException si hay problemas.
        /// </summary>
        public void setNoEditable() {
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
    }
}