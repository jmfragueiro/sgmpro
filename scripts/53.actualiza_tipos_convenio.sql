--select * from tipoconvenio

update tipoconvenio 
   set tcn_mincuotas = 1, tcn_maxcuotas = 36, 
	   tcn_valorminimocuota = 10, tcn_honorarios = 20,
	   tcn_punitorio = (2.5*12/365);	


