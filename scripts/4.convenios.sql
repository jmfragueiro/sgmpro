insert into tipoconvenio
	   ([tcn_id],[tcn_nombre],[tcn_descripcion],[tcn_maxcuotas],[tcn_maxcuotascaidas],[tcn_cuotaaviso]
       ,[tcn_activo],[tcn_tasapura],[tcn_ivasobretp],[tcn_formulacuota],[tcn_formulainteres]
       ,[tcn_formulahonorarios],[tcn_formulagastos],[tcn_fechabaja])	
select *
  from [sgmprold].[dbo].[TipoConvenio];