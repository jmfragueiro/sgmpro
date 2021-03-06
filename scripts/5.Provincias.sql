insert into parametro
	   ([par_id],[par_clave],[par_nombre],[par_clase],[par_tipo],[par_orden],[par_valorlong]
       ,[par_valorstring],[par_valordate],[par_valorchar],[par_valorbool],[par_valordouble]
       ,[par_fechabaja])
select [par_id],[par_clave],[par_nombre],[par_clase],[par_tipo],[par_orden],[par_valorlong]
       ,[par_valorstring],[par_valordate],[par_valorchar],[par_valorbool],[par_valordouble]
       ,[par_fechabaja]
  from [sgmprold].[dbo].[Parametro]
 where (par_clave like 'PROVINCIA%' or par_clave like 'LOCALIDAD%')
   and par_clave not like '%PAIS%';
