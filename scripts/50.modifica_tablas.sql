--dropeo de tablas
drop table dbo.StepJobGenListaGestion_Entidad;
drop table dbo.StepJobLisGes_Entidad;
drop table dbo.StepJobGenListaGestion;
drop table dbo.JobGenListaGestion;

--tabla deuda
alter table deuda add deu_capitalo float null default 0;
alter table deuda add deu_intereso float null default 0;
alter table deuda add deu_honoro float null default 0;
alter table deuda add deu_gastoso float null default 0;

--tabla cuenta
alter table cuenta add cta_actd float null default 0;
alter table cuenta add cta_gestor uniqueidentifier null;
alter table cuenta with check add constraint [fk_Cuenta_Gestor] foreign key([cta_gestor]) references [dbo].[usuario] ([usu_id]);
alter table cuenta check constraint [fk_Cuenta_Gestor];
create nonclustered index [ifx_cuenta_gestor] on [dbo].[cuenta] ([cta_gestor] asc) with (pad_index  = off, statistics_norecompute  = off, sort_in_tempdb = off, ignore_dup_key = off, drop_existing = off, online = off, allow_row_locks  = on, allow_page_locks  = off) on [primary];

--tabla producto
alter table producto drop column pro_fechumod;
alter table producto drop column pro_punitorio;
alter table producto add pro_actualizar bit not null default 0;
alter table producto add pro_tramostemporales bit not null default 0;
alter table producto add pro_deudaencuotas bit not null default 0;
alter table producto add pro_formulaimputacion nvarchar(255) not null default '0';
alter table producto add pro_unificagastos bit not null default 0;

--tabla entidad
alter table entidad drop column ent_fechaumod;
alter table entidad drop constraint DF__Entidad__ent_sal__41EDCAC5;
alter table entidad drop column ent_saldoespecial;
alter table entidad drop column ent_tramostemporales;

--tabla tipoconvenio
alter table tipoconvenio drop column tcn_cuotaaviso;
alter table tipoconvenio drop column tcn_regla20;
alter table tipoconvenio add tcn_mincuotas bigint not null default 0;
alter table tipoconvenio add tcn_punitorio float null;
alter table tipoconvenio add tcn_valorminimocuota bigint not null default 0;
alter table tipoconvenio add tcn_formulabaseconvenio nvarchar(255) not null default '0';
alter table tipoconvenio add tcn_valorminimoanticipo float null default 0;
alter table tipoconvenio add tcn_maxquita float null default 0;
alter table tipoconvenio add tcn_reglaha float null default 0;
alter table tipoconvenio add tcn_honorarios float null default 0;

--tabla convenio
alter table convenio add cvn_capitalorigen float null  default 0;
alter table convenio add cvn_honorariosorigen float null  default 0;
alter table convenio add cvn_interesorigen float null  default 0;
alter table convenio add cvn_gastosorigen float null  default 0;
alter table convenio add cvn_gastosanticipo float null  default 0;
alter table convenio add cvn_deudabase float null  default 0;

--tabla tempgenlis
alter table tempgenlis add tgl_gestor nvarchar(255) null;

--tabla tipolistagestion
alter table tipolistagestion drop column tlg_FechaUMod;
alter table tipolistagestion add tlg_prioridad bigint null default 0;
alter table tipolistagestion drop column tlg_FechaAlta;
alter table tipolistagestion add tlg_fechaalta datetime null;

-- esto correr despues!!!! (en una segunda corrida)!!!
/*
update convenio set cvn_deudabase = cvn_deudaoriginal, cvn_gastosanticipo = cvn_gastos;
alter table convenio drop column cvn_gastos;
alter table convenio drop column cvn_deudaoriginal;
update tipolistagestion set tlg_prioridad = 0
*/
