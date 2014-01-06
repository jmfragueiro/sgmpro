-------------------------------------------------
-------------------------------------------------
-- PRIMERO BORRA LA TABLA TEMPORAL DEL PROCESO --
-------------------------------------------------
-------------------------------------------------
delete from actd;
-------------------------------------------------
-------------------------------------------------
-- LUEGO RELLENA LA TABLA TEMPORAL DEL PROCESO --
-------------------------------------------------
-------------------------------------------------
insert into actd
-- PRIMERO CON LAS CUENTAS EN TRAMOS TEMPORALES--
select c.cta_id, 'T', t.tra_punitorio, t.tra_honorario
  from tramo t, producto p, cuenta c, parametro m
 where c.cta_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)   
   and c.cta_activada   = 1
   and c.cta_entidad    is not null   
   and c.cta_convenioactivo is null
   and c.cta_estado     not in ('380FCCCE-5D5E-4D6E-8F30-469791F37173', -- ACUERDO ADMIN. POR ESTUDIO
								'0BD3EEF7-8C50-466E-9F93-A225744DABED', -- CANCELACION TOTAL DE DEUDA
								'D44E0A69-4EDD-4099-B3E0-94D7A263E810') -- CTA. DESASIGNADA POR CLIENTE 
   and m.par_id         = c.cta_estado  
   and m.par_clave      not like '%JUICIO%' 
   and p.pro_id         = c.cta_producto
   and p.pro_actualizar = 1
   and p.pro_tramostemporales = 1
   and p.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_producto   = p.pro_id 
   and t.tra_nombre     <> 'LEGAL'
   and t.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_punitorio  > 0
   and t.tra_limite     = (select min(t2.tra_limite)
						     from tramo t2, producto p2, cuenta c2 
						    where c2.cta_id         = c.cta_id
						      and p2.pro_id         = c2.cta_producto
						      and p2.pro_actualizar = 1
						      and p2.pro_tramostemporales = 1
						      and p2.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
						      and t2.tra_producto   = p2.pro_id 
							  and t2.tra_nombre     <> 'LEGAL'
						      and t2.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
						      and t2.tra_punitorio  > 0
							  and getdate()-(select min(d.deu_fechavto)
							  				   from deuda d
										      where d.deu_cuenta    = c2.cta_id
											    and d.deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
											    and d.deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',  -- PENDIENTE
																	    'CB1BE5FE-566D-4857-A4D2-135A87498AF4')) -- PENDIENTE PARCIAL
								  between 1 and t2.tra_limite)
union
-- LUEGO CON LAS CUENTAS EN TRAMOS POR GESTION --
select c.cta_id, 'G', t.tra_punitorio, t.tra_honorario
  from tramo t, producto p, cuenta c, parametro m
 where c.cta_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)   
   and c.cta_activada   = 1
   and c.cta_entidad    is not null   
   and c.cta_convenioactivo is null
   and c.cta_estado     not in ('380FCCCE-5D5E-4D6E-8F30-469791F37173', -- ACUERDO ADMIN. POR ESTUDIO
								'0BD3EEF7-8C50-466E-9F93-A225744DABED', -- CANCELACION TOTAL DE DEUDA
								'D44E0A69-4EDD-4099-B3E0-94D7A263E810') -- CTA. DESASIGNADA POR CLIENTE) 
   and m.par_id         = c.cta_estado  
   and m.par_clave      not like '%JUICIO%' 
   and p.pro_id         = c.cta_producto
   and p.pro_actualizar = 1
   and p.pro_tramostemporales = 0
   and p.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_producto   = p.pro_id 
   and t.tra_nombre     <> 'LEGAL'
   and t.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_punitorio  > 0
   and t.tra_limite     = (select min(t2.tra_limite)
						     from tramo t2, producto p2, cuenta c2 
						    where c2.cta_id         = c.cta_id
						      and p2.pro_id         = c2.cta_producto
						      and p2.pro_actualizar = 1
						      and p2.pro_tramostemporales = 0
						      and p2.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
						      and t2.tra_producto   = p2.pro_id 
							  and t2.tra_nombre     <> 'LEGAL'
						      and t2.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
						      and t2.tra_punitorio  > 0
							  and (select count(*)
									 from gestion g
								    where g.ges_cuenta    = c2.cta_id
									  and g.ges_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
									  and g.ges_estado    = '57528414-8189-496E-89DB-38B1390503AF') -- FINALIZADA
								  between 1 and t2.tra_limite)
