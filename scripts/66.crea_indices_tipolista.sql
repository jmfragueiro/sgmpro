USE [sgmpro]
GO
/****** Objeto:  Index [ifk_tipolista_tipogestion]    Fecha de la secuencia de comandos: 06/22/2011 18:02:51 ******/
CREATE NONCLUSTERED INDEX [ifk_tipolista_tipogestion] ON [dbo].[TipoListaGestion] 
(
	[tlg_tipogestion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]

USE [sgmpro]
GO
/****** Objeto:  Index [ifk_tipolista_perfil]    Fecha de la secuencia de comandos: 06/22/2011 18:03:02 ******/
CREATE NONCLUSTERED INDEX [ifk_tipolista_perfil] ON [dbo].[TipoListaGestion] 
(
	[tlg_perfil] ASC,
	[tlg_tipogestion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]