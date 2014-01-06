insert into parametro 
	   (par_id, par_clave, par_nombre, par_clase, par_tipo, par_orden, par_valorlong, 
		par_valorstring, par_valorbool, par_valordate, par_valordouble, par_fechabaja, par_valorchar,
		PAR_VALORINT, PAR_VALORDOUBLE2) 
values ('E5E18C88-6A11-4254-82B4-147B66E0AFF5','ACCION.CTA.-DESASIGNADA-POR-CLIENTE','ACCION ESTADO:DESASIGNAR CUENTA',1,2,0,0,NULL,
		0,'1753-01-01 00:00:00.000',0,'1753-01-01 00:00:00.000', '', 0, 0);

insert into Permiso 
values(newid(),5,'01/01/1753','E5E18C88-6A11-4254-82B4-147B66E0AFF5');

select * from parametro where par_clave like 'MENU%'

UPDATE PARAMETRO 
SET PAR_CLAVE = 'ACCION.CTA.-DESASIGNADA-POR-CLIENTE',
	PAR_NOMBRE = 'ACCION ESTADO:DESASIGNAR CUENTA'	
WHERE PAR_ID = 'E5E18C88-6A11-4254-82B4-147B66E0AFF5'
