using scioPersistentLibrary;
using sgmpro.dominio.configuracion;

namespace toolsGestion.Vocablos {
    internal class VocabloPoseeDescContactoLaboral : Vocablo {
        /// <summary>
        /// Devuelve el resultado de Evaluar el vocablo
        /// para el objeto definido.
        /// Debe ser redefinido en cada clase.
        /// </summary>
        /// <param name="unObj">El objeto que se pretende Evaluar</param>
        /// <param name="unCriterio">Criterio que se evaluará (ej.<=,=,<>)</param>
        /// <param name="unValor">Valor que se comparará con el valor del Vocablo</param>
        /// <returns>Resultado de la evaluación</returns>
        public override bool Evaluar(object unObj, string unCriterio, string unValor) {
            _dt = null;

            string select =
                "select 1 as resultado" +
                "  from contacto, persona, cuenta" + 
                " where cta_id          = '" + unObj + "'" +
                "   and prs_id          = cta_titular" +
                "   and con_persona     = prs_id" + 
                "   and con_tipo        = (select par_id from parametro where par_clave = 'TIPOCONTACTO.LABORAL')" +
                "   and con_descripcion like '%" + unValor + "%'";

            _dt = Persistencia.EjecutarSqlSelect(select, Persistencia.Controlador.CadenaConexion);

            return (_dt != null && _dt.Rows.Count > 0);
        }
    }
}