﻿///////////////////////////////////////////////////////////
//  IControladorListable.cs
//  Implementation of the Interface IControladorListable
//  Generated by Enterprise Architect
//  Created on:      15-Abr-2009 07:11:10 p.m.
//  Original author: Fito
///////////////////////////////////////////////////////////
using System.Windows.Forms;

namespace scioControlLibrary.interfaces {
    /// <summary>
    /// Interfase que hereda de IControladorCasoUso y representa el comportamiento 
    /// deseable de una clase que gestiona y controla alguan una lista de opciones 
    /// administrables desde un Tree (básicamente desde WinTreeConfig). En realidad
    /// ha sido creada para poder utilizar las clases parametrizadas desde un entorno
    /// totalmente dinámico (cuando encuentre una forma mejor, lo cambio!!!!).
    /// </summary>
    public interface IControladorListTree {
        /// <summary>
        /// Este método es el encargado de generar, y devolver, dos controles 
        /// de usuario que se colocará dentro del sector del panel de listado 
        /// y del panel preview del Tree, asegurandose de crear tambien dicho
        /// panel de preview, all esto porque en un tree, un panel de listado 
        /// (casi) siempre tiene un preview.
        /// </summary>
        /// <returns>
        /// Un arreglo con dos controles de usuario para el panel de listado
        /// y el panel de preview.
        /// </returns>
        UserControl[] getPanelesTree();

        /// <summary>
        /// Este método se debería lanzar al mostrar un componente visual
        /// asociado al ControladorListTree para que este ejecute lo que 
        /// considere necesario.
        /// </summary>
        void alMostrar(params object[] parametros);

        /// <summary>
        /// Este método se debería lanzar al ocultar un componente visual
        /// asociado al ControladorListTree para que este ejecute lo que 
        /// considere necesario.
        /// </summary>
        void alOcultar(params object[] parametros);
    }
}