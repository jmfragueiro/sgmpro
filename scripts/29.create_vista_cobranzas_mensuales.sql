USE [sgmpro];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE VIEW [dbo].[v_lista_cobranzas_mensuales]
AS
select 
ent.ent_nombre Cliente,
sum(pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos) Total, 
sum(case when Month(pag.pag_fecha) = 1 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Ene,
sum(case when Month(pag.pag_fecha) = 2 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Feb,
sum(case when Month(pag.pag_fecha) = 3 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Mar,
sum(case when Month(pag.pag_fecha) = 4 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Abr,
sum(case when Month(pag.pag_fecha) = 5 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) May,
sum(case when Month(pag.pag_fecha) = 6 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Jun,
sum(case when Month(pag.pag_fecha) = 7 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Jul,
sum(case when Month(pag.pag_fecha) = 8 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Ago,
sum(case when Month(pag.pag_fecha) = 9 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Sep,
sum(case when Month(pag.pag_fecha) = 10 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Oct,
sum(case when Month(pag.pag_fecha) = 11 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Nov,
sum(case when Month(pag.pag_fecha) = 12 then pag.pag_capital + pag.pag_interes + pag.pag_honorarios + pag.pag_gastos else 0 end) Dic,
Year(pag.pag_fecha) Periodo
,tip_pag.par_nombre TipoPago
from Pago as pag
inner join Cuenta cue on pag.pag_cuenta = cue.cta_id
inner join Entidad ent on cue.cta_entidad = ent.ent_id
inner join Parametro tip_pag on pag.pag_tipo = tip_pag.par_id
inner join Parametro est_pag on pag.pag_estado = est_pag.par_id
where est_pag.par_nombre <> 'ANULADO'
group by ent.ent_nombre, Year(pag.pag_fecha), tip_pag.par_nombre
GO

-- Permisos para el informa de cobranzas mensuales
-- insert into parametro values ('f7184146-6b84-4766-987c-16d7d2c4ffd6','MENU.INFORMES.COBMENS', 'Cobranzas Mensuales',1,4,7,0,'cuGenerarInformes.CUCobranzasMensuales','01/01/1753',null,0,0,'01/01/1753');
-- insert into Permiso values('2B8D8E74-C805-41FD-85B8-E37026DCB4A1',5,'01/01/1753','f7184146-6b84-4766-987c-16d7d2c4ffd6');
-- insert into Rol_Permiso values('afcd4962-c766-4895-8d2f-8a552755477a','2B8D8E74-C805-41FD-85B8-E37026DCB4A1');
 