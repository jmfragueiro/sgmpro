select * 
  from cuenta 
 where cta_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
   and cta_entidad is not null   
   and cta_activada  = 1
   and cta_convenioactivo is null
   and cta_producto  in (select pro_id
                           from producto
                          where pro_actualizar = 1
                            and pro_fechabaja  = convert(datetime, '1753-01-01 00:00:000', 121));

select *
  from tramo 
 where tra_producto in (select pro_id from producto where pro_actualizar = 1)
                                  