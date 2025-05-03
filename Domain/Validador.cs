using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public static class Validador
    {
        public static void ValidarMonto(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto), "El monto ingresado no es válido para la operación\r\nsolicitada");
            }

        }
        public static void ValidarEstado(Estado estado)
        {
            if (estado != Estado.Activa)
            {
                throw new InvalidOperationException($"No se puede operar con la cuenta {estado}.");
            }
        }

        public static Estado ValidarRetiro(decimal saldo,decimal monto, decimal limitedeDescubierto = 0)
        {
            ValidarMonto(monto);
            if (monto > saldo + limitedeDescubierto)
            {
                return Estado.Suspendida;
                throw new InvalidOperationException(" La cuenta no cuenta con saldo para la operación\r\nsolicitada. Fue suspendida.\r\n");
            }
            return Estado.Activa;
        }


    }
}
