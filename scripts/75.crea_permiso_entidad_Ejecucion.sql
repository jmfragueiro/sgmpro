--select * from parametro where par_clave = 'ENTIDAD.EJECUCION'
--select * from permiso where per_recurso = (select par_id from parametro where par_clave = 'ENTIDAD.EJECUCION')

insert into permiso (per_id, per_tipo, per_fechabaja, per_recurso)
values (newid(), 1, '1753-01-01 00:00:00.000', 'AEF24011-6228-488D-BE13-2A784731ACAF')