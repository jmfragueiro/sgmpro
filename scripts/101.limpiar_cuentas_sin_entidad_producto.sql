delete from imputacion where imp_deuda in (select deu_id from deuda where deu_cuenta in (select cta_id from cuenta where cta_entidad is null));

delete from recibo where rec_pago in (select pag_id from pago where pag_cuenta in (select cta_id from cuenta where cta_entidad is null));

delete from pago where pag_cuenta in (select cta_id from cuenta where cta_entidad is null);

delete from deuda where deu_cuenta in (select cta_id from cuenta where cta_entidad is null);

delete from gestion where ges_cuenta in (select cta_id from cuenta where cta_entidad is null);

delete from cuenta where cta_entidad is null;

delete from imputacion where imp_deuda in (select deu_id from deuda where deu_cuenta in (select cta_id from cuenta where cta_producto is null));

delete from recibo where rec_pago in (select pag_id from pago where pag_cuenta in (select cta_id from cuenta where cta_producto is null));

delete from pago where pag_cuenta in (select cta_id from cuenta where cta_producto is null);

delete from deuda where deu_cuenta in (select cta_id from cuenta where cta_producto is null);

delete from gestion where ges_cuenta in (select cta_id from cuenta where cta_producto is null);

delete from cuenta where cta_producto is null;

--select * from cuenta where cta_producto is null