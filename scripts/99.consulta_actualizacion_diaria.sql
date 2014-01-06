update cuenta
   set cta_actd = isnull((select t1.tra_punitorio
						  from tramo t1, producto p1, cuenta c1
						 where c1.cta_codigo     = cta_codigo
						   and c1.cta_producto   = p1.pro_id
						   and p1.pro_actualizar = 1
						   and t1.tra_producto   = p1.pro_id
						   and getdate()-(select min(d1.deu_fechavto)
											from deuda d1
										   where d1.deu_cuenta    = c1.cta_id
											 and d1.deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)) < t1.tra_limite
											 and d1.deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',
																	  'CB1BE5FE-566D-4857-A4D2-135A87498AF4')
						   and t1.tra_limite   = (select min(t2.tra_limite)
												  from tramo t2, producto p2, cuenta c2 
												 where c2.cta_codigo   = c1.cta_codigo
												   and c2.cta_producto = p2.pro_id
												   and p2.pro_actualizar = 1
												   and t2.tra_producto = p2.pro_id
												   and getdate()-(select min(d2.deu_fechavto)
																    from deuda d2
																   where d2.deu_cuenta    = c2.cta_id
																     and d2.deu_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)) < tra_limite)),0)
																     and d2.deu_estado    in ('BFF726E1-A06E-4B6B-90CC-AAB178C7D2FA',
																				  		   'CB1BE5FE-566D-4857-A4D2-135A87498AF4')

where cta_codigo   = 'S85872'

