using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;
using System.Xml;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream lector = new FileStream("Agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            //while (lector.Length > lector.Position)
            //{
            //    Console.Write((char)lector.ReadByte());
            //}
            //lector.Close();
            //Console.ReadKey();

            //Leer();
            //escribir();
            //Leer();
            

            escribirXML();
            leerXML();
            Console.ReadKey();

        }

        private static void Leer()
        {
            StreamReader lector = File.OpenText("Agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\tE-Mail\t\t\tTelefono");
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            }
            while (linea != null);
            lector.Close();
        }
        private static void escribir()
        {
            StreamWriter escritor = File.AppendText("Agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto");
            string rta = "S";
            while (rta == "S")
            {
                Console.WriteLine("Ingrese nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese apellido:");
                string apellido = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese e-mail:");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese telefono:");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);

                Console.WriteLine("desea ingresar otro contacto? (S/N)");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }

        private static void escribirXML()
        {
            XmlTextWriter escritorXML = new XmlTextWriter("Agenda.xml", null);
            escritorXML.Formatting = Formatting.Indented;
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElemnt");
            StreamReader lector = File.OpenText("Agenda.txt");
            string linea;
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    escritorXML.WriteStartElement("contactos");
                    escritorXML.WriteStartElement("nombres");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("apellido");
                    escritorXML.WriteValue(valores[1]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("email");
                    escritorXML.WriteValue(valores[2]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("telefono");
                    escritorXML.WriteValue(valores[3]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteEndElement();
                }
            }
            while (linea != null);
            escritorXML.WriteEndElement();
            escritorXML.WriteEndDocument();
            escritorXML.Close();

            lector.Close();

        }

        private static void leerXML()
        {
            XmlTextReader lectorXML = new XmlTextReader("Agenda.xml");
            string tagAnterior = "";
            while (lectorXML.Read())
            {
                if (lectorXML.NodeType == XmlNodeType.Element)
                {
                    tagAnterior = lectorXML.Name;
                }
                else if(lectorXML.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(tagAnterior + ": " + lectorXML.Value);
                }
            }
            lectorXML.Close();
        }
    }
}

