insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'RESULTADOGESTION.PROMOCION','PROMOCION',1,6,32,1,null,
		1,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

select * from parametro where par_clave = 'RESULTADOGESTION.TERRENOENTREGADO'