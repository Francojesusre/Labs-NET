using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_numero
{
    class Jugada
    {
        public int Numero { get; set; }
        public int Contador { get; set; }
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public bool Comparar(int num)
        {
            if (Numero == num)
            {
                Console.WriteLine("Has adivinado el numero!!");
                return true;
            }
            else
            {
                Console.WriteLine("Numero incorrecto vuelva a intentarlo");
                return false;
            }
        }
    }

    class JugadaConAyuda:Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {

        }
        new public bool Comparar(int num)
        {
            if (Math.Abs(num - Numero) > 100) Console.WriteLine("El número ingresado está muy lejos del que debe adivinar!");
            else if (Math.Abs(num - Numero) < 5) Console.WriteLine("Está muy cerca del número correcto!");
            return (num == Numero);
        }

    }
}
