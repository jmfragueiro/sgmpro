select * from parametro where par_clave like 'DETALLEDEUDA%' ORDER BY PAR_ORDEN

update parametro set par_nombre = 'CONVENIO PAGO', par_valorstring = 'CONVENIO PAGO' where par_clave = 'CONCEPTODEUDA.CONVENIO';
update parametro set par_nombre = 'DEUDA ORIGEN', par_valorstring = 'DEUDA ORIGEN' where par_clave = 'CONCEPTODEUDA.ORIGEN';

update parametro set par_nombre = 'ATRASO ANTICIPO/CUOTA', par_valorstring = 'ATRASO ANTICIPO/CUOTA' where par_clave = 'DETALLEDEUDA.ATRASO';
