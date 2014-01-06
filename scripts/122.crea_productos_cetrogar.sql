delete from Producto where pro_entidad = '283d8641-a584-4b7f-91f4-54dabf00455b' and pro_id <> 'e8956056-37c1-4cdb-bef3-ca485703a56a'

select * from producto where pro_entidad = '283d8641-a584-4b7f-91f4-54dabf00455b'

insert into producto 
select newid(), pro_entidad, 'CETRO-SUC-31', 'CETRO SUC.31 POSADAS', 
       'PRODUCTO GENERAL PARA SUCURSAL 31 (POSADAS)', pro_activado, 
       pro_fechabaja, pro_actualizar, pro_tramostemporales, pro_deudaencuotas, 
       pro_formulaimputacion, pro_unificagastos
  from producto where pro_id = 'e8956056-37c1-4cdb-bef3-ca485703a56a';
insert into producto 
select newid(), pro_entidad, 'CETRO-SUC-38', 'CETRO SUC.38 PSS/VIRASORO', 
       'PRODUCTO GENERAL PARA SUCURSAL 38 (POSADAS-VIRASORO)', pro_activado, 
       pro_fechabaja, pro_actualizar, pro_tramostemporales, pro_deudaencuotas, 
       pro_formulaimputacion, pro_unificagastos
  from producto where pro_id = 'e8956056-37c1-4cdb-bef3-ca485703a56a';
insert into producto 
select newid(), pro_entidad, 'CETRO-SUC-54', 'CETRO SUC.54 IGUAZU', 
       'PRODUCTO GENERAL PARA SUCURSAL 54 (IGUAZU)', pro_activado, 
       pro_fechabaja, pro_actualizar, pro_tramostemporales, pro_deudaencuotas, 
       pro_formulaimputacion, pro_unificagastos
  from producto where pro_id = 'e8956056-37c1-4cdb-bef3-ca485703a56a';
insert into producto 
select newid(), pro_entidad, 'CETRO-SUC-35', 'CETRO SUC.35 APOSTOLES', 
       'PRODUCTO GENERAL PARA SUCURSAL 35 (APOSTOLES)', pro_activado, 
       pro_fechabaja, pro_actualizar, pro_tramostemporales, pro_deudaencuotas, 
       pro_formulaimputacion, pro_unificagastos
  from producto where pro_id = 'e8956056-37c1-4cdb-bef3-ca485703a56a';
insert into producto 
select newid(), pro_entidad, 'CETRO-SUC-37', 'CETRO SUC.37', 
       'PRODUCTO GENERAL PARA SUCURSAL 37', pro_activado, 
       pro_fechabaja, pro_actualizar, pro_tramostemporales, pro_deudaencuotas, 
       pro_formulaimputacion, pro_unificagastos
  from producto where pro_id = 'e8956056-37c1-4cdb-bef3-ca485703a56a';  