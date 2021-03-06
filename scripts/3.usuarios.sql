insert into usuario
	   ([usu_id],[usu_nombre],[usu_password],[usu_empleado],[usu_legajo],[usu_activado],[con_fechaumod],[con_fechabaja])
select [usu_id],[usu_nombre],[usu_password],[usu_empleado],[usu_legajo],[usu_activado],[con_fechaumod],[con_fechabaja]
  from [sgmprold].[dbo].[Usuario]
 where usu_nombre <> 'ADMIN';

insert into rol 
	   ([rol_id],[rol_nombre],[rol_descripcion],[rol_activado],[rol_fechabaja])
select [rol_id],[rol_nombre],[rol_descripcion],[rol_activado],[rol_fechabaja]
  from [sgmprold].[dbo].[Rol]
 where rol_nombre <> 'ADMIN'; 

insert into perfil
       ([prf_id],[prf_nombre],[prf_descripcion],[prf_activado],[prf_fechabaja])
select [prf_id],[prf_nombre],[prf_descripcion],[prf_activado],[prf_fechabaja]
  from [sgmprold].[dbo].[Perfil];

insert into rol_rol
	   ([rol_id_padre],[rol_id_hijo])
select [rol_id_padre],[rol_id_hijo]
  from [sgmprold].[dbo].[Rol_Rol];

insert into usuario_perfil
	   ([usu_id],[prf_id])
select [usu_id],[prf_id]
  from [sgmprold].[dbo].[Usuario_Perfil];

insert into usuario_rol
	   ([usu_id],[rol_id])
select [usu_id],[rol_id]
  from [sgmpro].[dbo].[Usuario_Rol];