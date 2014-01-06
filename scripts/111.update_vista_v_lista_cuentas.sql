USE [sgmpro]
GO
/****** Object:  View [dbo].[v_lista_cuentas]    Script Date: 05/28/2012 15:21:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP VIEW [dbo].[v_lista_cuentas]
GO
CREATE VIEW [dbo].[v_lista_cuentas]
AS
/*******************************************************
  Vista que genera los datos para el listado de 
  Gestiones realizadas.-
********************************************************/
select ent_nombre+' ('+ent_cuit+')' as Entidad,
	   prs_nombre as Nombre, 
	   prs_dni as DNI, 
	   (case when (isnull(t.con_telefono1,'') = '') then (case when (isnull(t.con_telefono2,'') = '') then 'S/D' else t.con_telefono2 end) else t.con_telefono1 end) Telefono,
	   (case when (isnull(t.con_celular,'') = '') then 'S/D' else t.con_celular end) Celular,
       (case when (isnull(t.con_email,'') = '') then 'S/D' else t.con_email end) Email,
       p.par_nombre Localidad,
	   cta_codigo as Cuenta,
	   cta_expediente as Expediente,	
	   r.par_nombre Estado,
       (select top(1) con_descripcion from contacto where con_persona = prs_id and con_tipo = 'f2ddce8e-02bc-426f-b993-b57b1b68b9fe') Empleo,
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
  from parametro r, parametro p, contacto t, persona, entidad, cuenta
 where cta_entidad     = ent_id
   and cta_titular     = prs_id
   and t.con_persona   = cta_titular
   and t.con_principal = 1
   and t.con_fechaumod = (select max(e.con_fechaumod)
                            from contacto e
                           where e.con_persona = cta_titular
                             and e.con_principal = 1)
   and p.par_id        = t.con_localidad 
   and r.par_id        = cta_estado

