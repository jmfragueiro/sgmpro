--select * from parametro where par_clave like 'ENTIDAD%' order by par_clave

update parametro set par_clave = 'ENTIDAD.JOB', par_nombre = 'ENTIDAD.JOB' where par_clave = 'ENTIDAD.JOBGENLISTAGESTION'

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		par_valorint, par_valordouble2) 
values (newid(),'ENTIDAD.EJECUCION','ENTIDAD.EJECUCION',1,2,0,0,null,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000','',0,0);

--SELECT * FROM permiso where per_recurso =  'A34EBE11-B47B-4465-8611-1C3D1904A09B'