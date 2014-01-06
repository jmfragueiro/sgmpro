update c
   set c.cta_descripcion = substring(c.cta_descripcion + ' CODIGO ANTERIOR:' + c.cta_codigo, 1, 255), 
	   c.cta_codigo = '531'+(select isnull(p.prs_dni, c.cta_codigo) from persona p where p.prs_id = c.cta_titular) 
  from cuenta c
 where c.cta_entidad = '39FFFA7B-C518-42CF-AF6F-1514EE5CAB25'

