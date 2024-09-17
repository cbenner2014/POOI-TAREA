using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(1,"Daniel",999555321,3500);

            visualizarDatos(empleado);

            empleado.numeroCelular = 999888777;
            empleado.sueldoSoles += 200;

            visualizarDatos(empleado);
        }

        static void visualizarDatos(Empleado empleado)
        {
            Console.WriteLine("Código               : " + empleado.codigo);
            Console.WriteLine("Nombre               : " + empleado.nombre);
            Console.WriteLine("Número ed celular    : " + empleado.numeroCelular);
            Console.WriteLine("Sueldo               : " + empleado.sueldoSoles);
            Console.WriteLine("El sueldo es         : " + empleado.elSueldoEs());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
