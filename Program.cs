using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chain_of_rresponsibility;

namespace chain_of_rresponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            var comprador = new Vendedor();
            var gerente = new Gerente();
            var director = new Director();
            var comision = new Comision();

            director.AgregarSiguiente(comision);
            gerente.AgregarSiguiente(director);
            comprador.AgregarSiguiente(gerente);

            var c = new Compra();
            double importe = 1;
            while (importe != 0)
            {
                Console.WriteLine("Ingrese monto de la compra (0 salir)");
                importe = double.Parse(Console.ReadLine());
                c.Importe = importe;
                comprador.Procesar(c);
            }

        }
    }
}

