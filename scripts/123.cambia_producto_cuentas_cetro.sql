select *
from cuenta
where cta_entidad = '283d8641-a584-4b7f-91f4-54dabf00455b' 
--and cta_producto = 'e8956056-37c1-4cdb-bef3-ca485703a56a'
--and cta_fechabaja = '01/01/1753 00:00:00'
--and cta_descripcion not like '(MIGRADO)%'
and cta_descripcion like '%54%'
and cta_descripcion not like '%:54%'
order by cta_descripcion

select * from cuenta where cta_codigo = '30615407'

update cuenta
set cta_producto = (select pro_id from producto where pro_codigo = 'CETRO-SUC-37')
where cta_entidad = '283d8641-a584-4b7f-91f4-54dabf00455b' 
and cta_producto = 'e8956056-37c1-4cdb-bef3-ca485703a56a'
and cta_fechabaja = '01/01/1753 00:00:00'
and cta_descripcion not like '(MIGRADO)%'
and cta_descripcion like '%37%'
and cta_descripcion not like '%:37%';

update cuenta
set cta_producto = (select pro_id from producto where pro_codigo = 'CETRO-SUC-38')
where cta_entidad = '283d8641-a584-4b7f-91f4-54dabf00455b' 
and cta_producto = 'e8956056-37c1-4cdb-bef3-ca485703a56a'
and cta_fechabaja = '01/01/1753 00:00:00'
and cta_descripcion not like '(MIGRADO)%'
and cta_descripcion like '%38%'
and cta_descripcion not like '%:38%';

update cuenta
set cta_producto = (select pro_id from producto where pro_codigo = 'CETRO-SUC-31')
where cta_entidad = '283d8641-a584-4b7f-91f4-54dabf00455b' 
and cta_producto = 'e8956056-37c1-4cdb-bef3-ca485703a56a'
and cta_fechabaja = '01/01/1753 00:00:00'
and cta_descripcion not like '(MIGRADO)%'
and cta_descripcion like '%31%'
and cta_descripcion not like '%:31%'
and cta_descripcion not like '%31/%';