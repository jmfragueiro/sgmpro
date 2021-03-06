CREATE NONCLUSTERED INDEX [idx_gestion_usucierreini] ON [dbo].[Gestion] 
(
	[ges_usuario] ASC,
	[ges_fechacierre] ASC,
	[ges_fechainicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, 
IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, 
ALLOW_PAGE_LOCKS  = OFF) ON [PRIMARY]