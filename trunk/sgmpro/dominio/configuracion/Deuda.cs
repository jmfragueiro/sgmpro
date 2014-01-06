///////////////////////////////////////////////////////////
//  Deuda.cs
//  Implementation of the Class Deuda
//  Generated by Enterprise Architect
//  Created on:      13-May-2009 03:54:59 p.m.
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioToolLibrary;

namespace sgmpro.dominio.configuracion {
    /// <summary>
    /// Esta clase representa a una deuda asociada a una Cuenta morosa dentro 
    /// del sistema � a un Convenio generado sobre una Cuenta. La Deuda puede 
    /// surgir tanto directamente (por ejemplo v�a la que se informa desde el
    /// cliente u otros importes -como gasto- que agregan por x motivo), como 
    /// a partir de generar un Convenio de refinanciaci�n para una Cuenta, el 
    /// cual generar� tantas instancias de Deuda como cuotas tenga. Una Deuda 
    /// tendr� posteriormente Pagos asociados a trav�s de un concepto relaci�n
    /// denominada Imputaci�n que determina cu�nto de un Pago ha sido imputado 
    /// a la misma (con un Pago se pueden pagar varias deudas). Una deuda no se
    /// mata porque si, solamente se cancela con pagos, se cancela con quitas �, 
    /// si es informada, se pisa al asignarse un nueva deuda informada a la misma
    /// Cuenta. Una deuda puede reavivarse. Esta clase es persistente.
    /// </summary>
    public class Deuda : EntidadIdentificada<Deuda> {
        public const double TOPE_DIFERENCIA_MONTO = 0.01;

        private static readonly Parametro _ddaorigen = Parametros.GetByClave("CONCEPTODEUDA.ORIGEN");
        private static readonly Parametro _punito = Parametros.GetByClave("CONCEPTODEUDA.PUNITORIO");
        private static readonly Parametro _detallening = Parametros.GetByClave("DETALLEDEUDA.NINGUNO");        
        private static readonly Parametro _pagoquita = Parametros.GetByClave("TIPOPAGO.QUITA");
        private static readonly Parametro _pagosucursal = Parametros.GetByClave("TIPOPAGO.SUCURSAL");
        private static readonly Parametro _pagoaplicado = Parametros.GetByClave("ESTADOPAGO.APLICADO");
        private static readonly Parametro _pagoforma = Parametros.GetByClave("FORMAPAGO.OTRO");
        private static readonly Parametro _cancelada = Parametros.GetByClave("ESTADODEUDA.CANCELADA");
        private static readonly Parametro _parcial = Parametros.GetByClave("ESTADODEUDA.PARCIAL");
        private static readonly Parametro _pendiente = Parametros.GetByClave("ESTADODEUDA.PENDIENTE");
        private static readonly Parametro _anulada = Parametros.GetByClave("ESTADODEUDA.ANULADA");
        private static readonly Parametro _enconvenio = Parametros.GetByClave("ESTADODEUDA.CONVENIO");
        private static readonly Parametro _cancelconvenio = Parametros.GetByClave("ESTADODEUDA.CANCELADACONVENIO");

