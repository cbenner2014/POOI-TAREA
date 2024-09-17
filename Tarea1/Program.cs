using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular miCelular = new Celular(996652124, "Benner", 60, 10);

            visualizarDatos(miCelular);

            miCelular.segundosConsumidos += 20;
            miCelular.precioPorSegundos *= 0.95;

            visualizarDatos(miCelular);

      
        }

        static void visualizarDatos(Celular miCelular)
        {
            Console.WriteLine("Número: " + miCelular.numero);
            Console.WriteLine("Usuario: " + miCelular.usuario);
            Console.WriteLine("Segundos Consumidos: " + miCelular.segundosConsumidos);
            Console.WriteLine("Precio por Segundo: " + miCelular.precioPorSegundos);
            Console.WriteLine("Costo por Consumo: " + miCelular.costoPorConsumo());
            Console.WriteLine("Impuesto IGV: " + miCelular.calcularImpuesto());
            Console.WriteLine("Total a Pagar: " + miCelular.totalPagar());
            Console.WriteLine();
            Console.ReadKey();
        }


    } 
}
