using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresa = new DataTable("Empresas");
            DataColumn CustomerID = new DataColumn("CustomerID", typeof(string));
            DataColumn CompanyName = new DataColumn("CompanyName", typeof(string));
            dtEmpresa.Columns.Add(CustomerID);
            dtEmpresa.Columns.Add(CompanyName);

            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=LOCALHOST;Initial Catalog=Northwind;User ID=sa;Password=123";

            SqlCommand mycomando = new SqlCommand();
            mycomando.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            mycomando.Connection = myconn;

            SqlDataAdapter myadap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);
            myconn.Open();

            SqlDataReader mydr = mycomando.ExecuteReader();
            dtEmpresa.Load(mydr);
            myconn.Close();

            //muestra lo obtenido
            Console.WriteLine("lista de empresas obtenidas:");
            foreach (DataRow row in dtEmpresa.Rows)
            {
                Console.WriteLine(row[CustomerID].ToString() +"-"+ row[CompanyName].ToString());
            }
            Console.ReadKey();

            Console.Write("Escriba el CustomerID que desea modificar: ");
            string custid = Console.ReadLine();

            DataRow[] rwEmpresa = dtEmpresa.Select("CustomerID = '" + custid + "'");
            if(rwEmpresa.Length != 1)
            {
                Console.WriteLine("CustomerID no encontrado");
                Console.ReadLine();
                return;
            }
            DataRow rowEmpresa = rwEmpresa[0];
            Console.WriteLine("Nombre actual:" + rowEmpresa["CompanyName"].ToString());
            Console.WriteLine("Escriba nuevo nombre");
            string nuevoNombre = Console.ReadLine();

            rowEmpresa.BeginEdit(); // inicia la edicion  
            rowEmpresa["CompanyName"] = nuevoNombre; 
            rowEmpresa.EndEdit(); //finaliza la edicion

            //objeto command que realiza la actualizacion en la db real
            SqlCommand updcommand = new SqlCommand();
            updcommand.Connection = myconn; //indica la coneccion 
            updcommand.CommandText = "UPDATE customers SET CompanyName = @CompanyName WHERE CustomersID = @CustomerID";
            //indico los parametros. tipo de datos, longitud y nombre de la columna
            updcommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updcommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            //añadimos esto al data adapter
            myadap.UpdateCommand = updcommand;
            myadap.Update(dtEmpresa);

        }
    }
}
