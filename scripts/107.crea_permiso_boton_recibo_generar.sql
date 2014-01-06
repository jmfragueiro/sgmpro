insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values ('38B89D6D-A1D6-4AF0-A037-E5A3E9ACF540','BOTON.RECIBO.GENERAR','BOTON.RECIBO.GENERAR',1,2,0,0,NULL,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);

insert into Permiso 
values(newid(),5,'01/01/1753','38B89D6D-A1D6-4AF0-A037-E5A3E9ACF540');

update parametro set par_clave = 'BOTON.RECIBO.GENERAR' where par_id = '38B89D6D-A1D6-4AF0-A037-E5A3E9ACF540'

