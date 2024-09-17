using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Video miVideo = new Video(1, "Titanic", 120, 20, 3.7);


            visualizarDatos(miVideo);

            miVideo.precioSoles += 5.50;

            visualizarDatos(miVideo);

        }

        static void visualizarDatos(Video miVideo)
        {
            Console.WriteLine("Código           : " + miVideo.codigo);
            Console.WriteLine("Nombre           : " + miVideo.nombreVideo);
            Console.WriteLine("Duración         : " + miVideo.duracion);
            Console.WriteLine("Precio Soles     : " + miVideo.precioSoles.ToString("F2"));
            Console.WriteLine("Tipo de Cambio   : " + miVideo.tipoCambio.ToString("F2"));
            Console.WriteLine("Precio Dólares   : " + miVideo.precioVideoDolares().ToString("F2"));
            Console.WriteLine();
            Console.ReadKey();
        }

    }
    
}
