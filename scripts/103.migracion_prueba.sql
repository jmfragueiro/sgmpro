select * from cuenta where cta_entidad = '283D8641-A584-4B7F-91F4-54DABF00455B'

select * from producto where pro_entidad = '283D8641-A584-4B7F-91F4-54DABF00455B'


insert into tramo values (newid(), 'E8956056-37C1-4CDB-BEF3-CA485703A56A', 'INICIAL', 60, 0.0657, 15, '1753-01-01 00:00:00.000')

update tramo set tra_punitorio = 0.07512, tra_honorario = 10 where tra_id = '424162D5-E4E9-4AE7-A6A1-85370A09842B'

update tipoconvenio set tcn_punitorio = 0.0657;

update producto set pro_actualizar = 1, pro_tramostemporales = 1 where pro_id = 'E8956056-37C1-4CDB-BEF3-CA485703A56A'

select * from tramo where tra_producto = 'E8956056-37C1-4CDB-BEF3-CA485703A56A'

select * from actd --where act_tipo = 'T' order by act_hono

select * from cuenta where cta_id = '1544D072-9E72-4AB9-A66D-FFB564E7CA42'--inicial:7553647

select * from cuenta where cta_id = '15BA30AC-D3D8-4187-B818-FFBE94DBE2E1'--general:29010333

select * from cuenta where cta_id = '788F8D03-EDBD-4F9D-AF06-0026CA74965D'--legal:31792220

select * from cuenta where cta_convenioactivo = '1493EC76-D68C-4E73-A223-002138FB65DC'--convenio:S93273

UPDATE DEUDA SET DEU_INTERES = DEU_INTERESO

