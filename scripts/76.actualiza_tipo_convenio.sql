UPDATE [sgmpro].[dbo].[TipoConvenio]
   SET [tcn_nombre] = 'CONVENIO CETRO-FEDERAR'
      ,[tcn_descripcion] = 'CONVENIO GENERAL PARA CETRO-FEDERAR (CREDIAR)'
      ,[tcn_maxcuotas] = 36
      ,[tcn_maxcuotascaidas] = 2
      ,[tcn_activo] = 1
      ,[tcn_tasapura] = 3
      ,[tcn_ivasobretp] = 1
      ,[tcn_formulacuota] = '( ( POWER(( 1 + $TAS ); $CTD) * $TAS ) /  ( POWER(( 1 + $TAS ); $CTD) - 1 ) ) * $MRF'
      ,[tcn_formulainteres] = '( $SDC * $TAS )'
      ,[tcn_formulahonorarios] = '0'
      ,[tcn_formulagastos] = '0'
      ,[tcn_fechabaja] = convert(datetime, '1753-01-01 00:00:00.000', 121)
      ,[tcn_mincuotas] = 1
      ,[tcn_punitorio] = (3*12/365)
      ,[tcn_valorminimocuota] = 10
      ,[tcn_formulabaseconvenio] = '$CAP + $INT + $HON + $GAS - $QUI'
      ,[tcn_valorminimoanticipo] = 0
      ,[tcn_maxquita] = 0.5
      ,[tcn_reglaha] = 0
      ,[tcn_honorarios] = 20
 WHERE [tcn_id] = '54A347C5-F6D3-47A5-A27F-5A2521E2F2BC';

UPDATE [sgmpro].[dbo].[TipoConvenio]
   SET [tcn_nombre] = 'PLAN CARSA-CONFINA GENERAL'
      ,[tcn_descripcion] = 'PLAN DE PAGO PARA CARSA Y CONFINA CON TASA 1,5%'
      ,[tcn_maxcuotas] = 36
      ,[tcn_maxcuotascaidas] = 2
      ,[tcn_activo] = 1
      ,[tcn_tasapura] = 1.5
      ,[tcn_ivasobretp] = 0
      ,[tcn_formulacuota] = '( ( ( $MRF * $TAS * $CTD ) + $MRF ) / $CTD )'
      ,[tcn_formulainteres] = '(CASE WHEN ($SDO-($CCT-($MRF*$TAS)-($CCT*0,2)) >= $CCT) THEN 0 WHEN ($SDO-($CCT-($MRF*$TAS)-($CCT*0,2)) > 0) THEN ($MRF*$TAS) ELSE ($CCT-($CCT*0,2)) END)'
      ,[tcn_formulahonorarios] = '$CCT * 0,242'
      ,[tcn_formulagastos] = '0'
      ,[tcn_fechabaja] = convert(datetime, '1753-01-01 00:00:00.000', 121)
      ,[tcn_mincuotas] = 1
      ,[tcn_punitorio] = (3*12/365)
      ,[tcn_valorminimocuota] = 10
      ,[tcn_formulabaseconvenio] = '$CAP + $INT + $GAS - $QUI + ( ( $CAP + $INT - $QUI ) * 0,242 )'
      ,[tcn_valorminimoanticipo] = 0
      ,[tcn_maxquita] = 0.5
      ,[tcn_reglaha] = 0
      ,[tcn_honorarios] = 20
 WHERE [tcn_id] = '81457CD8-5910-435A-8B88-617B92F7333F';

UPDATE [sgmpro].[dbo].[TipoConvenio]
   SET [tcn_nombre] = 'PLAN CARSA-CONFINA 0.5%'
      ,[tcn_descripcion] = 'PLAN DE PAGO PARA CARSA Y CONFINA CON TASA 0.5%'
      ,[tcn_maxcuotas] = 36
      ,[tcn_maxcuotascaidas] = 2
      ,[tcn_activo] = 1
      ,[tcn_tasapura] = 0.5
      ,[tcn_ivasobretp] = 0
      ,[tcn_formulacuota] = '( ( ( $MRF * $TAS * $CTD ) + $MRF ) / $CTD )'
      ,[tcn_formulainteres] = '(CASE WHEN ($SDO-($CCT-($MRF*$TAS)-($CCT*0,2)) >= $CCT) THEN 0 WHEN ($SDO-($CCT-($MRF*$TAS)-($CCT*0,2)) > 0) THEN ($MRF*$TAS) ELSE ($CCT-($CCT*0,2)) END)'
      ,[tcn_formulahonorarios] = '$CCT * 0,242'
      ,[tcn_formulagastos] = '0'
      ,[tcn_fechabaja] = convert(datetime, '1753-01-01 00:00:00.000', 121)
      ,[tcn_mincuotas] = 1
      ,[tcn_punitorio] = (3*12/365)
      ,[tcn_valorminimocuota] = 10
      ,[tcn_formulabaseconvenio] = '$CAP + $INT + $GAS - $QUI + ( ( $CAP + $INT - $QUI ) * 0,242 )'
      ,[tcn_valorminimoanticipo] = 0
      ,[tcn_maxquita] = 0.5
      ,[tcn_reglaha] = 0
      ,[tcn_honorarios] = 20
 WHERE [tcn_id] = '29CBE7C6-FC47-4F04-8669-8707B37C5CBB';

