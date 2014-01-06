USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[Ejecucion]    Fecha de la secuencia de comandos: 07/28/2011 13:28:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejecucion](
	[exe_id] [uniqueidentifier] NOT NULL,
	[exe_job] [uniqueidentifier] NULL,
	[exe_inicio] [datetime] NULL,
	[exe_fin] [datetime] NULL,
	[exe_resultado] [nvarchar](255) NULL,
	[exe_fechabaja] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[exe_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [sgmpro]
GO
/****** Objeto:  Index [ifk_gestion_listausuario]    Fecha de la secuencia de comandos: 06/22/2011 18:28:06 ******/
CREATE NONCLUSTERED INDEX [ifk_ejecucion_job] ON [dbo].[Ejecucion] 
(
	[exe_job] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO