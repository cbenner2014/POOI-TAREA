using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pelota miPelota = new Pelota("Walon",20,10,50,100);


            visualizarDatos(miPelota);

            miPelota.precio *= 0.75;
            miPelota.diametroCentimetros += 1;

            visualizarDatos(miPelota);
        }

        static void visualizarDatos (Pelota miPelota)
        {
           
            Console.WriteLine("Marca             : " + miPelota.marca);
            Console.WriteLine("Peso en Gramos    : " + miPelota.pesoGramos);
            Console.WriteLine("Presión en Libras : " + miPelota.presionLibras);
            Console.WriteLine("Diámetro en cm    : " + miPelota.diametroCentimetros);
            Console.WriteLine("Precio            : " + miPelota.precio);
            Console.WriteLine("Radio             : " + miPelota.radio());
            Console.WriteLine("Volúmen balón     : " + miPelota.volumenBalon().ToString("F2"));
            Console.WriteLine("Descuento         : " + miPelota.descuento());
            Console.WriteLine("Importe Pagar     : " + miPelota.importePagar());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
