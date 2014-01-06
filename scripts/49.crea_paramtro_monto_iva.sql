insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values (newid(),'GESTION.IVA','PORCENTAJE DE IVA',2,6,10,0,'VALORDOUBLE CONTIENE EL PORCENTAJE DE IVA APLICABLE',
		0,'1753-01-01 00:00:00.000',21,'1753-01-01 00:00:00.000', '', 0, 0);

select * from parametro where par_clave like 'GESTION%' order by par_orden

update parametro 
set par_valorstring = 'VALORLONG = 1 SIGNIFICA QUE EL CONCEPTO GENERA PUNITORIOS. ORDEN <= 10 SON CONCEPTOS ELEGIBLES MANUALMENTE. CONCEPTO LEGALES SOLO PUEDE ELEGIR ALGUIEN CON PERMISO [DEUDA.TOTAL]. VALORBOOL = TRUE SIGNIFICA QUE ES DEUDA...'
where par_id = 'BBA3D929-7B07-4FBE-990E-CBEDA9FE9CC0'

select * from deuda where deu_convenio = '46AD74E9-F51E-4148-A9D5-458A85D1DE9A' order by deu_convenio, deu_cuota

update deuda 
set deu_capital = (deu_capital + deu_interes), deu_interes = 0 
where deu_convenio is not null and deu_interes < 0
and deu_convenio = '46AD74E9-F51E-4148-A9D5-458A85D1DE9A'


select * from parametro where par_clave like 'GESTION%'