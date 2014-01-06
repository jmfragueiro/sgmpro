--select * from parametro where par_clave like 'BOTON%'

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values ('4547B226-7A71-4F8C-A16A-8EA1173B614C','BOTON.CUENTA.ASIGNAR','BOTON.CUENTA.ASIGNAR',1,2,0,0,NULL,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);

insert into Permiso 
values(newid(),5,'01/01/1753','4547B226-7A71-4F8C-A16A-8EA1173B614C');

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values ('0BE69E37-2103-4DF4-9033-D1C62001DA5F','BOTON.CUENTA.DESASIGNAR','BOTON.CUENTA.DESASIGNAR',1,2,0,0,NULL,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);

insert into Permiso 
values(newid(),5,'01/01/1753','0BE69E37-2103-4DF4-9033-D1C62001DA5F');