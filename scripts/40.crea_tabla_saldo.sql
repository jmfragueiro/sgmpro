USE [sgmpro]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].Saldo(
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
	CONSTRAINT [PK__saldo__38996AB5] PRIMARY KEY CLUSTERED(
		[sdo_id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, 
	 ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Saldo]  WITH CHECK ADD  CONSTRAINT [fk_Saldo_Tipo] FOREIGN KEY([sdo_tipo])
REFERENCES [dbo].[Parametro] ([par_id])
GO
ALTER TABLE [dbo].[Saldo] CHECK CONSTRAINT [fk_Saldo_Tipo]
GO
ALTER TABLE [dbo].[Saldo]  WITH CHECK ADD  CONSTRAINT [fk_Saldo_Convenio] FOREIGN KEY([sdo_convenio])
REFERENCES [dbo].[Convenio] ([cvn_id])
GO
ALTER TABLE [dbo].[Saldo] CHECK CONSTRAINT [fk_Saldo_Convenio]
GO
ALTER TABLE [dbo].[Saldo]  WITH CHECK ADD  CONSTRAINT [fk_Saldo_Cuenta] FOREIGN KEY([sdo_cuenta])
REFERENCES [dbo].[Cuenta] ([cta_id])
GO
ALTER TABLE [dbo].[Saldo] CHECK CONSTRAINT [fk_Saldo_Cuenta]
GO
CREATE NONCLUSTERED INDEX [ifk_saldo_convenio] ON [dbo].[Saldo](
	[sdo_convenio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [ifk_saldo_cuenta] ON [dbo].[Saldo](
	[sdo_cuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
