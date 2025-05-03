using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

public class CuentaCorriente : CuentaBancaria
{
    public decimal LimiteDeDescubierto { get; init; }
    public decimal Comision { get; set; }

    public CuentaCorriente(string numero, decimal saldo, string[] titulares, decimal comision) : base(numero, saldo, TipoCuenta.CuentaCorriente, titulares)
    {
        Comision = comision;
        
    }

    public override void Depositar(decimal monto)
    {
        try
        {
            Validador.ValidarEstado(EstadoCuenta);
            Validador.ValidarMonto(monto);
            monto -= monto * Comision;
            Saldo += monto; 
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public override void Retirar(decimal monto)
    {
        try
        {
            EstadoCuenta = Validador.ValidarRetiro(Saldo, monto, LimiteDeDescubierto);
            Validador.ValidarEstado(EstadoCuenta);
            Saldo -= monto;
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
    }
}
