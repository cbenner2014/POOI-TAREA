using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obrero = new Obrero(1,"Hector", 8, 10);

            

            visualizarDatos(obrero);

            obrero.horasTrabajadas += 8;
            obrero.tarifaHora *= 0.985;


            visualizarDatos(obrero);
        }
        static void visualizarDatos(Obrero obrero)
        {
            Console.WriteLine("Código           : " + obrero.codigo);
            Console.WriteLine("Nombre           : " + obrero.nombre);
            Console.WriteLine("Horas Trabajadas : " + obrero.horasTrabajadas);
            Console.WriteLine("Sueldo Bruto     : " + obrero.sueldoBruto());
            Console.WriteLine("Descuento AFP    : " + obrero.descuentoAfp());
            Console.WriteLine("Descuento EPS    : " + obrero.descuentoEps());
            Console.WriteLine("Sueldo Neto      : " + obrero.sueldoNeto());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
