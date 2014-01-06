select cta_codigo ficha, prs_dni dni, prs_nombre nombre, 
	   ltrim(rtrim(replace(replace(replace(replace(replace(replace(replace(
	   replace(replace(replace(replace(replace(replace(con_descripcion, '(MIGRADO)', ''), 'EMPLEO:', ''), 
	   'JUB ', 'JUBILADO'), 'IPS', 'PUBLICO PROVINCIAL'), '()', ''), 'Trabajo:', ''), 
	   '()', ''), '-', ''), 'FIJO DDRA', ''), '.', ''), 'DE EMSA', 'PUBLICO PROVINCIAL'), 
	   'IPS', 'PUBLICO PROVINCIAL'),'Bº CULMEY /', ''))) tipo, 
	   con_localidad localidad, con_provincia provincia
  from contacto, persona, cuenta  
 where con_descripcion like '%JUB%'
   and con_descripcion not like '%PAMI%'
   and con_descripcion not like '%ASOC%'
   and con_descripcion not like '%INSTITUTO%'	
   and con_persona = prs_id 
   and prs_id      = cta_titular
   and cta_entidad in ('B4A6DF3D-F656-489F-85CD-8F6A179EDEDB','2D70F380-9D17-43C7-9DB8-45733F5CBCA6')
order by tipo
