USE [sgmpro]
GO
/****** Objeto:  View [dbo].[v_lista_cuentas]    Fecha de la secuencia de comandos: 01/26/2011 17:45:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER view [dbo].[v_lista_cuentas]
as
/*******************************************************
  Vista que genera los datos para el listado de 
  Gestiones realizadas.-
********************************************************/
select ent_nombre+' ('+ent_cuit+')' as Entidad,
	   prs_nombre as Nombre, 
	   prs_dni as DNI, 
	   (select top(1) isnull(isnull(con_telefono1, con_telefono2),'S/D') from contacto where con_persona = prs_id and con_principal = 1) Telefono,
	   (select top(1) isnull(con_celular,'S/D') from contacto where con_persona = prs_id and con_principal = 1) Celular,
	   cta_codigo as Cuenta,
	   cta_expediente as Expediente,	
	   (select top(1) par_nombre from parametro where par_id = cta_estado) Estado,
	   cta_fechaalta FechaIngreso,
	   cta_fechaasignacion FechaAsignacion,
       (select max(ges_fechacierre) from gestion where ges_cuenta = cta_id and ges_fechacierre > convert(datetime, '1753-01-01 00:00:00.000', 121)) UltimaGestion,
       (select top(1) r.par_nombre from gestion g inner join Parametro r on g.ges_resultado = r.par_id where ges_cuenta = cta_id and ges_fechacierre = (select max(ges_fechacierre) from gestion where ges_cuenta = cta_id) and ges_fechacierre > convert(datetime, '1753-01-01 00:00:00.000', 121)) UltimoResultado,
       (select top(1) (c.con_calle + ' ' + (case when c.con_puerta = '0' then '' else c.con_puerta end)) from gestion g inner join Contacto c on g.ges_contacto = c.con_id where ges_cuenta = cta_id and ges_fechainicio = (select max(ges_fechacierre) from gestion where ges_cuenta = cta_id) and ges_fechacierre > convert(datetime, '1753-01-01 00:00:00.000', 121)) UltimoDomicilio,
	   (select isnull(sum(deu_capital),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 1 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and deu_estado <> 'D2CD0030-0EE5-4671-9D04-9635D864D7FB') as CapitalInformado,
	   (select isnull(sum(deu_interes),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 1 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and deu_estado <> 'D2CD0030-0EE5-4671-9D04-9635D864D7FB') as InteresInformado,
	   (select isnull(sum(deu_honorarios),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 1 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and deu_estado <> 'D2CD0030-0EE5-4671-9D04-9635D864D7FB') as HonorInformado,
	   (select isnull(sum(deu_gastos),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 1 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and deu_estado <> 'D2CD0030-0EE5-4671-9D04-9635D864D7FB') as GastosInformado,
	   (select isnull(sum(deu_capital+deu_interes+deu_honorarios+deu_gastos),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 1 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and deu_estado <> 'D2CD0030-0EE5-4671-9D04-9635D864D7FB') as DeudaInformada,
	   (select isnull(sum(deu_capital+deu_interes+deu_honorarios+deu_gastos),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 0 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and deu_estado <> 'D2CD0030-0EE5-4671-9D04-9635D864D7FB') as DeudaNoInformada,
	   (select isnull(sum(deu_capital+deu_interes+deu_honorarios+deu_gastos),0) from deuda where deu_cuenta = cta_id and deu_convenio is not null and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and deu_estado <> 'D2CD0030-0EE5-4671-9D04-9635D864D7FB') as DeudaConvenio,
	   (select isnull(sum(pag_capital+pag_interes+pag_honorarios+pag_gastos),0) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)) as Pagos,
	   (select isnull(sum(pag_capital+pag_interes+pag_honorarios+pag_gastos),0) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and pag_fecha = (select max(pag_fecha) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121))) MontoUltPago,
	   (select max(pag_fecha) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)) as FechaUltPago
  from entidad, persona, cuenta
 where cta_entidad = ent_id
   and cta_titular = prs_id