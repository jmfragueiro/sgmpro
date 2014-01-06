﻿///////////////////////////////////////////////////////////
//  CollectionHelper.cs
//  Implementation of the Class CollectionHelper
//  Generated by Enterprise Architect
//  Created on:      08-abr-2009 11:32:54
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace scioToolLibrary {
    /// <summary>
    /// Esta es una clase helper que implementa el concepto de conversor 
    /// de colecciones, para transofrmaciones entre IList y DataTable que
    /// puedan ser encesarias por el uso de grillas en el sistema. 
    /// </summary>
    public class CollectionHelper {
        /// <summary>
        /// Este método tranforma un IList en un DataTable con la estructura
        /// de la clase T pasada como argumento de clase (cada columna es un
        /// atributo).
        /// </summary>
        public static DataTable ConvertTo<T>(IList<T> list) {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (T item in list) {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item);
                table.Rows.Add(row);
            }
            return table;
        }

        /// <summary>
        /// Este método tranforma un DataTable en un IList de la clase T pasada 
        /// como argumento de clase y suponiendo que la estructura de la clase T 
        /// esta respetada en el DataTable (cada columna es un atributo). Si no 
        /// es así, algunos atributos quedaran sin valores y/o algunas columnas 
        /// se perderán.
        /// </summary>
        public static IList<T> ConvertTo<T>(DataTable table) {
            if (table == null) return null;
            List<DataRow> rows = new List<DataRow>();
            foreach (DataRow row in table.Rows)
                rows.Add(row);
            return ConvertTo<T>(rows);
        }

        /// <summary>
        /// Este método tranforma un conjuto de filas de un DataTable (un IList
        /// de DataRow en un IList de la clase T pasada como argumento de clase
        /// y suponiendo que la estructura de la clase T esta respetada en las 
        /// filas pasadas (cada columna es un atributo). Si no es así, algunos
        /// atributos quedaran sin valores y/o algunas columnas se perderán.
        /// </summary>
        public static IList<T> ConvertTo<T>(IList<DataRow> rows) {
            IList<T> list = null;
            if (rows != null) {
                list = new List<T>();
                foreach (DataRow row in rows) {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }
            return list;
        }

        /// <summary>
        /// Este método crea un objeto de la clase T pasada como argumento de 
        /// clase a partir de una fila de un DataTable (un Datarow) y suponiendo 
        /// que la estructura de la clase T esta respetada en dicho DataRow (cada 
        /// columna es un atributo). Si no es así, algunos atributos quedaran sin 
        /// valores y/o algunas columnas se perderán.
        /// </summary>
        public static T CreateItem<T>(DataRow row) {
            T obj = default(T);
            if (row != null) {
                obj = Activator.CreateInstance<T>();
                foreach (DataColumn column in row.Table.Columns) {
                    PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);

                    object value = row[column.ColumnName];
                    prop.SetValue(obj, value, null);
                }
            }
            return obj;
        }

        /// <summary>
        /// Este método crea un DataTable con la estructura de una clase T pasada 
        /// como argumento de clase, donde cada columna es un atributo de la clase.
        /// </summary>
        public static DataTable CreateTable<T>() {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, prop.PropertyType);

            return table;
        }
    }
}