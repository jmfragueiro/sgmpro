--select * from parametro where par_clave like 'ENTIDAD.DE%'

--select * from permiso where per_recurso = 'E239857F-AD13-4886-86CB-783375F778C1' order by per_tipo

--select * from parametro where par_clave like 'ENTIDAD.PA%'

--select * from permiso where per_recurso = '7ACAB3A4-C3C9-4820-AFD5-81941CA47596' order by per_tipo

--select * from permiso where per_recurso = 'A15D3D4A-AA41-41C7-A246-1714B3F83A21' order by per_tipo

-- DEUDA REMOVER
insert into Permiso 
values(newid(),4,'01/01/1753','E239857F-AD13-4886-86CB-783375F778C1');

-- PAGO EJECUTAR
insert into Permiso 
values(newid(),5,'01/01/1753','7ACAB3A4-C3C9-4820-AFD5-81941CA47596');