/********************************************************************
  Modificación 07.02.2012.
  Se incluye la opción para marcar a los pagos seleccionados en el 
  informe "Cobranzas Ingresadas". Se marca como Rendidos.
  Los scripts cambian:
  1.  La vista del reporte para que incluya el id del pago, para poder
      recuperar y hacer un update del pago.
  2.  Se hace un Alter de la tabla Pago, y se incluye un nuevo campo
      pag_rendido del tipo booleano.  
*********************************************************************
*/

------------------------------------------------------------------------------------------
-- Agrega campo a la tabla Pagos
------------------------------------------------------------------------------------------
USE [sgmpro];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
ALTER TABLE [dbo].[Pago] ADD [pag_rendido] bit NULL
GO
ALTER TABLE [dbo].[Pago] ADD [pag_fecharend] datetime NULL
GO

USE [sgmpro];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
ALTER VIEW [dbo].[v_lista_cobranzas]
AS
SELECT     dbo.Pago.pag_fecha AS FechaPago, (CASE WHEN (tir.par_valorstring = 'RECIBO CTE' AND cpt.par_valorstring = 'GASTOS') THEN 'GASTO CLIENTE' ELSE cpt.par_valorstring END) 
                      AS Concepto, fpa.par_valorstring AS FormaPago, per.prs_dni AS CodDeudor, per.prs_nombre AS Deudor, cta.cta_codigo AS Cuenta, 
                      dbo.Pago.pag_capital + dbo.Pago.pag_interes + dbo.Pago.pag_honorarios + dbo.Pago.pag_gastos AS Importe, rec.rec_numero AS NroComp, 
                      tir.par_valorstring AS LetraComp, ent.ent_nombre AS Cliente, est.par_nombre AS Estado, dbo.Pago.pag_descripcion AS Detalle, per.prs_dni AS DNI, 
                      cta.cta_fechaasignacion AS Asignacion, cta.cta_expediente AS Expediente, dbo.Pago.pag_id Id, dbo.Pago.pag_rendido AS Rendido,
                      dbo.Pago.pag_fecharend FechaRend
FROM         dbo.Pago INNER JOIN
                      dbo.Parametro AS cpt ON dbo.Pago.pag_tipo = cpt.par_id INNER JOIN
                      dbo.Parametro AS est ON dbo.Pago.pag_estado = est.par_id INNER JOIN
                      dbo.Parametro AS fpa ON dbo.Pago.pag_formapago = fpa.par_id INNER JOIN
                      dbo.Cuenta AS cta ON dbo.Pago.pag_cuenta = cta.cta_id INNER JOIN
                      dbo.Persona AS per ON cta.cta_titular = per.prs_id INNER JOIN
                      dbo.Entidad AS ent ON cta.cta_entidad = ent.ent_id LEFT OUTER JOIN
                      dbo.Recibo AS rec ON rec.rec_pago = dbo.Pago.pag_id LEFT OUTER JOIN
                      dbo.Parametro AS tir ON rec.rec_tipo = tir.par_id

GO


