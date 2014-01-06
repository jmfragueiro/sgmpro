USE [sgmpro];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE VIEW [dbo].[v_lista_pagos]
AS
select p.pag_fecha Fecha, t.par_nombre Tipo, r.rec_descripcion Descripcion,
rt.par_nombre + ' Nº '+ r.rec_numero  Recibo, p.pag_capital Capital, p.pag_interes Interes,
p.pag_honorarios Honorarios, p.pag_gastos Gastos, 
p.pag_capital + p.pag_interes + p.pag_honorarios + p.pag_gastos Total, c.cta_codigo Cuenta
from Pago p
inner join Parametro t on p.pag_tipo = t.par_id
inner join Recibo r on r.rec_pago = p.pag_id
inner join Parametro rt on r.rec_tipo = rt.par_id
inner join Cuenta c on p.pag_cuenta = c.cta_id
GO