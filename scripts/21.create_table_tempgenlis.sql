USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[Gestion]    Fecha de la secuencia de comandos: 06/26/2010 10:26:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tempgenlis](
	[tgl_orden] [bigint] NOT NULL,
	[tgl_tipo] [uniqueidentifier] NOT NULL,
	[tgl_estado] [uniqueidentifier] NOT NULL,
	[tgl_cuenta] [uniqueidentifier] NULL,
	[tgl_lista] [uniqueidentifier] NULL,
	[tgl_fechaalta] [datetime] NULL
) ON [PRIMARY]

