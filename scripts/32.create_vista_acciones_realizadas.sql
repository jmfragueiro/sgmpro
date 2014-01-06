USE [sgmpro];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
--ALTER VIEW [dbo].[v_lista_acciones_realizadas]
--AS
select per.prs_dni Dni, per.prs_nombre Nombre,
count (case when tge.par_clave = 'TIPOGESTION.POSTAL' Then 1 End) Postal,
count (case when tge.par_clave = 'TIPOGESTION.TELEFONICA' Then 1 End) Telef,
count (case when tge.par_clave = 'TIPOGESTION.TERRENO' Then 1 End) Terreno,
count (case when tge.par_clave = 'TIPOGESTION.ADMINISTRATIVA' Then 1 End) Admin,
count (case when tge.par_clave = 'TIPOGESTION.BACKOFFICE' Then 1 End) BackOf,
count (case when tge.par_clave = 'TIPOGESTION.LEGAL' Then 1 End) Legal,

count (case when tre.par_clave = 'RESULTADOGESTION.CONTACTO' Then 1 End) Contacto,
count (case when tre.par_clave = 'RESULTADOGESTION.NOCONTACTADO' Then 1 End) NoCont,
count (case when tre.par_clave = 'RESULTADOGESTION.CONTACTOINVALIDO' Then 1 End) ContInv,
count (case when tre.par_clave = 'RESULTADOGESTION.PROMESAPAGO' Then 1 End) Promesa,
count (case when tre.par_clave = 'RESULTADOGESTION.PAGODEUDA' Then 1 End) Pago,
count (case when tre.par_clave = 'RESULTADOGESTION.NUEVOSDATOS' Then 1 End) NuevosDat,
count (case when tre.par_clave = 'RESULTADOGESTION.ALTACONVENIO' Then 1 End) Convenio,

count (case tre.par_clave When 'RESULTADOGESTION.OTRORESULTADO' Then 1 
when 'RESULTADOGESTION.POSITIVA' Then 1 
when 'RESULTADOGESTION.PROMESAPAGOCUOTA' Then 1
when 'RESULTADOGESTION.REINTENTARCONTACTO' Then 1
when 'RESULTADOGESTION.SINVOLUNTAD' Then 1
when 'RESULTADOGESTION.SOLICITACONTACTO' Then 1
when 'RESULTADOGESTION.AGOTADA' Then 1
when 'RESULTADOGESTION.BAJAPEDIDO' Then 1 
when 'RESULTADOGESTION.CANCELACION' Then 1
when 'RESULTADOGESTION.CANCELATOTAL' Then 1
when 'RESULTADOGESTION.EVIOPOSTAL' Then 1
when 'RESULTADOGESTION.FALLECIDO' Then 1
when 'RESULTADOGESTION.NEGATIVA' Then 1
End) Otros,
ges.ges_fechainicio Fecha
from Cuenta cta
inner join Persona per on cta.cta_titular = per.prs_id
inner join Gestion ges on ges.ges_cuenta = cta.cta_id
inner join Parametro tge on ges.ges_tipo = tge.par_id
inner join Parametro tre on ges.ges_resultado = tre.par_id
group by per.prs_dni,per.prs_nombre, ges.ges_fechainicio
GO

-- Permisos para el informa de actividades
insert into parametro values ('f7184146-6b84-4766-986c-16d7d2c4ffd6','MENU.INFORMES.ACCIONES', 'Acciones Realizadas',1,4,7,0,'cuGenerarInformes.CUAccionesRealizadas','01/01/1753',null,0,0,'01/01/1753');
insert into Permiso values('2B8D8E74-C805-41FD-85B8-E37026DCB4A0',5,'01/01/1753','f7184146-6b84-4766-986c-16d7d2c4ffd6');
insert into Rol_Permiso values('afcd4962-c766-4895-8d2f-8a552755477a','2B8D8E74-C805-41FD-85B8-E37026DCB4A0');