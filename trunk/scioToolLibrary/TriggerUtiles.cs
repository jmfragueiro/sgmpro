using System;

namespace scioToolLibrary {
    /// <summary>
    /// Clase que contiene algunas funciones para el manejo de triggers
    /// </summary>
    public class TriggerUtiles {
        private static readonly string[] _dias = {
            "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN", 
            "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"
        };

        /// <summary>
        /// Devuelve el texto descriptivo de la periodicidad de ejecucion
        /// determinada por una cronexpression
        /// </summary>
        /// <param name="cronExpres">CronExpression</param>
        /// <returns>Texto descriptivo</returns>
        public static string CronExpresToDescri(string cronExpres) {
            /// <segundo> <minuto> <hora> <dia_del_mes> <mes> <dia_de_semana>
            string strDescri = string.Empty;

            string[] cron = cronExpres.Split(' ');
            string minuto = cron[1];
            string hora = cron[2];
            string diaMes = cron[3];
            string diaSemana = cron[5];

            /// Obtiene los dias de semana
            if (diaSemana != "?") strDescri = "Todos los " + diaSemana + ". ";
            else
                /// Dia del mes
                if (diaMes.Contains("C")) strDescri += "El primer día del mes. ";
                else if (diaMes.Contains("L")) strDescri += "El ultimo día del mes. ";
                else if (diaMes == "*") strDescri += "Todos los días. ";
                else strDescri += string.Format("El día {0} de cada mes .", diaMes);

            /// Obtiene los meseses (No implementado)

            /// Horas
            strDescri += string.Format("A las {0} horas, {1} minutos. ", hora, minuto);

            return strDescri;
        }

        /// <summary>
        /// Genera una CronExpression diaria (la ejecucion se repite todos los dias, 
        /// donde teniendo en cuenta el formato:
        /// ["segundo" "minuto" "hora" "dia_del_mes" "mes" "dia_de_semana"] quedara
        /// algo como [0, minuto, hora, "*", "*", "?"](dde [?] significa 'no aplica' 
        /// y [*] significa 'todos lod dias/meses'). 
        /// </summary>
        /// <param name="hora">Hora de ejecución</param>
        /// <param name="min">Minuto de ejecución</param>
        public static string ToCronExpresDiaria(string hora, string min) {
            // Controla en caso que uno de los valores venga vacío, los pone en '0'
            hora = (hora.Length == 0) ? "0" : hora;
            min = (min.Length == 0) ? "0" : min;

            // Arma la cron-expression con el siguiente formato:
            // <segundo> <minuto> <hora> <dia_del_mes> <mes> <dia_de_semana>
            return string.Format("{0} {1} {2} {3} {4} {5}", 0, min, hora, "*", "*", "?");
        }

        /// <summary>
        /// Genera una CronExpression semanal (la ejecucion se repite ciertos dias de 
        /// la semana), donde teniendo en cuenta el formato:
        /// ["segundo" "minuto" "hora" "dia_del_mes" "mes" "dia_de_semana"] quedara
        /// algo como [0, minuto, hora, "?", "*", diasSemana](dde [?] significa 'no
        /// aplica' y [*] significa 'todos los meses').        
        /// </summary>
        /// <param name="hora">Hora de ejecución</param>
        /// <param name="min">Minuto de ejecución</param>
        /// <param name="lun">Si se corre el Lunes</param>
        /// <param name="mar">Si se corre el Martes</param>
        /// <param name="mie">Si se corre el Miércoles</param>
        /// <param name="jue">Si se corre el Jueves</param>
        /// <param name="vie">Si se corre el Viernes</param>
        /// <param name="sab">Si se corre el Sabado</param>
        /// <param name="dom">Si se corre el Domingo</param>
        public static string ToCronExpresSemanal(
            string hora, string min, bool lun, bool mar, bool mie, bool jue, bool vie, bool sab, bool dom) {
            // Controla en caso que uno de los valores venga vacío, los pone en '0'
            hora = (hora.Length == 0) ? "0" : hora;
            min = (min.Length == 0) ? "0" : min;

            string diasSemana = string.Empty;
            if (lun) diasSemana += "MON,";
            if (mar) diasSemana += "TUE,";
            if (mie) diasSemana += "WED,";
            if (jue) diasSemana += "THU,";
            if (vie) diasSemana += "FRI,";
            if (sab) diasSemana += "SAT,";
            if (dom) diasSemana += "SUN,";

            // Si no se carga ningun dia toma el lunes
            if (diasSemana.Length == 0) diasSemana += "MON,";

            // Quita la ultima coma (,)
            diasSemana = diasSemana.Remove(diasSemana.Length - 1, 1);

            // Arma la cron-expression con el siguiente formato:
            // <segundo> <minuto> <hora> <dia_del_mes> <mes> <dia_de_semana>
            return string.Format("{0} {1} {2} {3} {4} {5}", 0, min, hora, "?", "*", diasSemana);
        }

