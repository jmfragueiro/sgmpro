USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[Saldo]    Fecha de la secuencia de comandos: 02/07/2011 18:44:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Saldo_Hist](
	[sdo_id] [uniqueidentifier] NOT NULL,
	[sdo_tipo] [uniqueidentifier] NOT NULL,
	[sdo_capital] [float] NULL,
	[sdo_interes] [float] NULL,
	[sdo_honorarios] [float] NULL,
	[sdo_gastos] [float] NULL,
	[sdo_recargo] [float] NULL,
	[sdo_cuenta] [uniqueidentifier] NULL,
	[sdo_convenio] [uniqueidentifier] NULL,
	[sdo_fecha] [datetime] NULL,
	[sdo_fechabaja] [datetime] NULL,
	[sdo_fechahist] [datetime] NULL) ON [PRIMARY]
GO