UPDATE [sgmpro].[dbo].[TipoConvenio]
   SET [tcn_nombre] = 'PLAN CARSA-CONFINA 1%'
      ,[tcn_descripcion] = 'PLAN DE PAGO PARA CARSA Y CONFINA CON TASA 1%'
      ,[tcn_maxcuotas] = 36
      ,[tcn_maxcuotascaidas] = 2
      ,[tcn_activo] = 1
      ,[tcn_tasapura] = 1
      ,[tcn_ivasobretp] = 0
      ,[tcn_formulacuota] = '( ( ( $MRF * $TAS * $CTD ) + $MRF ) / $CTD )'
      ,[tcn_formulainteres] = '(CASE WHEN ($SDO-($CCT-($MRF*$TAS)-($CCT*0,2)) >= $CCT) THEN 0 WHEN ($SDO-($CCT-($MRF*$TAS)-($CCT*0,2)) > 0) THEN ($MRF*$TAS) ELSE ($CCT-($CCT*0,2)) END)'
      ,[tcn_formulahonorarios] = '$CCT * 0,242'
      ,[tcn_formulagastos] = '0'
      ,[tcn_fechabaja] = convert(datetime, '1753-01-01 00:00:00.000', 121)
      ,[tcn_mincuotas] = 1
      ,[tcn_punitorio] = (3*12/365)
      ,[tcn_valorminimocuota] = 10
      ,[tcn_formulabaseconvenio] = '$CAP + $INT + $GAS - $QUI + ( ( $CAP + $INT - $QUI ) * 0,242 )'
      ,[tcn_valorminimoanticipo] = 0
      ,[tcn_maxquita] = 0.5
      ,[tcn_reglaha] = 0
      ,[tcn_honorarios] = 20
 WHERE [tcn_id] = 'ED1C9B87-644A-452E-9D2C-A1475EDB529A';

UPDATE [sgmpro].[dbo].[TipoConvenio]
   SET [tcn_nombre] = 'PLAN COLUMBIA GENERAL'
      ,[tcn_descripcion] = 'PLAN PARA CONVENIOS DE COLUMBIA'
      ,[tcn_maxcuotas] = 36
      ,[tcn_maxcuotascaidas] = 1
      ,[tcn_activo] = 1
      ,[tcn_tasapura] = 1.97
      ,[tcn_ivasobretp] = 1
      ,[tcn_formulacuota] = '( ( POWER(( 1 + $TAS ); $CTD) * $TAS ) /  ( POWER(( 1 + $TAS ); $CTD) - 1 ) * $MRF ) * ( 1,2 * 1,035 )'
      ,[tcn_formulainteres] = '( $SDC * $TAS )'
      ,[tcn_formulahonorarios] = '( ( POWER(( 1 + $TAS ); $CTD) * $TAS ) /  ( POWER(( 1 + $TAS ); $CTD) - 1 ) * $MRF ) * ( 0,2 * 1,21 )'
      ,[tcn_formulagastos] = '0'
      ,[tcn_fechabaja] = convert(datetime, '1753-01-01 00:00:00.000', 121)
      ,[tcn_mincuotas] = 1
      ,[tcn_punitorio] = (3*12/365)
      ,[tcn_valorminimocuota] = 10
      ,[tcn_formulabaseconvenio] = '0'
      ,[tcn_valorminimoanticipo] = 0
      ,[tcn_maxquita] = 0
      ,[tcn_reglaha] = 0
      ,[tcn_honorarios] = 20
 WHERE [tcn_id] = '908B4E0A-C1A8-43A1-BD47-9AEFB05A057B';

UPDATE [sgmpro].[dbo].[TipoConvenio]
   SET [tcn_nombre] = 'PLAN CETRO SIN INTERES'
      ,[tcn_descripcion] = 'PLAN DE CETRO SIN INTERES (CAPITAL/CTAS) MAX 8 CTAS'
      ,[tcn_maxcuotas] = 8
      ,[tcn_maxcuotascaidas] = 1
      ,[tcn_activo] = 1
      ,[tcn_tasapura] = 0
      ,[tcn_ivasobretp] = 0
      ,[tcn_formulacuota] = '( $MRF / $CTD )'
      ,[tcn_formulainteres] = '0'
      ,[tcn_formulahonorarios] = '0'
      ,[tcn_formulagastos] = '0'
      ,[tcn_fechabaja] = convert(datetime, '1753-01-01 00:00:00.000', 121)
      ,[tcn_mincuotas] = 1
      ,[tcn_punitorio] = (3*12/365)
      ,[tcn_valorminimocuota] = 10
      ,[tcn_formulabaseconvenio] = '0'
      ,[tcn_valorminimoanticipo] = 0
      ,[tcn_maxquita] = 0
      ,[tcn_reglaha] = 0
      ,[tcn_honorarios] = 20
 WHERE [tcn_id] = '78F8D7BF-5489-463A-A1BC-1999D4303DA7';