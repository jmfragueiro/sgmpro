update contacto
   set con_principal = 1
 where con_principal = 0
   and con_persona in (
	 select cta_titular
	   from cuenta
	  where not exists (
		select 1
		  from contacto
		 where con_persona   = cta_titular
		   and con_principal = 1))


