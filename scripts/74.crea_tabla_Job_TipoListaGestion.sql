USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[TipoLista_Entidad]    Fecha de la secuencia de comandos: 08/03/2011 20:33:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_TipoListaGestion](
	[job_id] [uniqueidentifier] NOT NULL,
	[tlg_id] [uniqueidentifier] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Job_TipoListaGestion]  WITH CHECK ADD CONSTRAINT [FK7308609B1A875999] FOREIGN KEY([job_id])
REFERENCES [dbo].[Job] ([job_id])
GO
ALTER TABLE [dbo].[Job_TipoListaGestion] CHECK CONSTRAINT [FK7308609B1A875999]
GO
ALTER TABLE [dbo].[Job_TipoListaGestion]  WITH CHECK ADD CONSTRAINT [FK7308609BF95E7888] FOREIGN KEY([tlg_Id])
REFERENCES [dbo].[TipoListaGestion] ([tlg_id])
GO
ALTER TABLE [dbo].[Job_TipoListaGestion] CHECK CONSTRAINT [FK7308609BF95E7888]

