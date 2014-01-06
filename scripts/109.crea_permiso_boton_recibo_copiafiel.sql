insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values ('8AF73053-EEB6-43E7-A88D-928468B2AAAE','BOTON.RECIBO.COPIAFIEL','BOTON.RECIBO.COPIAFIEL',1,2,0,0,NULL,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);

insert into Permiso 
values(newid(),5,'01/01/1753','8AF73053-EEB6-43E7-A88D-928468B2AAAE');

select * from parametro where par_clave = 'BOTON.RECIBO.COPIAFIEL'