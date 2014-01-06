--select * from parametro where par_clave like 'BOTON%'

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values ('AE7270E4-0509-45F9-9F56-9E89154FFA62','BOTON.CUENTA.AJUSTAR','BOTON.CUENTA.AJUSTAR',1,2,0,0,NULL,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);

insert into Permiso 
values(newid(),5,'01/01/1753','AE7270E4-0509-45F9-9F56-9E89154FFA62');