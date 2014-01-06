select * from parametro where par_clave like 'FORMAPAGO%' ORDER BY PAR_ORDEN

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valordate, par_valorchar, par_valorbool, par_valordouble, 
		par_fechabaja, par_valorint, par_valordouble2) 
values (newid(),'FORMAPAGO.CONTADO','CONTADO',1,6,7,0,'CONTADO','1753-01-01 00:00:00.000',
		'',0,0,'1753-01-01 00:00:00.000', 0, 0);

update parametro
   set par_valordouble = 21.0 
 where par_nombre in ('EFECTIVO','DOLARES','CHEQUE','DEPOSITO BCO', 'BONOS')
 
update parametro
   set par_valorchar = 'X' 
 where par_nombre = ('RECIBO X')
 