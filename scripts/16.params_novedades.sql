select * from parametro where par_clave like 'MENU.INTERFA%' order by par_ORDEN

update parametro set par_nombre = 'Novedades de Saldos', par_valorstring = 'cuCargaMasiva.CUCargaNovedades:SALDOS' where par_clave = 'MENU.INTERFACES.UPDATEMOVIMIENTOS'
update parametro set par_nombre = 'Asignación de Cuentas', par_valorstring = 'cuCargaMasiva.CUCargaNovedades:CUENTAS' where par_clave = 'MENU.INTERFACES.UPDATECUENTAS'
update parametro set par_nombre = 'Novedades de Pagos', par_valorstring = 'cuCargaMasiva.CUCargaNovedades:PAGOS' where par_clave = 'MENU.INTERFACES.UPDATEPERSONAS'