USE [sgmpro]
GO
/****** Objeto:  Table [dbo].[EstadoCuenta]    Fecha de la secuencia de comandos: 06/16/2011 19:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCuenta](
	[esc_id] [uniqueidentifier] NOT NULL,
	[esc_cuenta] [uniqueidentifier] NOT NULL,
	[esc_estado] [uniqueidentifier] NOT NULL,
	[esc_fechainicio] [datetime] NOT NULL,
	[esc_usuario] [uniqueidentifier] NOT NULL,
	[esc_comentario] nvarchar(255) NULL,
	[esc_fechabaja] [datetime] NULL,
 CONSTRAINT [PK__EstadoCuenta__38996AB5] PRIMARY KEY CLUSTERED 
(
	[esc_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[esc_cuenta] ASC,
	[esc_estado] ASC,
	[esc_fechainicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[EstadoCuenta]  WITH CHECK ADD  CONSTRAINT [fk_EstadoCuenta_Cuenta] FOREIGN KEY([esc_cuenta])
REFERENCES [dbo].[Cuenta] ([cta_id])
GO
ALTER TABLE [dbo].[EstadoCuenta] CHECK CONSTRAINT [fk_EstadoCuenta_Cuenta]
GO
ALTER TABLE [dbo].[EstadoCuenta]  WITH CHECK ADD  CONSTRAINT [fk_EstadoCuenta_Estado] FOREIGN KEY([esc_estado])
REFERENCES [dbo].[Parametro] ([par_id])
GO
ALTER TABLE [dbo].[EstadoCuenta] CHECK CONSTRAINT [fk_EstadoCuenta_Estado]
GO
ALTER TABLE [dbo].[EstadoCuenta]  WITH CHECK ADD  CONSTRAINT [fk_EstadoCuenta_Usuario] FOREIGN KEY([esc_usuario])
REFERENCES [dbo].[Usuario] ([usu_id])
GO
ALTER TABLE [dbo].[EstadoCuenta] CHECK CONSTRAINT [fk_EstadoCuenta_Usuario]
GO
/****** Objeto:  Index [idx_estadocuenta_usuario]    Fecha de la secuencia de comandos: 06/16/2011 19:48:33 ******/
CREATE NONCLUSTERED INDEX [idx_estadocuenta_usuario] ON [dbo].[EstadoCuenta] 
(
	[esc_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = OFF) ON [PRIMARY]
GO