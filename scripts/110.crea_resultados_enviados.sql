insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'RESULTADOGESTION.CORREOENTREGADO','POSTAL ENTREGADO',1,6,30,1,null,
		1,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'RESULTADOGESTION.TERRENOENTREGADO','TERRENO ENTREGADO',1,6,31,1,null,
		1,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

select * from parametro where par_clave = 'RESULTADOGESTION.TERRENOENTREGADO'