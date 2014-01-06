delete
  from deuda 
 where deu_fechabaja > '1753-01-01 00:00:00.000'
   and not exists (select 1 from imputacion where imp_deuda = deu_id)
   and not exists (select 1 from convenio where cvn_cuenta = deu_cuenta);

update deuda 
set deu_capitalo = deu_capital, 
	deu_intereso = deu_interes, 
	deu_honoro = deu_honorarios, 
	deu_gastoso = deu_gastos;



