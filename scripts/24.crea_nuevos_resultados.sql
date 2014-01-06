update parametro 
   set par_valorstring = 'Fecha de Promesa' 
 where par_id = '9232D34C-1748-4E00-9588-C284DFD30717';

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'RESULTADOGESTION.PROMESAPAGOCUOTA','PROMESA PAGO CUOTA',1,6,19,1,'Fecha de Promesa',
		1,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'RESULTADOGESTION.REINTENTARCONTACTO','REINTENTAR CONTACTO',1,6,20,0,'Fecha de Reintento',
		1,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar) 
values (newid(),'RESULTADOGESTION.EVIOPOSTAL','ENVIAR CORREO',1,6,21,0,null,
		1,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '');

insert into parametro (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorstring, 
						par_valorbool, par_valorlong, par_valordate, par_valordouble, par_fechabaja) 
values (newid(),'GESTION.MAXREPGESTIONES.SC','MAXIMA CANTIDAD DE GESTIONES REPETIDAS SOLICITA CTO',2,6,8,
		'La fecha utilizada como base para tomar la del recibo',0,4,'1753-01-01 00:00:00.000',
		0,'1753-01-01 00:00:00.000');

insert into parametro (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorstring, 
						par_valorbool, par_valorlong, par_valordate, par_valordouble, par_fechabaja) 
values (newid(),'GESTION.MAXREPGESTIONES.RC','MAXIMA CANTIDAD DE GESTIONES REPETIDAS REINTENTA CTO',2,6,9,
		'La fecha utilizada como base para tomar la del recibo',0,4,'1753-01-01 00:00:00.000',
		0,'1753-01-01 00:00:00.000');

insert into parametro (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorstring, 
					   par_valorlong, par_valorbool, par_valordate, par_valordouble, par_fechabaja) 
values (newid(),'TIPOPAGO.SALDOINSOLUTO','DJ SALDO INSOLUTO',1,6,7,'DJ SALDO INSOLUTO',0,0,
		'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000');

insert into Parametro
values ('3B69C79F-16B8-41A1-A0A5-895A330DFB72','MENU.INTERFACES.DESASIGNAR',
'Desasignar Cuentas',1,4,7,0,'cuCargaMasiva.CUCargaNovedades:DESASIGNAR',
'01/01/1753',null,0,0,'01/01/1753')

insert into Permiso
values('DA008A3B-B1D9-4220-B29D-1A853EA49D17',5,'01/01/1753','3B69C79F-16B8-41A1-A0A5-895A330DFB72')

insert into Rol_Permiso
values('afcd4962-c766-4895-8d2f-8a552755477a','DA008A3B-B1D9-4220-B29D-1A853EA49D17')
