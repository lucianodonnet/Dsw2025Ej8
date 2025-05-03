using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

public class CuentaCajadeAhorro : CuentaBancaria
{
    public decimal TasaDeInteres { get; init; }
    

    public CuentaCajadeAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, TipoCuenta.CajaDeAhorro, titulares)
    {
        
    }

    public override void Depositar(decimal monto)
    {
        try
        {
            Validador.ValidarEstado(EstadoCuenta);
            Validador.ValidarMonto(monto);
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
            EstadoCuenta = Validador.ValidarRetiro(Saldo, monto);
            Validador.ValidarEstado(EstadoCuenta);
            Saldo -= monto;
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
    }

    public void AplicarInteres()
    {
        if (Tipo == TipoCuenta.CajaDeAhorro)
        {
            Saldo += Saldo * TasaDeInteres;
        }
    }
}
