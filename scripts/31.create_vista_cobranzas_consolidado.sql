USE [sgmpro];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE VIEW [dbo].[v_lista_cobranzas_consolidado]
AS
select 
ent.ent_nombre Cliente,
--sum(pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos) Total, 
sum(case when tip_pag.par_nombre = 'ANTICIPO'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Anticipo,
sum(case when tip_pag.par_nombre = 'PAGO CUOTA'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Cuota,
sum(case when tip_pag.par_nombre = 'PAGO PARCIAL'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) [PagoParcial],
sum(case when tip_pag.par_nombre = 'CANCELACION'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Cancelacion,
sum(case when tip_pag.par_nombre = 'CANCELACION CON QUITA'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) [Canc_c_quita],
sum(case when tip_pag.par_nombre = 'PAGO EN SUCURSAL'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) [Pago_Suc],
sum(case when tip_pag.par_nombre = 'DEPOSITO BANCARIO'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) [Dep_Bancario],
sum(case when tip_pag.par_nombre = 'DEPOSITO JUDICIAL'  then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) [Dep_Judicial],
sum (case when tip_pag.par_nombre <> 'ANTICIPO' and tip_pag.par_nombre <> 'PAGO CUOTA' and tip_pag.par_nombre <> 'PAGO PARCIAL' and tip_pag.par_nombre <> 'CANCELACION'
and tip_pag.par_nombre <> 'CANCELACION CON QUITA' and tip_pag.par_nombre <> 'PAGO EN SUCURSAL' and tip_pag.par_nombre <> 'DEPOSITO BANCARIO' 
and tip_pag.par_nombre <> 'DEPOSITO JUDICIAL' then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Otros,
pag.pag_fecha Pago
from Pago as pag
inner join Cuenta cue on pag.pag_cuenta = cue.cta_id
inner join Entidad ent on cue.cta_entidad = ent.ent_id
inner join Parametro tip_pag on pag.pag_tipo = tip_pag.par_id
inner join Parametro est on pag.pag_estado = est.par_id
where  est.par_nombre <> 'ANULADO'
group by ent.ent_nombre,pag.pag_fecha
GO