USE [sgmpro]
GO
/****** Objeto:  View [dbo].[v_listaGestionesGeneradas]    Fecha de la secuencia de comandos: 05/28/2012 15:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop view [dbo].[v_listaGestionesGeneradas]
GO
CREATE view [dbo].[v_listaGestionesGeneradas]
as
/*******************************************************
  Vista que genera los datos para el listado de 
  Gestiones a realizarse. Esta pensada para las listas
  que se exporataran.
********************************************************/
select tip.par_valorstring TipoGestion,
	   est.par_valorstring Estado,
	   cue.cta_codigo Cuenta,
	   tit.prs_nombre Nombre,
	   tit.prs_dni DNI,
	   (cto.con_calle+ ' '+cto.con_puerta+ ' '+cto.con_pisodepto) Domicilio,
	   cto.con_telefono1 Telefono1,
	   cto.con_telefono1 Telefono2,
	   cto.con_celular Celular,
	   cto.con_fax Fax,
	   cto.con_cp CP,
	   loc.par_nombre Localidad,
	   lge.lge_nombre NombreLista,
	   tip.par_valorstring TipoLista,
	   lge.lge_fchcreacion FechaCreacion,
	   lge.lge_id ID 
  from Gestion ges
 inner join dbo.Parametro    tip ON ges.ges_tipo      = tip.par_id
 inner join dbo.Parametro    est ON ges.ges_estado    = est.par_id
 inner join dbo.Cuenta       cue ON ges.ges_cuenta    = cue.cta_id
 inner join dbo.Persona      tit ON cue.cta_titular   = tit.prs_id
 inner joiN dbo.ListaGestion lge ON ges.ges_lista     = lge.lge_id
 inner join dbo.Contacto     cto ON cto.con_persona   = tit.prs_id
 inner join dbo.Parametro    loc ON cto.con_localidad = loc.par_id
 where cto.con_principal = 1
   and cto.con_fechaumod = (select max(e.con_fechaumod)
                              from contacto e
                             where e.con_persona   = tit.prs_id
                               and e.con_principal = 1)
   and lge.lge_fechabaja = convert(datetime, '1753-01-01 00:00:000', 121)
   