        /// <summary>
        /// Genera una CronExpression mensual (la ejecucion se repite ciertos dias de 
        /// cada mes), donde teniendo en cuenta el formato:
        /// ["segundo" "minuto" "hora" "dia_del_mes" "mes" "dia_de_semana"] quedara
        /// algo como [0, minuto, hora, dias, "*", "?"](dde [?] significa 'no aplica' 
        /// y [*] significa 'todos los meses').
        /// </summary>
        /// <param name="hora">Hora de ejecución</param>
        /// <param name="min">Minuto de ejecución</param>/
        /// <param name="dia">Día o días de ejecución (ej:1;2;3;4-7;9-11;20)</param>
        /// <param name="primDia">Si se corre el Primer dia del mes</param>
        /// <param name="ultDia">Si se corre el Ultimo día del mes</param>
        public static string ToCronExpresMensual(string hora, string min, string dia, bool primDia, bool ultDia) {
            // Controla en caso que uno de los valores venga vacío, los pone en '0'
            hora = (hora.Length == 0) ? "0" : hora;
            min = (min.Length == 0) ? "0" : min;
            dia = (dia.Length == 0) ? "1" : dia;

            // Discrimina en funcion de los valores de primDia y ultDia
            //diaProgramado = (Convert.ToInt32(dia) > 0) ? dia : "1";
            string diaProgramado = dia;
            if (primDia || ultDia) 
                diaProgramado = (primDia) ? "1C" : "L";

            // En caso de que todos los valores ven
            // Arma la cron-expression con el siguiente formato:
            // <segundo> <minuto> <hora> <dia_del_mes> <mes> <dia_de_semana>
            return string.Format("{0} {1} {2} {3} {4} {5}", 0, min, hora, diaProgramado, "*", "?");
        }

        /// <summary>
        /// Devuelve la siguiente fecha de ejecución en base a una 
        /// cadena cron y a la ultima fecha de ejecución pasada. Se
        /// asegura que el valor sea "utilizable" es decir que sea
        /// mayor a la fecha y hora actuales (de lo contrario podría
        /// dar un valor que nunca se utilizaria -por ejemplo:ayer-).
        /// </summary>
        /// <param name="expresionCron">
        /// La cadena cron a evaluar teniendo en cuenta el formato:
        /// ["segundo" "minuto" "hora" "dia_del_mes" "mes" "dia_de_semana"].
        /// Ejemplo: [0 30 23 ? * MON,TUE,WEN].
        /// </param>
        /// <param name="ultima">
        /// La ultima fecha de ejecución pasada.
        /// </param>
        /// <returns>
        /// La siguiente decha de ejecución (con hora y minuto).
        /// Si hay un error retorna la fecha nula.
        /// </returns>
        public static DateTime GetSiguienteEjecucion(string expresionCron, DateTime ultima) {
            try {
                // Desmenuza la expresion y si esta mal retorna nulo
                string[] expresion = expresionCron.Split(' ');
                if (expresion.Length < 6)
                    return Fechas.FechaNull;

                // obtiene los valores iniciales
                int hora = Convert.ToInt32(expresion[2]);
                int minuto = Convert.ToInt32(expresion[1]);
                string dia = expresion[3];

                // Obtiene el dia base desde el cual hacer los calculos
                // (esto para asegurar que siempre se vuelva a ejecutar
                // -que no de un valor menor a hoy- pero es para ver!!!)
                DateTime diaBase = ((DateTime.Now > ultima) ? DateTime.Now : ultima);
                if (DateTime.Now >= DateTime.Now.Date.AddHours(hora).AddMinutes(minuto + 1))
                    diaBase = diaBase.AddDays(1);
                diaBase = diaBase.Date.AddHours(hora).AddMinutes(minuto);

                // si se debe ejecutar todos los dias ya tiene la fecha
                if (dia.Equals("*"))
                    return diaBase;                
                
                // si no se debe ejecutar todos los dias hay que calcular
                int diff = 0;
                if (dia.Equals("?")) {
                    int temp1 = 0;
                    string diaAbreviado = diaBase.Date.DayOfWeek.ToString().ToUpper().Substring(0, 3);
                    foreach (string d in _dias) {
                        if (d.Equals(diaAbreviado))
                            break;
                        temp1++;
                    }
                    string[] dias = expresion[5].Split(',');
                    int temp2 = 0;
                    bool listo = false;
                    foreach (string d in _dias) {
                        if (temp2 > temp1)
                            foreach (string ds in dias) 
                                if (ds.Equals(d)) {
                                    listo = true;
                                    break;
                                }
                        if (listo)
                            break;
                        temp2++;
                    }
                    diff = temp2 - temp1;
                } else if (dia.Equals("1C")) {
                    while (diaBase.AddDays(diff++).Day != 1) {}
                } else if (dia.Equals("L")) {
                    int dd = DateTime.Now.Day;
                    while (diaBase.AddDays(++diff).Day > dd) { }
                    diff--;
                } else {
                    int dd = diaBase.Day;
                    string[] grupos = dia.Split(';');
                    foreach (string grupo in grupos) {
                        bool engrupo = false;
                        string[] dif = grupo.Split('-');
                        foreach (string s in dif) {
                            int act = Convert.ToInt32(s);

                            // Si no esta dentro de un grupo y el dia de la configuracion 
                            // es igual o mayor al dia base => tiene que ser ese el sgte.
                            if (!engrupo && (act >= dd))
                                return diaBase.AddDays((act - dd));

                            // Si esta dentro de un grupo y el dia base es igual o menor 
                            // al dia final de ese grupo entonces el dia base es el sgte.
                            if (engrupo && (dd <= act)) 
                                return diaBase;   

                            // Si esta en un grupo se actualiza esto para avisar
                            // y cuando termina el grupo sale y blanquea arriba
                            engrupo = true;
                        }
                    }

                    // Si salio es porque el día es posterior a toda 
                    // la configuracion por lo que debo tomar el primero
                    // configurado pero pasarlo al mes siguiente
                    int primerDiaConfigurado = Convert.ToInt32(grupos[0].Split('-')[0]);
                    return diaBase.AddDays((primerDiaConfigurado - diaBase.Day)).AddMonths(1);
                }

                // retorna la fecha y hora calculada como siguiente
                return diaBase.AddDays(diff);
            } catch {
                return Fechas.FechaNull;
            }
        }
    }
}