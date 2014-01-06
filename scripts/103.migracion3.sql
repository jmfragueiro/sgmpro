--select * from parametro where par_clave like 'ESTADODEUDA%'
--select * from parametro where par_clave like 'ESTADOPAGO%'

-- borro las deudas no utilizadas
delete
  from deuda 
 where deu_fechabaja > '1753-01-01 00:00:00.000'
   and deu_convenio is null
   and not exists (select 1 from imputacion where imp_deuda = deu_id)
   and not exists (select 1 from convenio where cvn_cuenta = deu_cuenta);
-- inicializo los montos originales
update deuda 
set deu_capitalo = deu_capital, 
	deu_intereso = deu_interes, 
	deu_honoro = deu_honorarios, 
	deu_gastoso = deu_gastos;
-- coloco en cero las deudas canceladas
update deuda 
   set deu_capital = 0, 
       deu_interes = 0, 
       deu_honorarios = 0, 
       deu_gastos = 0
 where deu_estado = 'D2CD0030-0EE5-4671-9D04-9635D864D7FB';
-- coloco en convenio las deudas informadas vivas de cuentas con convenio
update deuda 
   set deu_estado = 'FED5D7E6-0D34-4BBA-8E41-F07C7AA2F5A5'
 where deu_informada = 1
   and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
   and deu_cuenta is not null
   and deu_convenio is null
   and exists (select 1
                 from cuenta 
                where cta_id = deu_cuenta
                  and cta_convenioactivo is not null);
-- actualizo los saldos de las deudas desde las imputaciones
update deuda 
   set deu_capital = deu_capital - isnull((select sum(imp_capital) 
											  from imputacion, pago 
											 where imp_deuda     = deu_id
											   and imp_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
											   and pag_id        = imp_pago
											   and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
											   and pag_estado    in ('8A8C7C82-1EEA-487D-8AFE-D75B0EAA1E98'     -- aplicado
																	,'9484004D-4D36-4F3F-B8CF-5B25514911A3')),0)-- aplicado parcial
 where deu_estado not in ('7F1E0E09-5290-49A1-9CE3-37B483B6D84A'   -- cancelada
					     ,'D2CD0030-0EE5-4671-9D04-9635D864D7FB'   -- cancelada por convenio
						 ,'C8902983-45E0-4E02-AFBF-FF20A45D45CF'); -- anulada
update deuda set deu_capital = 0 where deu_capital < 0;
update deuda 
   set deu_interes = deu_interes - isnull((select sum(imp_interes) 
											  from imputacion, pago 
											 where imp_deuda     = deu_id
											   and imp_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
											   and pag_id        = imp_pago
											   and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
											   and pag_estado    in ('8A8C7C82-1EEA-487D-8AFE-D75B0EAA1E98'     -- aplicado
																	,'9484004D-4D36-4F3F-B8CF-5B25514911A3')),0)-- aplicado parcial
 where deu_estado not in ('7F1E0E09-5290-49A1-9CE3-37B483B6D84A'   -- cancelada
					     ,'D2CD0030-0EE5-4671-9D04-9635D864D7FB'   -- cancelada por convenio
						 ,'C8902983-45E0-4E02-AFBF-FF20A45D45CF'); -- anulada
update deuda set deu_interes = 0 where deu_interes < 0;
update deuda 
   set deu_honorarios = deu_honorarios - isnull((select sum(imp_honorarios) 
												  from imputacion, pago 
												 where imp_deuda     = deu_id
												   and imp_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
												   and pag_id        = imp_pago
												   and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
												   and pag_estado    in ('8A8C7C82-1EEA-487D-8AFE-D75B0EAA1E98'     -- aplicado
																		,'9484004D-4D36-4F3F-B8CF-5B25514911A3')),0)-- aplicado parcial
 where deu_estado not in ('7F1E0E09-5290-49A1-9CE3-37B483B6D84A'   -- cancelada
					     ,'D2CD0030-0EE5-4671-9D04-9635D864D7FB'   -- cancelada por convenio
						 ,'C8902983-45E0-4E02-AFBF-FF20A45D45CF'); -- anulada
update deuda set deu_honorarios = 0 where deu_honorarios < 0;
update deuda 
   set deu_gastos = deu_gastos - isnull((select sum(imp_gastos) 
										  from imputacion, pago 
										 where imp_deuda     = deu_id
										   and imp_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
										   and pag_id        = imp_pago
										   and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)
										   and pag_estado    in ('8A8C7C82-1EEA-487D-8AFE-D75B0EAA1E98'     -- aplicado
																,'9484004D-4D36-4F3F-B8CF-5B25514911A3')),0)-- aplicado parcial
 where deu_estado not in ('7F1E0E09-5290-49A1-9CE3-37B483B6D84A'   -- cancelada
					     ,'D2CD0030-0EE5-4671-9D04-9635D864D7FB'   -- cancelada por convenio
						 ,'C8902983-45E0-4E02-AFBF-FF20A45D45CF'); -- anulada
update deuda set deu_gastos = 0 where deu_gastos < 0;
-- marco como canceladas las deudas sin saldo
update deuda 
   set deu_estado = 'D2CD0030-0EE5-4671-9D04-9635D864D7FB'
 where (deu_capital+deu_interes+deu_honorarios+deu_gastos) = 0;