union
-- LUEGO CON LAS CUENTAS EN ESTADOS LEGALES    --
select c.cta_id, 'L', t.tra_punitorio, t.tra_honorario
  from tramo t, producto p, cuenta c, parametro m
 where c.cta_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)   
   and c.cta_entidad    is not null   
   and c.cta_activada   = 1
   and c.cta_convenioactivo is null
   and m.par_id         = c.cta_estado  
   and m.par_clave      like '%JUICIO%' 
   and p.pro_id         = c.cta_producto
   and p.pro_actualizar = 1
   and p.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_producto   = p.pro_id 
   and t.tra_nombre     = 'LEGAL'
   and t.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_punitorio  > 0
union
-- LUEGO CON LAS CUENTAS CON CONVENIO ACTIVOS  --
select v.cvn_id, 'C', t.tcn_punitorio, t.tcn_honorarios
  from tipoconvenio t, convenio v, cuenta c
 where c.cta_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)   
   and c.cta_entidad    is not null   
   and c.cta_activada   = 1
   and c.cta_convenioactivo is not null
   and v.cvn_id         = c.cta_convenioactivo
   and v.cvn_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)   
   and v.cvn_activo     = 1   
   and v.cvn_tipo       is not null
   and t.tcn_id         = v.cvn_tipo
   and t.tcn_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)   
   and t.tcn_activo     = 1;
-------------------------------------------------
-------------------------------------------------
-- LUEGO ACTUALIZA LOS INTERESES DE LAS DEUDAS --
-------------------------------------------------
-------------------------------------------------
-- DEUDAS DE CUENTAS --
update deuda 
   set deu_interes = round((deu_capital 
							* (select (act_actd/100) 
								 from actd 
								where act_id = deu_cuenta) 
							* datediff(dd,deu_fechavto,getdate())),2)
 where deu_cuenta    in (select act_id from actd where act_tipo <> 'C')
   and deu_capital   > 0	
   and deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
   and deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',
					     'CB1BE5FE-566D-4857-A4D2-135A87498AF4')
   and datediff(dd,deu_fechavto,getdate()) > 0;
-- DEUDAS DE CONVENIOS --
update deuda 
   set deu_interes = deu_intereso + (round((deu_capital 
										* (select (act_actd/100) 
											 from actd 
											where act_id = deu_convenio) 
										* datediff(dd,deu_fechavto,getdate())),2))
 where deu_convenio  in (select act_id from actd where act_tipo = 'C')
   and deu_capital   > 0	
   and deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
   and deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',
					     'CB1BE5FE-566D-4857-A4D2-135A87498AF4')
   and datediff(dd,deu_fechavto,getdate()) > 0;
-------------------------------------------------
-------------------------------------------------
-- LUEGO ACTUALIZA LOS HONORARIOS DE LAS DEUDAS--
-------------------------------------------------
-------------------------------------------------
update deuda 
   set deu_honorarios = round((deu_capital + deu_interes) 
								* (select (act_hono/100) 
									 from actd 
									where act_id = deu_cuenta),2)
 where deu_cuenta in (select act_id from actd where act_tipo <> 'C')
   and deu_capital   >= 0	
   and deu_interes   >= 0
   and deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
   and deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',
					     'CB1BE5FE-566D-4857-A4D2-135A87498AF4')
   and datediff(dd,deu_fechavto,getdate()) > 0;
update deuda 
   set deu_honorarios = deu_honoro + (round((deu_capital + deu_interes) 
										* (select (act_hono/100) 
											 from actd 
											where act_id = deu_convenio),2))
 where deu_convenio in (select act_id from actd where act_tipo = 'C')
   and deu_capital   >= 0	
   and deu_interes   >= 0
   and deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
   and deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',
					     'CB1BE5FE-566D-4857-A4D2-135A87498AF4')
   and datediff(dd,deu_fechavto,getdate()) > 0;

