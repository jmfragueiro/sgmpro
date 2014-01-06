///////////////////////////////////////////////////////////
//  WinSetParametros.cs
//  Implementación de la ventana de selección de elementos
//  de configuración.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioToolLibrary.enums;

namespace scioControlLibrary {
    public partial class WinSet<T> : Form {
        private readonly IList<T> _iniConfigurados;
        private readonly IList<T> _iniDisponibles;
        public IList<T> Disponibles;
        public IList<T> Configurados;

        /// <summary>
        /// Constructor que inicializa los componentes internos.
        /// </summary>
        /// <param name="dispos">
        /// El conjunto de elementos disponibles para configurar.
        /// </param>
        /// <param name="configs">
        /// El conjunto de elementos ya configurados y que sera 
        /// afectado a la salida de la configuración.
        /// </param>
        /// <param name="elem">
        /// El nombre del tipo de parámetro a trabajar (para títulos, etc.).
        /// </param>
        public WinSet(IList<T> dispos, IList<T> configs, string elem) {
            try {
                InitializeComponent();

                Configurados = new List<T>();
                Disponibles = new List<T>();

                if (elem != null) {
                    label2.Text = elem + " disponibles:";
                    label3.Text = elem + " configurados:";
                }

                _iniDisponibles = dispos;
                _iniConfigurados = configs;

                iniciarListados();
                refrescarListados();
            } catch (Exception e) {
                Sistema.Controlador.mostrar("VISTA-SELECT-NOK", ENivelMensaje.ERROR, e.ToString(), false);
                throw new VistaErrorException("VISTA-SELECT-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método refresca los listados tanto de disponibles como de 
        /// configurados relistando todos los elementos que poseen actualmente.
        /// </summary>
        private void iniciarListados() {
            try {
                Disponibles.Clear();
                if (_iniDisponibles != null)
                    foreach (T o in _iniDisponibles)
                        if (!_iniConfigurados.Contains(o))
                            Disponibles.Add(o);

                Configurados.Clear();
                if (_iniConfigurados != null)
                    foreach (T o in _iniConfigurados)
                        Configurados.Add(o);
            } catch (Exception e) {
                Sistema.Controlador.mostrar("VISTA-SELECT-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Close();
            }
        }

        /// <summary>
        /// Este método refresca los listados tanto de disponibles como de 
        /// configurados relistando todos los elementos que poseen actualmente.
        /// </summary>
        private void refrescarListados() {
            listDisponibles.Items.Clear();
            foreach (object o in OrdenarPorNombre(Disponibles))
                listDisponibles.Items.Add(o);
            listDisponibles.Refresh();

            listConfigurados.Items.Clear();
            foreach (object o in OrdenarPorNombre(Configurados))
                listConfigurados.Items.Add(o);
            listConfigurados.Refresh();
        }

        /// <summary>
        /// Este método responde al botón Agregar. Debería 'mostrar' cualquier
        /// error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnAgregar_Click(object sender, EventArgs e) {
            try {
                if (listDisponibles.SelectedItems.Count > 0) {
                    foreach (T item in listDisponibles.SelectedItems) {
                        Configurados.Add(item);
                        Disponibles.Remove(item);
                    }
                    refrescarListados();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-SETADD-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al doble-click en la lista de disponibles
        /// y agerga lo seleccionado a configurado. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna 
        /// excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void listDisponibles_DoubleClick(object sender, EventArgs e) {
            btnAgregar_Click(sender, e);
        }

        /// <summary>
        /// Este método responde al botón Agregar Todos. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnAgregarTodo_Click(object sender, EventArgs e) {
            try {
                bool cambio = false;
                foreach (object o in listDisponibles.Items) {
                    Configurados.Add((T) o);
                    Disponibles.Remove((T) o);
                    cambio = true;
                }
                if (cambio)
                    refrescarListados();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-SETADD-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Remover. Debería 'mostrar' cualquier
        /// error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnQuitar_Click(object sender, EventArgs e) {
            try {
                if (listConfigurados.SelectedItems.Count > 0) {
                    foreach (T item in listConfigurados.SelectedItems) {
                        Disponibles.Add(item);
                        Configurados.Remove(item);
                    }
                    refrescarListados();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-SETDEL-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al doble-click en la lista de configurados
        /// y agerga lo seleccionado a disponibles. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna 
        /// excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void listConfigurados_DoubleClick(object sender, EventArgs e) {
            btnQuitar_Click(sender, e);
        }

        /// <summary>
        /// Este método responde al botón Remover Todos. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnQuitarTodo_Click(object sender, EventArgs e) {
            try {
                bool cambio = false;
                foreach (object o in listConfigurados.Items) {
                    Disponibles.Add((T) o);
                    Configurados.Remove((T) o);
                    cambio = true;
                }
                if (cambio)
                    refrescarListados();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-SETDEL-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Listo. Debería 'mostrar' cualquier
        /// error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnListo_Click(object sender, EventArgs e) {
            if (_iniConfigurados != null) {
                _iniConfigurados.Clear();

                foreach (object o in Configurados)
                    _iniConfigurados.Add((T) o);
            }

            Sistema.Controlador.mostrar("DATA-SAVEOK", ENivelMensaje.INFORMACION, null, false);
            Close();
        }

        /// <summary>
        /// Este método responde al botón Reiniciar. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna 
        /// excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnReiniciar_Click(object sender, EventArgs e) {
            iniciarListados();
            refrescarListados();
        }

        /// <summary>
        /// Este método ordena un conjunto de objetos según 
        /// su resultado de ToString y en forma ascendente.
        /// </summary>
        /// <param name="origen">
        /// El conjunto de objetos a ordenar.
        /// </param>
        /// <returns>
        /// El conjunto de objetos ordenado por ToString.
        /// </returns>
        public static IList<T> OrdenarPorNombre(IList<T> origen) {
            T temp = default(T);
            IList<T> conjunto = new List<T>();

            while (conjunto.Count < origen.Count) {
                string piso = "ZZZZZZ";
                foreach (T obj in origen)
                    if (!conjunto.Contains(obj))
                        if (obj.ToString().CompareTo(piso) <= 0) {
                            piso = obj.ToString();
                            temp = obj;
                        }
                conjunto.Add(temp);
            }

            return conjunto;
        }

        /// <summary>
        /// Este método responde la presión de cualquier tecla y debería
        /// ejecutar una acción si es una tecla de función la presionada. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void WinSetParametro_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.F10:
                    if (btnListo.Visible)
                        btnListo_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        /// <summary>
        /// Este método responde al click del botón closer de la ventnana
        /// para cerrar la misma ante una presión de ESC.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnCloser_Click(object sender, EventArgs e) {
            Close();
        }
    }
}