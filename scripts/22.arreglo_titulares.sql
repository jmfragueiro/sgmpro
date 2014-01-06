select * from persona where prs_dni = '0'

update cuenta 
   set cta_titular = (select prs_id from persona where prs_trabajo = cta_legales)
 where cta_titular = '2F32991A-3E09-44D2-A233-003F5493A699'



