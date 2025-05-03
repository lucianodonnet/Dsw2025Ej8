
namespace Dsw2025Ej8.Domain;



public class CuentaBancaria
{
    public TipoCuenta Tipo { get; }
    public string Numero { get; } 
    public decimal Saldo { get; protected set; }
    public Estado EstadoCuenta { get; protected set; }
    public string[] Titulares { get; }

    public CuentaBancaria(string numero, decimal saldo, TipoCuenta tipo, string[] titulares)
    {
        Numero = numero;
        Saldo = saldo;
        Tipo = tipo;
        EstadoCuenta = Estado.Activa;
        Titulares = titulares;
    }
    
    public virtual void Depositar(decimal monto)
    {
        //logica
    }


    public virtual void Retirar(decimal monto)
    {
        //logica
    }

    public override string ToString()
    {
        return $"Número: {Numero}, Tipo: {Tipo}, Saldo: {Saldo:C}, Estado: {EstadoCuenta}";
    }

}
