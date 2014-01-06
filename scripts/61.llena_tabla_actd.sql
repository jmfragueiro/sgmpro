delete from actd;
insert into actd
select c.cta_id, 'C', t.tra_punitorio, t.tra_honorario
  from tramo t, producto p, cuenta c
 where c.cta_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)   
   and p.pro_id         = c.cta_producto
   and p.pro_actualizar = 1
   and p.pro_tramostemporales = 1
   and p.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_producto   = p.pro_id 
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
						      and t2.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
						      and t2.tra_punitorio  > 0
							  and getdate()-(select min(d.deu_fechavto)
							  				   from deuda d
										      where d.deu_cuenta    = c2.cta_id
											    and d.deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
											    and d.deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',
																	  'CB1BE5FE-566D-4857-A4D2-135A87498AF4')) 
								  between 1 and t2.tra_limite);
insert into actd
select c.cta_id, 'C', t.tra_punitorio, t.tra_honorario
  from tramo t, producto p, cuenta c
 where c.cta_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and p.pro_id         = c.cta_producto
   and p.pro_actualizar = 1
   and p.pro_tramostemporales = 0
   and p.pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
   and t.tra_producto   = p.pro_id 
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
						      and t2.tra_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121)
						      and t2.tra_punitorio  > 0
							  and (select count(*)
									from gestion g
								   where g.ges_cuenta    = c2.cta_id
									 and g.ges_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
									 and g.ges_estado    = '57528414-8189-496E-89DB-38B1390503AF') 
								  between 1 and t2.tra_limite);
update deuda 
   set deu_interes = (case when round((deu_capital 
										* (select (act_actd) 
											 from actd 
											where act_id = deu_cuenta and act_tipo = 'C') 
										* datediff(dd,deu_fechavto,getdate())),2) > 0 
							then round((deu_capital 
										* (select (act_actd/100) from actd where act_id = deu_cuenta and act_tipo = 'C') 
										* datediff(dd,deu_fechavto,getdate())),2)
						else deu_interes end)
 where deu_cuenta in (select act_id from actd where act_tipo = 'C')
   and deu_estado in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA','CB1BE5FE-566D-4857-A4D2-135A87498AF4')
   and deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121);

update deuda 
   set deu_honorarios = (case when round((deu_capital + deu_interes) 
										* (select (act_hono/100) from actd where act_id = deu_cuenta and act_tipo = 'C'),2) > 0
							  then round((deu_capital + deu_interes) 
										* (select (act_hono/100) from actd where act_id = deu_cuenta and act_tipo = 'C'),2)
						 else deu_honorarios end)
 where deu_cuenta in (select act_id from actd where act_tipo = 'C')
   and deu_capital > 0
   and deu_interes > 0
   and deu_estado in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA','CB1BE5FE-566D-4857-A4D2-135A87498AF4')
   and deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121);
