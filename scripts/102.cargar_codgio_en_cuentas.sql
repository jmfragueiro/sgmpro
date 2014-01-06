update cuenta set cta_codigo = '00'+(select prs_dni from persona where prs_id = cta_titular) where cta_codigo = '';

select * from cuenta where cta_codigo = '';

