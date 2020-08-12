using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Clases
{
    public class B:A
    {
       
        //Constructor
        public B() : base("Instancia de B")
        {

        }

        //Metodo
        public void M4()
        {
            Console.WriteLine("Metodo hijo invocado");
        }


    }
}
