USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[Tramo]    Fecha de la secuencia de comandos: 03/07/2011 17:07:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP TABLE [dbo].[Tramo]
GO
CREATE TABLE [dbo].[Tramo](
	[tra_id] [uniqueidentifier] NOT NULL,
	[tra_producto] [uniqueidentifier] NULL,
	[tra_nombre] [nvarchar](255) NOT NULL,
	[tra_limite] [bigint] NOT NULL,
	[tra_punitorio] [float] NULL,
	[tra_honorario] [float] NULL,
	[tra_fechabaja] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[tra_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tramo]  WITH CHECK ADD CONSTRAINT [fk_Tramo_Producto] FOREIGN KEY([tra_producto])
REFERENCES [dbo].[Producto] ([pro_id])
GO
ALTER TABLE [dbo].[Tramo] CHECK CONSTRAINT [fk_Tramo_Producto]