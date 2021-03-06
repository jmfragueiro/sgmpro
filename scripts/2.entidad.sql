insert into entidad
		([ent_id],[ent_codigo],[ent_nombre],[ent_cuit],[ent_tramostemporales],[ent_activada],[ent_direccion]
		,[ent_cp],[ent_telefono],[ent_fax],[ent_contacto],[ent_email],[ent_fechaumod],[ent_fechabaja])
select [ent_id],[ent_codigo],[ent_nombre],[ent_cuit],[ent_tramostemporales],[ent_activada],[ent_direccion]
		,[ent_cp],[ent_telefono],[ent_fax],[ent_contacto],[ent_email],[ent_fechaumod],[ent_fechabaja]
  from [sgmprold].[dbo].[Entidad];

insert into producto
		([pro_id],[pro_entidad],[pro_codigo],[pro_nombre],[pro_descripcion],[pro_punitorio]
       ,[pro_activado],[pro_fechumod],[pro_fechabaja])
select [pro_id],[pro_entidad],[pro_codigo],[pro_nombre],[pro_descripcion],[pro_punitorio]
       ,[pro_activado],[pro_fechumod],[pro_fechabaja]
  from [sgmprold].[dbo].[Producto];

insert into tramo
	   ([tra_id],[tra_entidad],[tra_nombre],[tra_limite],[tra_fechaumod],[tra_fechabaja])
select [tra_id],[tra_entidad],[tra_nombre],[tra_limite],[tra_fechaumod],[tra_fechabaja]
  from [sgmprold].[dbo].[Tramo];