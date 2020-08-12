using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.ComenzarJuego();
            Console.ReadKey();
        }
    }
}
