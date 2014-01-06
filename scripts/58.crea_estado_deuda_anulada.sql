--select * from parametro where par_clave like 'ESTADODEUDA%' order by par_orden

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values (newid(),'ESTADODEUDA.ANULADA','ANULADA',1,6,3,0,'ANULADA',
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);