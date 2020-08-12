using System;
using System.Linq;

namespace LabSintaxis2
{
    class Program
    {
        static void Main()
        {
            // Ej1();
            // Ej2();

        }

        #region Ej1
        private static void Ej1()
        {
            Console.Write("Ingrese texto xd:");
            var inputTexto = Console.ReadLine();

            if (inputTexto == null || inputTexto == "" || inputTexto == " ")
            {
                Console.WriteLine("Por favor ingrese un texto válido");
                Console.ReadLine();
                return;
            }


            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1:");
            Console.WriteLine("2:");
            Console.WriteLine("3:");

            var opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1)
                Console.WriteLine(inputTexto.ToUpper());
            else if (opcion.Key == ConsoleKey.D2)
                Console.WriteLine(inputTexto.ToLower());
            else if (opcion.Key == ConsoleKey.D3)
                Console.WriteLine("La cantidad de caracteres es {0}", inputTexto.Length);
            else
                return;

            Console.ReadLine();
        }
        #endregion

        #region Ej2
        private static void Ej2()
        {
            Console.Write("Ingrese texto xd:");
            var inputTexto = Console.ReadLine();

            if (inputTexto == null || inputTexto == "" || inputTexto == " ")
            {
                Console.WriteLine("Por favor ingrese un texto válido");
                Console.ReadLine();
                return;
            }


            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1:");
            Console.WriteLine("2:");
            Console.WriteLine("3:");

            var opcion = Console.ReadKey();

            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine(inputTexto.ToUpper());
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine(inputTexto.ToLower());
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("La cantidad de caracteres es {0}", inputTexto.Length);
                    break;
                default:
                    return;
            }

            Console.ReadLine();
        }
        #endregion




    }
}
