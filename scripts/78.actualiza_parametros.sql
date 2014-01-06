select * from tipoconvenio

update tipoconvenio 
   set tcn_maxcuotascaidas = 2,
       tcn_punitorio = 0.0329;

select * from tramo

update tramo
   set tra_punitorio = 0.0986,
       tra_honorario = 20
 where tra_nombre <> 'LEGAL';

update tramo
   set tra_punitorio = 0.0986,
       tra_honorario = 20
 where tra_nombre = 'LEGAL';