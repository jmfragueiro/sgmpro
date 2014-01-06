delete
  from contacto
 where con_fechaumod > convert(datetime, '2012-08-27 00:00:00', 121)
   and con_persona in (select cta_titular 
				         from cuenta 
				        where cta_entidad = '39FFFA7B-C518-42CF-AF6F-1514EE5CAB25' 
				          and cta_descripcion like '%27/08/2012%');

delete from deuda
 where deu_cuenta in (select cta_id
			            from cuenta 
			           where cta_entidad = '39FFFA7B-C518-42CF-AF6F-1514EE5CAB25' 
			             and cta_descripcion like '%27/08/2012%');
delete from cuenta
 where cta_entidad = '39FFFA7B-C518-42CF-AF6F-1514EE5CAB25' 
   and cta_descripcion like '%27/08/2012%';

delete
  from persona
 where prs_comentario like '%27/08/2012%';
