insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values (newid(),'CONCEPTODEUDA.LEGALES','GASTOS LEGALES',1,6,4,0,'GASTOS LEGALES',
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);

insert into Permiso 
values(newid(),6,'01/01/1753','E239857F-AD13-4886-86CB-783375F778C1');
