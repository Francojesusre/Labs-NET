using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            provincias();
            mayor20();
            CP();
            Empleados();

        }

        private static void provincias()
        {
            string[] provincia = { "Santa Fe", "Cordoba", "Salta", "Corrientes", "Santiago del Estero" };
            var strProv = from p in provincia
                          where p[0] == 'S' || p[0] == 'T'
                          select p;
            // Muestra
            foreach (string p in strProv)
            {
                Console.WriteLine(p);

            }
            Console.ReadKey();
        }

        private static void mayor20()
        {
            List<int> num = new List<int>();
            char c = 'y';
            while (c == 'y' || c == 'Y')
            {
                Console.WriteLine("Ingrese un numero");
                num.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Quiere ingras otro numero?(Y/N)");
                c = Convert.ToChar(Console.ReadLine());
            }
            var mNum = from n in num
                       where n > 20
                       select n;
            foreach (int n in mNum)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }

        private static void CP()
        {
            ArrayList city = new ArrayList();
            city.Add(new Ciudad("Rosario", 2000));
            city.Add(new Ciudad("Casilda", 2170));
            city.Add(new Ciudad("Los Molinos", 2181));
            city.Add(new Ciudad("Arequito", 2183));
            city.Add(new Ciudad("Pujato", 2122));
            city.Add(new Ciudad("Sanford", 2173));
            city.Add(new Ciudad("Zavalla", 2123));
            city.Add(new Ciudad("Chabas", 2173));
            string palabra;
            Console.WriteLine("Ingese parametro de 3 letras a buscar");
            palabra = Console.ReadLine();
            var sCiudad = from Ciudad sc in city
                          where sc.nombre.ToLower().Contains(palabra)
                          select sc;
            foreach (Ciudad m in sCiudad)
            {
                Console.WriteLine(m.nombre, m.codigo);
            }
            Console.ReadKey();
        }
        
        private static void Empleados()
        {
            List<Empleado> emp = new List<Empleado>();
            char c = 'y';
            while (c == 'y' || c == 'Y')
            {
                int id; string nombre; float sueldo;
                Console.WriteLine("Ingrese id");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese sueldo");
                sueldo = float.Parse(Console.ReadLine());
                emp.Add(new Empleado(id, nombre, sueldo));
                Console.WriteLine("Quiere ingras otro empleado?(Y/N)");
                c = Convert.ToChar(Console.ReadLine());
            }
            // ascendente
            var listaas = from emple in emp
                        orderby emple.Sueldo ascending
                        select emple;
            Console.WriteLine("ascendente");
            foreach(Empleado j in listaas)
            {
                Console.WriteLine(j.Id.ToString() + " " + j.Nombre + " " + j.Sueldo);
            }
            // descendente
            var listades = from emple in emp
                          orderby emple.Sueldo descending
                          select emple;
            Console.WriteLine("descendente");
            foreach (Empleado j in listades)
            {
                Console.WriteLine(j.Id.ToString()+" "+j.Nombre+" "+j.Sueldo);
            }

            Console.ReadKey();
        }

        public class Ciudad
        {
        public string nombre { get; set; }
        public int codigo { get; set; }
        public Ciudad(string n, int c)
            {
                nombre = n;
                codigo = c;
            }
        }

        public class Empleado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public float Sueldo { get; set; }
            
            public Empleado(int i, string n, float s)
            {
                Id = i;
                Nombre = n;
                Sueldo = s;
            }
        }
    }
}
