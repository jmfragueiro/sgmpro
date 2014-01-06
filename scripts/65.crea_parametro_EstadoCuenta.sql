--select * from parametro where par_clave like 'ENTIDAD%' order by par_orden

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		par_valorint, par_valordouble2) 
values (newid(),'ENTIDAD.ESTADOCUENTA','ENTIDAD.ESTADOCUENTA',1,2,0,0,null,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000','',0,0);