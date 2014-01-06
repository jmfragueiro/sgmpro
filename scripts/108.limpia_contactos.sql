-- backupea por las dudas
select * into bak_contacto from contacto; 

-- borra las gestiones no utilizadas y viejas
delete from gestion 
where ges_fechabaja > convert(datetime, '1753-01-01 00:00:00.000', 121);

delete from gestion 
where ges_estado in ('7707AA10-5604-428D-8B38-25BAA5B6C906','6B20F89E-FC05-42CF-834D-A20F234AF3A8', 
					 '9E9752EA-3F6F-4BF6-ACC9-D47F51FD51D7', '19BEB75A-F27F-409F-A344-6518894D57FD') 
and (getdate()-ges_fechaumod) > 7;

-- actualiza los contactos no verificados pero que tienen gestiones 
update contacto
   set con_verificadopor = (select top(1) g1.ges_usuario
                              from gestion g1
                             where g1.ges_contacto  = con_id
                               and g1.ges_estado    = (select par_id 
                                                         from parametro 
                                                        where par_clave = 'ESTADOGESTION.FINALIZADA')
                               and g1.ges_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
                               and g1.ges_fechaumod = (select max(g2.ges_fechaumod)
                                                         from gestion g2
                                                        where g2.ges_contacto = con_id
														  and g2.ges_estado   = (select par_id 
																			       from parametro 
																			      where par_clave = 'ESTADOGESTION.FINALIZADA')
														  and g2.ges_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121))),
       con_fechaumod = isnull((select max(g3.ges_fechaumod)
								 from gestion g3
								where g3.ges_contacto  = con_id
								  and g3.ges_estado    = (select par_id 
												            from parametro 
													       where par_clave = 'ESTADOGESTION.FINALIZADA')
						          and g3.ges_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)), getdate())
 where con_verificadopor is null
   and con_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
   and exists (select 1 from gestion where ges_contacto = con_id);
  
-- borra los contactos no verificados
delete c1
  from contacto as c1
 where c1.con_verificadopor is null
   and con_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
   and not exists (select 1 from gestion where ges_contacto = con_id)	
   and exists (select 1
                 from contacto c2
                where c2.con_tipo      = c1.con_tipo
                  and c2.con_persona   = c1.con_persona
                  and (c2.con_fechaumod > c1.con_fechaumod or c2.con_id > c2.con_id));

-- deja un solo contacto principal
update c1 
   set c1.con_principal = 0
  from contacto c1
 where c1.con_principal = 1
   and exists (select 1
                 from contacto c2
                where c2.con_persona   = c1.con_persona
                  and c2.con_principal = 1
                  and (c2.con_fechaumod > c1.con_fechaumod or c2.con_id > c2.con_id));

-- consultas utiles
select count(*), con_persona, con_tipo
  from contacto
 where con_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
 group by con_persona, con_tipo
having count(*) > 1
order by 1 desc;

select 'REASIGNADA:'+convert(varchar, getdate(), 110)+'.'

select * 
from cuenta
where cta_entidad = '9AEDE4D5-9B5A-44C5-BB8C-1146BFFF1CD0'
and cta_activada = 1
 AND  (cta_fechaasignacion between convert(datetime, '2012-03-22 01:00:000',121)
								  and convert(datetime, '2012-03-22 23:00:000',121))


select count(*), cta_codigo, cta_producto
from cuenta
where cta_entidad = '9AEDE4D5-9B5A-44C5-BB8C-1146BFFF1CD0'
and cta_activada = 1
group by cta_codigo, cta_producto
having count(*) > 1
order by 1 desc

select * from cuenta where cta_codigo = '0000000260400980001'