using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaEmbriagante oBebida = Creador.CreadorBebidas(Creador.CERVEZA);
            Console.WriteLine("Cerveza:");
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());

            Console.ReadKey();

            BebidaEmbriagante bebida = Creador.CreadorBebidas(Creador.VINO_TINTO);
            Console.WriteLine("Vino Tinto:");
            Console.WriteLine(bebida.CuantoMeEmbriagaPorHora());

            Console.ReadKey();
        }
    }
}
