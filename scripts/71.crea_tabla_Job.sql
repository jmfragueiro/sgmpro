USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[JobGenListaGestion]    Fecha de la secuencia de comandos: 07/28/2011 13:28:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[job_id] [uniqueidentifier] NOT NULL,
	[job_crontab] [nvarchar](255) NULL,
	[job_nombre] [nvarchar](255) NULL,
	[job_descripcion] [nvarchar](255) NULL,
	[job_inicio] [datetime] NULL,
	[job_ultima] [datetime] NULL,
	[job_siguiente] [datetime] NULL,
	[job_fechabaja] [datetime] NOT NULL,
	[job_activo] [bit] NULL,
    [job_usuario] [uniqueidentifier] NULL,
	[job_ejecutando] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[job_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [sgmpro]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD CONSTRAINT [fk_Job_Usuario] FOREIGN KEY([job_usuario])
REFERENCES [dbo].[Usuario] ([usu_id])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [fk_Job_Usuario]
GO
USE [sgmpro]
GO
/****** Objeto:  Index [ifk_gestion_listausuario]    Fecha de la secuencia de comandos: 06/22/2011 18:28:06 ******/
CREATE NONCLUSTERED INDEX [ifk_job_usuario] ON [dbo].[Job] 
(
	[job_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO