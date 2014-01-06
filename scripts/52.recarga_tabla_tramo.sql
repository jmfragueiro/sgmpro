--select * from tramo

delete from tramo;

insert into tramo 
	   (tra_id, tra_producto, tra_nombre, tra_limite, tra_punitorio, tra_honorario, tra_fechabaja)
select newid(), pro_id, 'GENERAL', 9999, (3*12/365), 20, '1753-01-01 00:00:00.000'  
  from producto;

insert into tramo 
	   (tra_id, tra_producto, tra_nombre, tra_limite, tra_punitorio, tra_honorario, tra_fechabaja)
select newid(), pro_id, 'LEGAL', 9999, (3*12/365), 20, '1753-01-01 00:00:00.000'  
  from producto;