using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computadora miComputadora = new Computadora(1, "Lenovo", "Negro", 100);

            visualizarDatos(miComputadora);

            miComputadora.dolares *= 0.90;

           
            visualizarDatos(miComputadora);
        }

        static void visualizarDatos(Computadora miComputadora)
        {

            Console.WriteLine("Código: " + miComputadora.codigo);
            Console.WriteLine("Marca : " + miComputadora.marca);
            Console.WriteLine("Color : " + miComputadora.color);
            Console.WriteLine("Precio en dolares : " + miComputadora.dolares);
            Console.WriteLine("Precio en soles   : " + miComputadora.precioSoles());
            Console.WriteLine("Precio en euros   : " +miComputadora.precioEuros());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
