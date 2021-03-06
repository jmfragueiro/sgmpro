USE [sgmpro]
GO
/****** Objeto:  View [dbo].[v_lista_cuentas]    Fecha de la secuencia de comandos: 09/08/2010  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[v_lista_cuentas]
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
	   (select top(1) par_nombre from parametro where par_id = cta_estado) Estado,
	   cta_fechaalta FechaIngreso,
	   cta_fechaasignacion FechaAsignacion,
	   (select isnull(sum(deu_capital+deu_interes+deu_honorarios+deu_gastos),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 1 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)) as DeudaInformada,
	   (select isnull(sum(deu_capital+deu_interes+deu_honorarios+deu_gastos),0) from deuda where deu_cuenta = cta_id and deu_convenio is null and deu_informada = 0 and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)) as DeudaNoInformada,
	   (select isnull(sum(deu_capital+deu_interes+deu_honorarios+deu_gastos),0) from deuda where deu_cuenta = cta_id and deu_convenio is not null and deu_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)) as DeudaConvenio,
	   (select isnull(sum(pag_capital+pag_interes+pag_honorarios+pag_gastos),0) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)) as Pagos,
	   (select isnull(sum(pag_capital+pag_interes+pag_honorarios+pag_gastos),0) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121) and pag_fecha = (select max(pag_fecha) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121))) MontoUltPago,
	   (select max(pag_fecha) from pago where pag_cuenta = cta_id and pag_fechabaja = convert(datetime, '1753-01-01 00:00:00.000', 121)) as FechaUltPago
  from entidad, persona, cuenta
 where cta_entidad = ent_id
   and cta_titular = prs_id
