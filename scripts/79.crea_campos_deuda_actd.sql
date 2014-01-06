alter table deuda add deu_actdval float null;
alter table deuda add deu_actdfec datetime null;
update deuda set deu_actdval = 0, deu_actdfec = deu_fechavto;