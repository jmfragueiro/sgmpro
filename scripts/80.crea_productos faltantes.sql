INSERT INTO [Producto] ([pro_id],[pro_entidad],[pro_codigo],[pro_nombre],[pro_descripcion],[pro_activado],[pro_fechabaja],[pro_actualizar],[pro_tramostemporales],[pro_deudaencuotas],[pro_formulaimputacion],[pro_unificagastos]) VALUES ('9B0F1C76-4020-4004-B4E1-FD8BC6C70FAD','A3775B33-965B-422A-A52F-60A4AFA0C5CB','RAMOS-GRAL','RAMOS-GRAL',	'PRODUCTO GENERAL DE ENTIDAD RAMOS',1, '1753-01-01 00:00:00.000',0,1,0,'G100:H20:C100:I100',0);
INSERT INTO [Producto] ([pro_id],[pro_entidad],[pro_codigo],[pro_nombre],[pro_descripcion],[pro_activado],[pro_fechabaja],[pro_actualizar],[pro_tramostemporales],[pro_deudaencuotas],[pro_formulaimputacion],[pro_unificagastos]) VALUES ('F5D05E8B-A63C-4709-96D2-2EFA355C9440','54AB3649-3B70-4438-B72B-0634FE861545','CABAÑAS-GRAL','CABAÑAS-GRAL',	'PRODUCTO GENERAL DE ENTIDAD CABAÑAS',1, '1753-01-01 00:00:00.000',0,1,0,'G100:H20:C100:I100',0);
INSERT INTO [Producto] ([pro_id],[pro_entidad],[pro_codigo],[pro_nombre],[pro_descripcion],[pro_activado],[pro_fechabaja],[pro_actualizar],[pro_tramostemporales],[pro_deudaencuotas],[pro_formulaimputacion],[pro_unificagastos]) VALUES ('1D9FDA2B-C417-455D-8311-5713C832650E','535CFF2C-3858-4529-8DF5-6AC5985AA58E','HARDMICRO-GRAL','HARDMICRO-GRAL',	'PRODUCTO GENERAL DE ENTIDAD NEW HARD MICRO SRL',1, '1753-01-01 00:00:00.000',0,1,0,'G100:H20:C100:I100',0);

insert into tramo (tra_id, tra_producto, tra_nombre, tra_limite, tra_punitorio, tra_honorario, tra_fechabaja) 
select newid(), pro_id, 'GENERAL', 9999, (3*12/365), 20, '1753-01-01 00:00:00.000'  
  from producto
 where pro_id in ('9B0F1C76-4020-4004-B4E1-FD8BC6C70FAD','F5D05E8B-A63C-4709-96D2-2EFA355C9440'
	 			 ,'1D9FDA2B-C417-455D-8311-5713C832650E');

insert into tramo (tra_id, tra_producto, tra_nombre, tra_limite, tra_punitorio, tra_honorario, tra_fechabaja)
select newid(), pro_id, 'LEGAL', 9999, (3*12/365), 20, '1753-01-01 00:00:00.000'  
  from producto
 where pro_id in ('9B0F1C76-4020-4004-B4E1-FD8BC6C70FAD','F5D05E8B-A63C-4709-96D2-2EFA355C9440'
				 ,'1D9FDA2B-C417-455D-8311-5713C832650E');

