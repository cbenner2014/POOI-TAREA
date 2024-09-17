using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor miAsesor = new Asesor(1,"Erick",10,20);


            visualizarDatos(miAsesor);

           miAsesor.horasTrabajadas += 10;
           miAsesor.tarifaPorHora *= 0.85 ;

            visualizarDatos(miAsesor);
        }

        static void visualizarDatos(Asesor miAsesor)
        {
            Console.WriteLine("Código               : " + miAsesor.codigo);
            Console.WriteLine("Nombre               : " + miAsesor.nombre);
            Console.WriteLine("Horas Trabajadas     : " + miAsesor.horasTrabajadas);
            Console.WriteLine("Tarifa               : " + miAsesor.tarifaPorHora);
            Console.WriteLine("Sueldo Bruto         : " + miAsesor.sueldoBruto());
            Console.WriteLine("Descuento            : " + miAsesor.descuento());
            Console.WriteLine("Sueldo Neto          : " + miAsesor.sueldoNeto());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
