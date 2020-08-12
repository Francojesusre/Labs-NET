using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_numero
{
    class Juego
    {
        public int Record { get; set; }
        public void ComenzarJuego()
        {
            while (Continuar())
            {
                int numMax = PreguntarMaximo();
                JugadaConAyuda num = new JugadaConAyuda(numMax);
                bool aux;
                do
                {
                    num.Contador++;
                    Console.WriteLine("Intento numero: " + num.Contador);
                    aux = num.Comparar(PreguntarNumero());
                } while (aux == false);
                CompararRecord(num.Contador);
            }
            Console.WriteLine("Chau nos re vimo");


        }

        private void CompararRecord(int nuevo)
        {
            if (nuevo < Record)
            {
                Console.WriteLine("Nuevo record");
                Record = nuevo;
            }
            else
            {
                Console.WriteLine("Record no superado");
            }
        }

        private bool Continuar()
        {
            Console.WriteLine("Quiere jugar una partida? s/n");
            string juego;
            juego = Console.ReadLine();
            if (juego== "S" || juego == "s")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }
        }

        private int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese numero maximo");
            int num;
            num = int.Parse(Console.ReadLine());
            return num;
        }

        private int PreguntarNumero()
        {
            Console.WriteLine("Ingrese un numero: ");
            int num;
            num = int.Parse(Console.ReadLine());
            return (num);
        }
    }
}