        /// <summary>
        /// La fecha de vencimiento asociada a la deuda. No Nulo.
        /// </summary>
        public virtual DateTime FechaVencimiento {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = Fechas.GetOkDate(value); }
        }
        private DateTime _fechaVencimiento = Fechas.FechaNull;
        /// <summary>
        /// El concepto de la deuda de cuenta corriente. Par�metro. No Nulo. FK.
        /// </summary>
        public virtual Parametro Concepto { get; set; }
        /// <summary>
        /// El detalle del concepto de la deuda de cuenta corriente. Par�metro. No Nulo. FK.
        /// </summary>
        public virtual Parametro Detalle { get; set; }
        /// <summary>
        /// Una descripci�n asociada a la deuda.
        /// </summary>
        public virtual string Descripcion { get; set; }
        /// <summary>
        /// El estado actual de la deuda. Par�metro. No Nulo. FK.
        /// </summary>
        public virtual Parametro Estado { get; set; }
        /// <summary>
        /// El importe total de la deuda. No Nulo.
        /// </summary>
        public virtual double Total {
            get { 
                double tot = Math.Round((_capital + _interes + _honorarios + _gastos), 2);
                return (Math.Abs(tot) <= TOPE_DIFERENCIA_MONTO ? 0 : tot);
            }
        }
        /// <summary>
        /// El importe de capital de la deuda actualizado (saldo). No Nulo.
        /// </summary>
        public virtual double Capital {
            get { return _capital; }
            set { _capital = Math.Round(value, 2); }
        }
        private double _capital;
        /// <summary>
        /// El importe de intereses de la deuda actualizado (saldo). No Nulo.
        /// </summary>
        public virtual double Interes {
            get { return _interes; }
            set { _interes = Math.Round(value, 2); }
        }
        private double _interes;
        /// <summary>
        /// El importe de honorarios de la deuda actualizado (saldo). No Nulo.
        /// </summary>
        public virtual double Honorarios {
            get { return _honorarios; }
            set { _honorarios = Math.Round(value, 2); }
        }
        private double _honorarios;
        /// <summary>
        /// El importe de gastos de la deuda actualizado (saldo). No Nulo.
        /// </summary>
        public virtual double Gastos {
            get { return _gastos; }
            set { _gastos = Math.Round(value, 2); }
        }
        private double _gastos;
        /// <summary>
        /// Si la deuda es generada internamente o desde/para el cliente. No Nulo.
        /// </summary>
        public virtual bool Informada { get; set; }
        /// <summary>
        /// La cuenta a la que pertenece la deuda. FK.
        /// </summary>
        public virtual Cuenta Cuenta { get; set; }
        /// <summary>
        /// El convenio al que pertenece el deuda. FK.
        /// </summary>
        public virtual Convenio Convenio { get; set; }
        /// <summary>
        /// El numero de cuota si la deuda pertenece a un convenio.
        /// </summary>
        public virtual long Cuota { get; set; }
        /// <summary>
        /// La fecha de alta de la deuda. No Nulo.
        /// </summary>
        public virtual DateTime FechaAlta {
            get { return _fechaAlta; }
            set { _fechaAlta = Fechas.GetOkDate(value); }
        }
        private DateTime _fechaAlta = DateTime.Now;
        /// <summary>
        /// El importe original de capital de la deuda. No Nulo.
        /// </summary>
        public virtual double CapitalO { get; set; }
        /// <summary>
        /// El importe original de intereses de la deuda. No Nulo.
        /// </summary>
        public virtual double InteresO { get; set; }
        /// <summary>
        /// El importe original de honorarios de la deuda. No Nulo.
        /// </summary>
        public virtual double HonorO { get; set; }
        /// <summary>
        /// El importe original de gastos de la deuda. No Nulo.
        /// </summary>
        public virtual double GastosO { get; set; }
        /// <summary>
        /// Conjunto de imputaciones de pagos asociadas a la deuda. FK (Bag). 
        /// </summary>
        public virtual IList<Imputacion> Imputaciones { get; set; }

        /// <summary>
        /// Constructor que instancia los conjuntos de la clase.
        /// </summary>
        public Deuda() {
            Imputaciones = new List<Imputacion>();
        }

        /// <summary>
        /// Constructor que instancia un objeto de la clase bien formado.
        /// </summary>
        public Deuda(DateTime vto, Parametro concepto, Parametro detalle, bool info, string desc, double capo, double into, double hono, double gast, Cuenta cta, Convenio conv, long cuota) {
            Imputaciones = new List<Imputacion>();

            FechaVencimiento = vto;
            Concepto = (concepto ?? _ddaorigen);
            Detalle = (detalle ?? _detallening);
            Informada = info;
            Descripcion = (desc ?? "S/D");
            Estado = _pendiente;
            Capital = capo;
            Interes = into;
            Honorarios = hono;
            Gastos = gast;
            Cuenta = cta;
            Convenio = conv;
            Cuota = cuota;

            inicializar();
        }

        /// <summary>
        /// Este m�todo "inicializa" una deuda cargando sus valores
        /// originales segun los valores que tiene en los campos actuales.
        /// </summary>
        public virtual void inicializar() {
            CapitalO = Capital;
            InteresO = Interes;
            HonorO = Honorarios;
            GastosO = Gastos;
        }

        /// <summary>
        /// Este m�todo se utiliza para imputar un pago a una deuda, lo que 
        /// se hace creando un objeto Imputacion. Se reseta el estado tanto
        /// de la deuda como del pago luego de que se aplica la imputacion. 
        /// Lanza DataErrorException si tiene problemas.
        /// </summary>
        /// <param name="pago">
        /// El pago a aplicarse a la deuda.
        /// </param>
        /// <returns>
        /// El resto que queda una vez aplicado el pago (si queda algo).
        /// </returns>
        public virtual double aplicarPago(Pago pago) {
            if (pago == null || pago.Total <= 0)
                throw new DataErrorException("ERROR-NOADD-ELEMENTO", "PAGO");
            if (!pago.isAlive())
                throw new DataErrorException("ERROR-USE-ELEMENTO-NOALIVE", pago.ToString());
            if (!isAlive())
                throw new DataErrorException("ERROR-USE-ELEMENTO-NOALIVE", ToString());

            // Prepara e imputa el pago (operaci�n que a su vez
            // verifica estado tanto de la deuda como del pago)
            (new Imputacion()).preparar(this, pago).imputar();

            // Verifica si debe actualizar el estado del convenio/cuenta
            verificar();

            // Si todook entonces retorna con el saldo del pago
            return pago.getSaldo();
        }

