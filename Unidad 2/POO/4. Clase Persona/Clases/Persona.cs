using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Clases
{
    public class Persona
    {
        //Propiedades
        public string strNombre { get; set; }
        public string strApellido { get; set; }
        public int intEdad { get; set; }
        public int intDNI { get; set; }

        //Constructores y destructores
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            strNombre = nombre;
            strApellido = apellido;
            intEdad = edad;
            intDNI = dni;
            Console.WriteLine("Instancia creada");
        }
        ~Persona()
        {
            Console.WriteLine("Objeto destruido");
        }
        public string GetfullName()
        {
            return strNombre + strApellido;
        }
        public void GetAge()
        {
            Console.WriteLine("La edad de la persona es " + intEdad);
        }


    }
}
