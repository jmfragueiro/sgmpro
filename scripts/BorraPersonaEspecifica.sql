--select * from persona where prs_dni = '28256659'

-- BORRA LA PERSONA INDICADA
-- (NOTA: si hay que redireccionar la cuenta hay que ver contactos y titular)
delete from gestion where ges_cuenta = '2E767470-09DE-4633-9526-E22931777F1A'
delete from contacto where con_persona = '457A1D8C-9DAA-4022-88CD-3404FA10F1D5'
delete from deuda where deu_cuenta = '2E767470-09DE-4633-9526-E22931777F1A'
delete from estadocuenta where esc_cuenta = '2E767470-09DE-4633-9526-E22931777F1A'
delete from cuenta where cta_id = '2E767470-09DE-4633-9526-E22931777F1A'
delete from persona where prs_id = '457A1D8C-9DAA-4022-88CD-3404FA10F1D5'
