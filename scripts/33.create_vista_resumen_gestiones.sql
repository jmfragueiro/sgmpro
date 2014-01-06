/**********************************************************************************
  Vista que se utiliza para generar el informe Gestiones Diarias x Hora

**********************************************************************************/
select 
  u.usu_empleado Usuario,
  datepart (hh,g.ges_fechacierre) Hora,  
  case when 
        (datediff(mi,
                (select 
                  max(t.ges_fechacierre)
                  from gestion t 
                  where g.ges_usuario = t.ges_usuario 
                        and t.ges_fechacierre < g.ges_fechacierre),
                g.ges_fechainicio)>59)
  then datepart(mi,g.ges_fechainicio)
  else (datediff(mi,
                (select 
                  max(t.ges_fechacierre)
                  from gestion t 
                  where g.ges_usuario = t.ges_usuario 
                        and t.ges_fechacierre < g.ges_fechacierre),
                g.ges_fechainicio))
  end
  SinGestion,
  datediff(mi, g.ges_fechainicio, g.ges_fechacierre) EnGestion,
  (case when datediff(mi, g.ges_fechainicio, g.ges_fechacierre) > 5 then 1 else 0 end) Cuentas 
from gestion g
inner join Usuario u on g.ges_usuario = u.usu_id
where g.ges_fechacierre >= convert(datetime,'14/07/2010',103) 
and g.ges_fechacierre < convert(datetime,'15/07/2010',103)
--and u.usu_nombre = 'ATENCION 1'
order by g.ges_fechacierre


-- Inserta el menú asociado
insert into Parametro (
   par_id
  ,par_clave
  ,par_nombre
  ,par_clase
  ,par_tipo
  ,par_orden
  ,par_valorlong
  ,par_valorstring
  ,par_valordate
  ,par_valorchar
  ,par_valorbool
  ,par_valordouble
  ,par_fechabaja
  ,par_valorint
  ,par_valordouble2
) VALUES (
   '66c9265e-61d6-41ee-b202-b591a94e5db3'   -- par_id
  ,N'MENU.INFORMES.GESHORA' -- par_clave
  ,N'Gestiones x Hora' -- par_nombre
  ,1   -- par_clase
  ,4   -- par_tipo
  ,8   -- par_orden
  ,0   -- par_valorlong
  ,N'cuGenerarInformes.CUGestionesHora' -- par_valorstring
  ,'01/01/1753'  -- par_valordate
  ,N'' -- par_valorchar
  ,''  -- par_valorbool
  ,0   -- par_valordouble
  ,'01/01/1753'  -- par_fechabaja
  ,0   -- par_valorint
  ,0   -- par_valordouble2
)
-- Inserta el permiso asociado
insert into Permiso (
   per_id
  ,per_tipo
  ,per_fechabaja
  ,per_recurso
) VALUES (
   '2b8d8ec4-c805-41fd-85b8-e37026dcb4a0'  -- per_id
  ,5   -- per_tipo
  ,'01/01/1753'  -- per_fechabaja
  ,'66c9265e-61d6-41ee-b202-b591a94e5db3'   -- per_recurso
)
-- Inserta el Rol Permiso respectivo
insert into Rol_Permiso (
   rol_id
  ,per_id
) VALUES (
   'afcd4962-c766-4895-8d2f-8a552755477a'  -- rol_id
  ,'2b8d8ec4-c805-41fd-85b8-e37026dcb4a0'   -- per_id
)