        /// <summary>
        /// Este m�todo recalula los punitorios de la deuda, siempre
        /// que la misma est� vencida, que no este cancelada ni dentro
        /// de un convenio y que su concepto incluya efectivamente el 
        /// c�lculo de punitorios (Valorlong=1).
        /// </summary>
        /// <returns>
        /// El total de los punitorios recalculados (o lo que habia si 
        /// no se debe recalcular mas).
        /// </returns>
        public virtual double calcularPunitorios() {
            if (Concepto != null && Concepto.Valorlong == 1 && !estaCancelada()) {
                int diff;
                double punit = 
                    (Cuenta == null)
                       ? Convenio.Cuenta.getTramo().Punitorio
                       : Cuenta.getTramo().Punitorio;

                if (punit > 0 && (diff = (DateTime.Today - FechaVencimiento.Date).Days) > 0)
                    return Math.Round((Total*diff*(punit/100)), 2);
            }

            return 0;
        }

        /// <summary>
        /// Este m�todo genera una nueva deuda para los punitorios de 
        /// �sta deuda, siempre que corresponda. La deuda nueva no se
        /// hace persistente (responsabilidad del usuario del m�todo).
        /// Los punitorios SIEMPRE se asocian a una Cuenta (la de la 
        /// deuda propiamente dicha o la del Convenio).
        /// </summary>
        /// <returns>
        /// Un nuevo objeto deuda con el punitorio de �sta deuda si
        /// corrsponde o sino devuelve null.
        /// </returns>
        public virtual Deuda generarPunitorio() {
            double punit = calcularPunitorios();
            string desc = string.Format("Int.Punitorio s/{0}", Descripcion);
            Cuenta cta = (Cuenta ?? Convenio.Cuenta);

            if (punit > 0)
                return new Deuda(DateTime.Now, _punito, _detallening, false, 
                                    desc, 0, 0, 0, punit, cta, null, Cuota);

            return null;
        }

        /// <summary>
        /// Este m�todo cancela la deuda actual generando un pago de
        /// tipo quita para dejar cancelada la deuda. No hace nada si
        /// la deuda ya esta cancelada. No se capturan las excepciones 
        /// (se disparan hacia arriba).
        /// </summary>
        public virtual void cancelarConQuita() {
            aplicarPago(
                new Pago {
                    Fecha = DateTime.Now,
                    Tipo = _pagoquita,
                    Estado = _pagoaplicado,
                    Descripcion =
                        string.Format(
                            "Quita por Cancelacion Saldo generada por {0}.",
                            Sistema.Controlador.SecurityService.getUsuario().Nombre),
                    FormaPago = _pagoforma,
                    Capital = Capital,
                    Interes = Interes,
                    Honorarios = Honorarios,
                    Gastos = Gastos,
                    Cuenta = Cuenta ?? Convenio.Cuenta,
                    FechaUMod = DateTime.Now,
                    FechaBaja = Fechas.FechaNull
                });
        }

        /// <summary>
        /// Este m�todo imputa un pago en sucursal a la deuda actual.
        /// No se capturan excepciones (se disparan hacia arriba).
        /// </summary>
        public virtual void impactarPagoSucursal(double cap, double inter, double hon, double gas, DateTime fecha, string desc) {
            aplicarPago(
                new Pago {
                    Fecha = DateTime.Now,
                    Tipo = _pagosucursal,
                    Estado = _pagoaplicado,
                    Descripcion = desc,
                    FormaPago = _pagoforma,
                    Capital = cap,
                    Interes = inter,
                    Honorarios = hon,
                    Gastos = gas,
                    Cuenta = Cuenta ?? Convenio.Cuenta,
                    FechaUMod = DateTime.Now,
                    FechaBaja = Fechas.FechaNull
                });
        }

        /// <summary>
        /// Este m�todo cancela la deuda actual sin generar un pago 
        /// sobre la deuda, sino simplemente colocando a cero las 
        /// componentes de la deuda y reseteando su estado. No se 
        /// capturan excepciones (se disparan hacia arriba).
        /// </summary>
        /// <param name="fecha">
        /// La fecha del pago cancelatorio.
        /// </param>
        /// <param name="extra">
        /// Un comentario extra para agregar a la descripci�n del pago.
        /// </param>
        public virtual void cancelarSinPago(DateTime fecha, string extra) {
            Descripcion = string.Format(
                "*** Cancelaci�n sin Pago hecha por {1}: {0} *** " + Descripcion, 
                    extra, Sistema.Controlador.SecurityService.getUsuario().Nombre);
            Capital = Interes = Honorarios = Gastos = 0;
            save(); 
            resetEstado();
            verificar();
            save();
        }

