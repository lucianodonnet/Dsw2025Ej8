using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cuenta1 = new CuentaCorriente("001-000001", 1500m, ["Santiago Pintos", "Cesar Delgado"], 10)
            {
                LimiteDeDescubierto = 1000m
            };
            var cuenta2 = new CuentaCorriente("001-000002", 2500m, ["Lourdes Erazú", "Alejo Tanda"], 20)
            {
                LimiteDeDescubierto = 1000m
            };
            var cuenta3 = new CuentaCorriente("001-000003", 300m, ["Evelynx"], 20)
            {
                LimiteDeDescubierto = 1000m
            };
            var cuenta4 = new CuentaCorriente("001-000004", -200m, ["Silvia Melisa Albornoz"], 20)
            {
                LimiteDeDescubierto = 1000m
            };

            var cuenta58 = new CuentaCorriente("001-000001", 1500m, new[] { "Milagros del Valle Salinas" }, 10)
            {
                LimiteDeDescubierto = 1000m
            };
            var cuenta5 = new CuentaCajadeAhorro("002-000001", 800m, ["Tatiana Agullo"])
            {
                TasaDeInteres = 0.05m
            };
            var cuenta6 = new CuentaCajadeAhorro("002-000002", 1200m, ["Sofía Herrera", "Tomás García"])
            {
                TasaDeInteres = 0.05m
            };
            var cuenta7 = new CuentaCajadeAhorro("002-000003", 600m, ["Federico Ruiz"])
            {
                TasaDeInteres = 0.05m
            };
            var cuenta8 = new CuentaCajadeAhorro("002-000004", 5000m, ["Julieta Vignoli"])
            {
                TasaDeInteres = 0.05m
            };
            cuenta5.Depositar(-200);
            cuenta5.Retirar(5000);
            var cuenta9 = new CuentaCorriente("001", 1500m, ["Juan Pérez"], 10);
            var cuenta10 = new CuentaCorriente("002", 2000m, ["Ana Torres"], 10);
            var cuenta11 = new CuentaCajadeAhorro("003", 1000m, ["Carlos Núñez"]);
            var cuenta12 = new CuentaCajadeAhorro("004", 1200m, ["Laura Díaz"]);


            // Resumen de cuentas
            var cuentas = new CuentaBancaria[] { cuenta1, cuenta2, cuenta3, cuenta4 };

            foreach (var cuenta in cuentas)
            {
                Console.WriteLine(cuenta);
            }

            

        }




    }
}
