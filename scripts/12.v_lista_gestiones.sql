USE [sgmpro];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
ALTER view [dbo].[v_lista_gestiones]
as
/*******************************************************
  Vista que genera los datos para el listado de 
  Gestiones realizadas.-
********************************************************/
select ges.ges_fechainicio FechaInicio, tipo.par_valorstring TipoGestion,
ges.ges_fechacierre FechaCierre,usu.usu_empleado Usuario, 
estado.par_valorstring Estado, result.par_nombre Resultado,
result.par_valorlong Puntaje,
datediff(mi,ges.ges_fechainicio, ges.ges_fechacierre) Duracion,
cue.cta_codigo + ' '+ cue.cta_descripcion Cuenta,
ges.ges_resultadodesc Comentarios
from Gestion ges
inner join dbo.Parametro tipo ON ges.ges_tipo = tipo.par_id
left join dbo.Usuario usu ON ges.ges_usuario = usu.usu_id
left join dbo.Parametro result ON ges.ges_resultado = result.par_id
left join dbo.Parametro estado ON ges.ges_estado = estado.par_id
left join dbo.Cuenta cue ON ges.ges_cuenta = cue.cta_id
GO