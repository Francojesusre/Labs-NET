using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{

    public class Usuarios
    {

        public SqlDataAdapter daUsuarios { get; set; }

        public SqlConnection Conn { get; set; }

        public Usuarios()
        {
            Conn = new SqlConnection("Data Source = localhost; Initial Catalog = academia; Integrated Security = true;");            
            /*
             * Este connection string es para conectarse con la base de datos academia en el servidor
             * del departamento sistemas desde una PC de los laboratorios de sistemas,
             * si realiza este Laboratorio desde su PC puede probar el siguiente connection string
             * 
             * "Data Source=localhost;Initial Catalog=academia;Integrated Security=true;"
             * 
             * Si realiza esta práctica sobre el MS SQL SERVER 2005 Express Edition entonce debe 
             * utilizar el siguiente connection string
             * 
             * "Data Source=localhost\SQLEXPRESS;Initial Catalog=academia;Integrated Security=true;"
            */
            daUsuarios = new SqlDataAdapter("select * from usuarios", Conn);

            daUsuarios.UpdateCommand =
            new SqlCommand(" UPDATE usuarios " +
            " SET tipo_doc = @tipo_doc, nro_doc = @nro_doc, fecha_nac = @fecha_nac, " +
            " apellido = @apellido, nombre = @nombre, direccion = @direccion, " +
            " telefono = @telefono, email = @email, celular = @celular, usuario = @usuario, " +
            " clave = @clave WHERE id=@id ", Conn);
            daUsuarios.UpdateCommand.Parameters.Add("@tipo_doc", SqlDbType.Int, 1, "tipo_doc");
            daUsuarios.UpdateCommand.Parameters.Add("@nro_doc", SqlDbType.Int, 1, "nro_doc");
            daUsuarios.UpdateCommand.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 1, "fecha_nac");
            daUsuarios.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            daUsuarios.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            daUsuarios.UpdateCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50, "direccion");
            daUsuarios.UpdateCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 50, "telefono");
            daUsuarios.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");
            daUsuarios.UpdateCommand.Parameters.Add("@celular", SqlDbType.VarChar, 50, "celular");
            daUsuarios.UpdateCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 50, "usuario");
            daUsuarios.UpdateCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            daUsuarios.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 1, "id");
            daUsuarios.InsertCommand =
            new SqlCommand(" INSERT INTO usuarios(tipo_doc,nro_doc,fecha_nac,apellido, " +
                " nombre,direccion,telefono,email,celular,usuario,clave) " +
                " VALUES (@tipo_doc,@nro_doc,@fecha_nac,@apellido,@nombre,@direccion, " +
                " @telefono,@email,@celular, @usuario, @clave  )", Conn);
            daUsuarios.InsertCommand.Parameters.Add("@tipo_doc", SqlDbType.Int, 1, "tipo_doc");
            daUsuarios.InsertCommand.Parameters.Add("@nro_doc", SqlDbType.Int, 1, "nro_doc");
            daUsuarios.InsertCommand.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 1, "fecha_nac");
            daUsuarios.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            daUsuarios.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            daUsuarios.InsertCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50, "direccion");
            daUsuarios.InsertCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 50, "telefono");
            daUsuarios.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");
            daUsuarios.InsertCommand.Parameters.Add("@celular", SqlDbType.VarChar, 50, "celular");
            daUsuarios.InsertCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 50, "usuario");
            daUsuarios.InsertCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            daUsuarios.DeleteCommand = new SqlCommand(" DELETE FROM usuarios WHERE id=@id ", Conn);
            daUsuarios.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 1, "id");
        }

        public DataTable GetAll()
        {
            DataTable dtUsuarios = new DataTable();
            daUsuarios.Fill(dtUsuarios);
            return dtUsuarios;
        }
        public void GuardarCambios(DataTable dtUsuarios)
        {
            daUsuarios.Update(dtUsuarios);
            dtUsuarios.AcceptChanges();
        }

    }
}
