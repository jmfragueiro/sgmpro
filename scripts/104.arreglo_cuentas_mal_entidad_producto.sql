update cuenta 
   set cta_entidad  = 'B4A6DF3D-F656-489F-85CD-8F6A179EDEDB',
       cta_producto = '118B1DAA-2BC0-4025-AD0B-78B5435D1DBD'
 where cta_codigo in ('S64050','S65347','S65735','S70873','S80519','S85950','S85953','S86074','S94061');
       
update cuenta 
   set cta_entidad  = '2D70F380-9D17-43C7-9DB8-45733F5CBCA6',
       cta_producto = 'EF203403-71A6-48C9-9D6A-82C8B7410446'
 where cta_codigo in ('C18369','C43237','C53370','C53374','C53390','C88257');

select * 
  from cuenta 
 where cta_codigo in ('C18369','C43237','C88257')