        /// <summary>
        /// Este m�todo marca la deuda como que fue incluida dentro
        /// de un convenio de pago. Cambia su estado y coloca sus
        /// saldos en cero (pero no toca los originales). NO hace 
        /// nada si la deuda esta cancelada!.
        /// </summary>
        public virtual void marcarDeudaEnConvenio(Convenio convenio) {
            Descripcion += " **EN CONVENIO** " + Convenio;

            resetEstado();
            if (!estaCancelada()) {
                Estado = _enconvenio;
                save();
            }
        }

        /// <summary>
        /// Este m�todo marca la deuda como que fue incluida dentro
        /// de un convenio de pago. Cambia su estado y coloca sus
        /// saldos en cero (pero no toca los originales). NO hace 
        /// nada si la deuda esta cancelada!.
        /// </summary>
        public virtual void quitarDeudaDeConvenio() {
            if (!estaCancelada()) {
                Estado = _pendiente;
                resetEstado();
                save();
            }
        }

        /// <summary>
        /// Este m�todo resetea el estado de la deuda recalculando para
        /// ver cu�l es el correcto entre PENDIENTE, PARCIAL, CANCELADA,
        /// ENCONVENIO, CANCELADACONVENIO. Trabaja solo sobre deudas NO
        /// CANCELADAS. No se persisten los cambios. No se capturan las 
        /// excepciones (se disparan hacia arriba).
        /// </summary>
        public virtual void resetEstado() {
            if (Estado.Equals(_enconvenio))
                Estado = (Cuenta != null 
                            && Cuenta.ConvenioActivo != null 
                            && Cuenta.ConvenioActivo.getMontoSaldoTotalActual() <= 0)
                             ? _cancelconvenio
                             : _enconvenio;
            else {
                Estado = (Total > 0)
                             ? ((Math.Abs(Total - Math.Round(CapitalO + InteresO + HonorO + GastosO, 2)) <= TOPE_DIFERENCIA_MONTO)
                                    ? _pendiente
                                    : _parcial)
                             : _cancelada;
            }
        }

        /// <summary>
        /// Este m�todo permite verificar si una deuda est� cancelada,
        /// es decir si su estado actual es CANCELADA.
        /// </summary>
        /// <returns>
        /// Retorna verdadero si su estado actual es cancelada.
        /// </returns>
        public virtual bool estaCancelada() {
            return (Estado.Equals(_cancelada) || Estado.Equals(_cancelconvenio));
        }

        /// <summary>
        /// Este m�todo permite verificar si una deuda est� cancelada,
        /// es decir si su estado actual es CANCELADA.
        /// </summary>
        /// <returns>
        /// Retorna verdadero si su estado actual es cancelada.
        /// </returns>
        public virtual bool estaEnConvenio() {
            return (Estado.Equals(_enconvenio) || Estado.Equals(_cancelconvenio));
        }

        /// <summary>
        /// Aqui se deberia colocar la Cuenta y/o Convenio para
        /// ver si su saldo se puso en cero, y asi cancelarlos.
        /// </summary>
        public virtual void verificar() {
            try {
                if (Convenio != null)
                    Convenio.verificarYCancelarReavivar();
                if (Cuenta != null)
                    Cuenta.verificarYCancelarReavivar();
            } catch (Exception e) {
                throw new DataErrorException("ERROR-POSPAGO-DEUDA", e.ToString());
            }            
        }

        /// <summary>
        /// Este m�todo anula una deuda.
        /// </summary>
        public override void delete() {
            if (Estado != _pendiente && Estado != _parcial)
                throw new DataErrorException("ERROR-SOLOEDIT-DDAPEND");
            if (Convenio != null)
                throw new DataErrorException("ERROR-NODEL-DDACONVE");


            Estado = _anulada;
            Descripcion += string.Format(
                " **ANULADA** en fecha {0} por {1}",
                DateTime.Now,
                Sistema.Controlador.SecurityService.getUsuario().Nombre);
            base.delete();
        }

        /// <summary>
        /// Este m�todo evita que se desborre (o reavive) un objeto de la clase.
        /// </summary>
        public override void undelete() {
            throw new DataErrorException("DATA-UNDEL-NOK");
        }

        /// <summary>
        /// Este m�todo genera el string por defecto a mostrar en todos lados.
        /// </summary>
        public override string ToString() {
            return string.Format("{0}=={1:C}({2})", 
                Concepto, 
                Math.Round((CapitalO+InteresO+HonorO+GastosO),2), 
                FechaVencimiento.ToShortDateString());
        }
    }
}