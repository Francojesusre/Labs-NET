using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Clases
{
    public class A
    {
        private string _NombreInstancia;

        public string NombreInstancia
        {
            get
            {
                return _NombreInstancia;
            }
            set { }
        }

        // Constructores

        public A()
        {
            _NombreInstancia = "Instancia sin nombre";
        }
        
        public A(string nombre)
        {
            _NombreInstancia = nombre;
        }

        //Metodos

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }
        public void M1()
        {
            Console.WriteLine("M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("M2 fue invocado");
        }
        public void M3()
        {
            Console.WriteLine("M3 fue invocado");
        }
    }
}
