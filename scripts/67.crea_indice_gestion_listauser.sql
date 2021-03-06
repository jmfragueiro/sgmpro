USE [sgmpro]
GO
/****** Objeto:  Index [ifk_gestion_listausuario]    Fecha de la secuencia de comandos: 06/22/2011 18:28:06 ******/
CREATE NONCLUSTERED INDEX [ifk_gestion_listausuario] ON [dbo].[Gestion] 
(
	[ges_lista] ASC,
	[ges_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]