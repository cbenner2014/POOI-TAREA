using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Edificio miEdificio = new Edificio(2, 202, 4, 100000);

            visualizarDatos(miEdificio);

            miEdificio.precioDepartamentoDolares *= 1.20;
        

            visualizarDatos(miEdificio);
        }

        static void visualizarDatos(Edificio miEdificio)
        {

            Console.WriteLine("Código                   : " + miEdificio.codigo);
            Console.WriteLine("Número de departamentos  : " + miEdificio.numeroDepartamentos);
            Console.WriteLine("Cantidad de Pisos        : " + miEdificio.cantidadPisos);
            Console.WriteLine("Precio en dolares        : " + miEdificio.precioDepartamentoDolares);
            Console.WriteLine("Precio del edificio      : " + miEdificio.precioDolaresEdificio());
            Console.WriteLine();
            Console.ReadKey();

        }

    }  
}
