using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Menu();
        }
        public void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1.	Alta de Usuario");
                Console.WriteLine("2.	Modificación de Usuario");
                Console.WriteLine("3.	Baja de Usuario");
                Console.WriteLine("4.	Consulta de Usuarios");
                Console.WriteLine("5.	Consulta de Usuarios con Filtro");
                Console.WriteLine("Ingrese una opcion:");
                op = int.Parse(Console.ReadLine());
            } while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5);
            switch (op)
            {
                case 1:
                    Alta();
                    Console.ReadKey();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
        public int Alta()
        {
            using (var context = new AcademiaEntities())
            {
                try
                {
                    var usuario = new usuario()
                    {
                        nombre_usuario = "Usuario",
                        clave = "clave",
                        habilitado = true
                    };
                    context.usuarios.Add(usuario);
                    context.SaveChanges();

                    return usuario.id_usuario;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error: " + ex);
                    return 0;
                }
            }
        }
    }
}
