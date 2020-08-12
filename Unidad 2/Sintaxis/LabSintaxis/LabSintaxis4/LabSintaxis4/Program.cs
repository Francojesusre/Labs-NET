using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ej4Suma();
            //Ej4Mes();
            //Ej4Biciesto();
            //Ej4Fibonacci();
            //Ej4Par();
            //Ej4Rom();
            //Ej4Prim();
            //Ej4Pass();
            //Ej4Fil();
        }

        #region Ej4
        private static void Ej4Suma()
        {
            int nro1, nro2;

            Console.Write("Ingrese el primer valor: ");
            nro1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de {0} y {1} es igual a {2}", nro1, nro2, nro1 + nro2);
            Console.Read();
        }

        private static void Ej4Biciesto()
        {
            int ano;
            var esBiciesto = false;

            Console.Write("Ingrese el año: ");
            ano = int.Parse(Console.ReadLine());

            if (EsDivisible(ano, 4))
            {
                if (EsDivisible(ano, 100))
                {
                    if (EsDivisible(ano, 400))
                    {
                        esBiciesto = true;
                    }
                }
                else
                {
                    esBiciesto = true;
                }
            }

            if (esBiciesto)
                Console.WriteLine("Es biciesto xd");
            else
                Console.WriteLine("No es biciesto xd");

            Console.Read();
        }

        private static bool EsDivisible(int ano, int dividendo)
        {
            return ano % dividendo == 0;
        }

        private static void Ej4Fibonacci()
        {
            var cantIteraciones = 30;
            var sum = 0;
            int aux1 = 1, aux2 = 1;

            for (int i = 0; i < cantIteraciones; i++)
            {
                sum = +aux1 + aux2;

                aux1 = aux2;
                aux2 = aux1 + aux2;
            }

            Console.WriteLine(sum);
            Console.Read();
        }

        private static void Ej4Mes()
        {
            var meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            var mes = Console.ReadLine();

            for (int i = 0; i < 12; i++)
            {
                if (meses[i] == mes)
                {
                    Console.WriteLine("El numero del mes ingresado es : {0} ", i + 1);
                }

            }
            Console.ReadKey();

        }

        private static void Ej4Par()
        {
            Console.WriteLine("La lista de numeros par es: ");

            for (int i = 1; i < 100; i++)
            {

                if (EsDivisible(i, 2))
                {
                    Console.WriteLine(i);

                }
            }
            Console.ReadKey();




        }

        private static void Ej4Rom()
        {

            Console.WriteLine("Ingresar el numero");

            var numero = Console.ReadLine();

            string[] Centena = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] Decena = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] Unidad = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            var romano = new string[numero.Length];
            if (numero.Length == 3)
            {
                romano[0] = Centena[int.Parse(numero[0].ToString())];
                romano[1] = Decena[int.Parse(numero[1].ToString())];
                romano[2] = Unidad[int.Parse(numero[2].ToString())];

            }
            if (numero.Length == 2)
            {
                romano[0] = Decena[int.Parse(numero[0].ToString())];
                romano[1] = Unidad[int.Parse(numero[1].ToString())];

            }
            else if (numero.Length == 1)
            {
                romano[0] = Unidad[int.Parse(numero[0].ToString())];
            }


            for (int i = 0; i < romano.Length; i++)
            {
                Console.Write(romano[i]);

            }
            Console.ReadKey();
        }

        private static void Ej4Prim()
        {
            Console.Write("Ingresar cantidad de numeros primos gemelos a buscar: ");

            var cantidad = int.Parse(Console.ReadLine());
            var contador = 2;
            Console.WriteLine();
            Console.WriteLine("La lista de los numeros primos gemelos es: ");
            Console.WriteLine();

            while (cantidad > 0)
            {
                contador++;

                if (EsPrimo(contador) && EsPrimo(contador + 2))
                {
                    Console.WriteLine("({0},{1})", contador, contador + 2);
                    cantidad--;
                }

            }
            Console.ReadKey();

        }

        private static bool EsPrimo(int num)
        {
            if ((num % 2) == 0 || (num % 3) == 0 && num != 3)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        private static void Ej4Pass()
        {
            var intentos = 0;

            while (intentos < 4)
            {
                Console.WriteLine("Ingrese la contraseña");
                var cont = Console.ReadLine();
                intentos++;

                if (cont == "hola")
                {
                    Console.WriteLine("La contraseña ingresada es correcta");
                    intentos = 4;

                }
                else
                {
                    Console.WriteLine("La contraseña ingresada es incorrecta");
                    Console.WriteLine("Intento numero: {0}", intentos);
                }
            }
            Console.ReadKey();

        }

        private static void Ej4Fil()
        {
            Console.WriteLine("Ingresar cantidad de filas a generar");
            var fila = int.Parse(Console.ReadLine());

            for (int i = 0; i < fila; i++)
            {
                Console.SetCursorPosition(fila - 1, i + 2);
                Console.Write("*");
                if (i != 0)
                {
                    for (int a = 1; a < i + 1; a++)
                    {
                        Console.SetCursorPosition(fila + a - 1, i + 2);
                        Console.Write("*");
                        Console.SetCursorPosition(fila - a - 1, i + 2);
                        Console.Write("*");

                    }

                }
            }
            Console.ReadKey();

        }
        #endregion

    }
}
