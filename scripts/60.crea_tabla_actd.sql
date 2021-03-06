USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[Cuenta]    Fecha de la secuencia de comandos: 03/27/2011 18:29:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actd](
	[act_id]   [uniqueidentifier] NOT NULL,
	[act_tipo] [char] NOT NULL DEFAULT 'C',
	[act_actd] [float] NULL DEFAULT ((0)),
	[act_hono] [float] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[act_id] ASC, [act_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
