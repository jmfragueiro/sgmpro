USE [sgmpro]
GO

/****** Objeto:  Index [ifk_gestion_usuario]    
Fecha de la secuencia de comandos: 05/24/2010 11:05:36 ******/
IF  EXISTS 
(SELECT * 
   FROM sys.indexes 
  WHERE object_id = OBJECT_ID(N'[dbo].[Gestion]') 
    AND name      = N'ifk_gestion_usuario')
DROP INDEX [ifk_gestion_usuario] 
ON [dbo].[Gestion] 
WITH ( ONLINE = OFF );

/****** Objeto:  Index [ifk_gestion_estadousuario]    
Fecha de la secuencia de comandos: 05/24/2010 11:05:36 ******/
IF  EXISTS 
(SELECT * 
   FROM sys.indexes 
  WHERE object_id = OBJECT_ID(N'[dbo].[Gestion]') 
    AND name      = N'ifk_gestion_estadousuario')
DROP INDEX [ifk_gestion_estadousuario] 
ON [dbo].[Gestion] 
WITH ( ONLINE = OFF );

/****** Objeto:  Index [ifk_gestion_estadousuario]    
Fecha de la secuencia de comandos: 05/24/2010 10:54:44 ******/
CREATE NONCLUSTERED INDEX [ifk_gestion_usuarioestado] 
ON [dbo].[Gestion] (
	[ges_usuario] ASC,
	[ges_estado] ASC
) WITH (
PAD_INDEX  = OFF, 
STATISTICS_NORECOMPUTE  = OFF, 
SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, 
DROP_EXISTING = OFF, 
ONLINE = OFF, 
ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) 
ON [PRIMARY];

/****** Objeto:  Index [ifk_gestion_tipo]    
Fecha de la secuencia de comandos: 05/24/2010 10:54:44 ******/
CREATE NONCLUSTERED INDEX [ifk_gestion_tipo] 
ON [dbo].[Gestion] (
	[ges_tipo] ASC
) WITH (
PAD_INDEX  = OFF, 
STATISTICS_NORECOMPUTE  = OFF, 
SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, 
DROP_EXISTING = OFF, 
ONLINE = OFF, 
ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) 
ON [PRIMARY];

/****** Objeto:  Index [ifk_gestion_resultado]    
Fecha de la secuencia de comandos: 05/24/2010 10:54:44 ******/
CREATE NONCLUSTERED INDEX [ifk_gestion_resultado] 
ON [dbo].[Gestion] (
	[ges_resultado] ASC
) WITH (
PAD_INDEX  = OFF, 
STATISTICS_NORECOMPUTE  = OFF, 
SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, 
DROP_EXISTING = OFF, 
ONLINE = OFF, 
ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = ON) 
ON [PRIMARY];

/****** Objeto:  Index [idx_persona_cuitcuil]    
Fecha de la secuencia de comandos: 05/26/2010 13:44:35 ******/
CREATE NONCLUSTERED INDEX [idx_persona_cuitcuil] 
ON [dbo].[Persona] (
	[prs_cuit] ASC
) WITH (
PAD_INDEX  = OFF, 
SORT_IN_TEMPDB = OFF, 
DROP_EXISTING = OFF, 
IGNORE_DUP_KEY = OFF, 
ONLINE = OFF) 
ON [PRIMARY];

/****** Objeto:  Index [idx_persona_cuitcuil]    
Fecha de la secuencia de comandos: 05/26/2010 13:44:35 ******/
CREATE NONCLUSTERED INDEX [idx_persona_trabajo] 
ON [dbo].[Persona] (
	[prs_trabajo] ASC
) WITH (
PAD_INDEX  = OFF, 
SORT_IN_TEMPDB = OFF, 
DROP_EXISTING = OFF, 
IGNORE_DUP_KEY = OFF, 
ONLINE = OFF) 
ON [PRIMARY];