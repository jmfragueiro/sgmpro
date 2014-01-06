insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values ('F8D206B0-C974-42E8-80F6-0478AB621D2A','MENU.INTERFACES.PROMOCIONES','Carga de Promociones',1,4,8,0,
		'cuCargaMasiva.CUCargaNovedades:PROMOCIONES',0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

insert into Permiso 
values(newid(),5,'01/01/1753','F8D206B0-C974-42E8-80F6-0478AB621D2A');

