USE [sgmpro]
GO
/****** Objeto:  View [dbo].[v_lista_cobranzas]    Fecha de la secuencia de comandos: 05/05/2010 21:03:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_lista_cobranzas]
as
/*******************************************************
  Vista que genera los datos para el listado de 
  Cobranzas realizadas.-
********************************************************/
select pag_fecha FechaPago,cpt.par_valorstring Concepto, fpa.par_valorstring FormaPago,
per.prs_dni CodDeudor, per.prs_nombre Deudor, cta.cta_codigo Cuenta, 
pag_capital + pag_interes + pag_honorarios + pag_gastos Importe,
rec.rec_numero NroComp, tir.par_valorstring LetraComp, ent.ent_nombre Cliente, est.par_nombre Estado
from Pago
inner join Parametro cpt on dbo.Pago.pag_tipo = cpt.par_id
inner join Parametro est on dbo.Pago.pag_estado = est.par_id
inner join Parametro fpa on dbo.Pago.pag_formapago = fpa.par_id
inner join Cuenta cta on dbo.Pago.pag_cuenta = cta.cta_id
inner join Persona per on cta.cta_titular = per.prs_id
inner join Entidad ent on cta.cta_entidad = ent.ent_id
left join Recibo rec on rec.rec_pago = dbo.Pago.pag_id
left join Parametro tir on rec.rec_tipo = tir.par_id
