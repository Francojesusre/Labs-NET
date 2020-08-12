using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases2
{
    class Program
    {
        static void Main(string[] args)
        {
            B2 b = new B2();
            A2 a = b;
            a.F();
            b.F();
            a.G();
            b.G();

            Console.ReadKey();

        }
    }
}
