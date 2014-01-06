select * from actd where act_id = '2CC2AC51-08E4-4796-B57C-C3F09746D35E'

select act_id, deu_id, datediff(dd,deu_fechavto,getdate()),getdate(),deu_fechavto, deu_capital, deu_capitalo 
  from deuda, actd
 where deu_cuenta = act_id
  and act_id = '339C5C9B-A314-45A4-863B-84DDEC848DE9'

SELECT * FROM DEUDA WHERE DEU_CONVENIO IS NOT NULL

select (1307.37 * 0.01 * 31)

select 928 /30

select * from deuda where deu_cuenta = (select cta_id from cuenta where cta_codigo = 'S85872')

update deuda set deu_capital = 1450 where deu_cuenta = (select cta_id from cuenta where cta_codigo = 'S85872')

update tramo set tra_punitorio = 0.03, tra_honorario = 20

select * from tramo

select 1/30