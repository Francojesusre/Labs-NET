using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej3();
        }

        #region Ej3
        private static void Ej3()
        {
            var cantIteraciones = 5;
            var palabras = new string[cantIteraciones];

            for (var i = 0; i < cantIteraciones; i++)
            {
                Console.Write("Ingrese la palabra Nro {0}: ", i + 1);
                palabras[i] = Console.ReadLine();
            }

            for (var i = cantIteraciones - 1; i >= 0; i--)
            {
                if (i != cantIteraciones - 1)
                    Console.Write(", ");

                Console.Write(palabras[i]);
            }

            Console.Read();
        }
        #endregion
    }
}
