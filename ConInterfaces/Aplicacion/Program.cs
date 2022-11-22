using ConInterfaces.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            List<Factura>fac = new List<Factura>();
            List<CuentaBancaria> cta = new List<CuentaBancaria>();

            do
            {
                Console.Clear();
                Console.WriteLine("\t1.- Agregar una Cuenta bancaria");
                Console.WriteLine("\t2.- Agregar una Factura");
                Console.WriteLine("\t3.- Cantidad de Cuentas bancaria");
                Console.WriteLine("\t1.- Cantidad de Facturas");
                Console.Write("\nIngrese su OPcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        CuentaBancaria miCuenta = new CuentaBancaria();
                        Console.WriteLine("Ingrese el numero de cuenta");
                        miCuenta.Numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el saldo de la cuenta");
                        miCuenta.Saldo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la fecha de apertura");
                        miCuenta.Fecha = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine(miCuenta.MostrarDatos());
                        cta.Add(miCuenta);
                        Console.ReadKey();
                        break;

                    case 2:
                        Factura miFactura = new Factura();
                        Console.WriteLine("Ingrese el numero de Factura");
                        miFactura.Folio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el cliente");
                        miFactura.Cliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el total de la Factura");
                        miFactura.Total = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese fecha de la factura");
                        miFactura.Fecha = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine(miFactura.MostrarDatos());
                        fac.Add(miFactura);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Cantidad de Cuentas Bancarias: " + cta.Count);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Cantidad de Facturas: " + fac.Count);
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 0);
        }
    }
}
