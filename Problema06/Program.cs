using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Paciente miPaciente = new Paciente("Benner","Simeón",26,1.70,102);

            visualizarDatos(miPaciente);

            miPaciente.edad = 15;

            visualizarDatos(miPaciente);
        }

        static void visualizarDatos(Paciente miPaciente)
        {
            Console.WriteLine("Nombre           : " + miPaciente.nombre);
            Console.WriteLine("Apellido         : " + miPaciente.apellido);
            Console.WriteLine("Edad             : " + miPaciente.edad);
            Console.WriteLine("Talla            : " + miPaciente.talla);
            Console.WriteLine("Peso             : " + miPaciente.peso);
            Console.WriteLine("Estado           : " + miPaciente.Edad());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
