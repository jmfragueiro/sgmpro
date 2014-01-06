insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'TIPOSALDO.INFORMADA','SALDO DEUDA INFORMADA',1,6,1,null,null,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'TIPOSALDO.NOINFORMADA','SALDO DEUDA NO INFORMADA',1,6,2,null,null,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'TIPOSALDO.CONVENIO','SALDO CUOTAS CONVENIO',1,6,3,null,null,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

