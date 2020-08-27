using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Negocio
{
    public class ManagerUsuarios
    {
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=tp2_net;Integrated Security=False;user=net;password=net");

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                Conn.Open();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios", Conn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                    usuarios.Add(usr);
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Conn.Close();
            }
            return usuarios;
        }

        public void BorrarUsuario(Usuario usuarioActual)
        {
            //Creo el comando para ejecutar la sentencia SQL de DELETE, 
            //le asocio la Conexión también
            SqlCommand cmdDeleteUsuario = new SqlCommand(" DELETE FROM usuarios WHERE id_usuario=@id ", this.Conn);

            //Le agrego los parámetros necesarios
            cmdDeleteUsuario.Parameters.Add(new SqlParameter("@id", usuarioActual.ID.ToString()));

            //Abro la Conexión
            this.Conn.Open();
            //Ejecuto la instrucción SQL de DELETE
            cmdDeleteUsuario.ExecuteNonQuery();

            //Cierro la Conexión
            this.Conn.Close();
        }

        public void ActualizarUsuario(Usuario usuarioActual)
        {
            //Creo el comando para ejecutar la sentencia SQL de DELETE, 
            //le asocio la Conexión también
            SqlCommand cmdActualizarUsuario = new SqlCommand(" UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave," +
                                                    "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email = @email " +
                                                  "WHERE id_usuario=@id", this.Conn);
            cmdActualizarUsuario.Parameters.Add("@id", SqlDbType.Int).Value = usuarioActual.ID;
            cmdActualizarUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuarioActual.NombreUsuario;
            cmdActualizarUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuarioActual.Clave;
            cmdActualizarUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuarioActual.Habilitado;
            cmdActualizarUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuarioActual.Nombre;
            cmdActualizarUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuarioActual.Apellido;
            cmdActualizarUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuarioActual.Email;

            //Abro la Conexión
            this.Conn.Open();
            //Ejecuto la instrucción SQL de UPDATE
            cmdActualizarUsuario.ExecuteNonQuery();
            //Cierro la Conexión
            this.Conn.Close();
        }

        public void AgregarUsuario(Usuario usuarioActual)
        {
            //Creo el comando para ejecutar la sentencia SQL de DELETE, 
            //le asocio la Conexión también
            SqlCommand cmdInsertarUsuario = new SqlCommand("insert into usuarios(nombre_usuario,clave,habilitado,nombre,apellido,email)" +
                                                    "values (@nombre_usuario,@clave,@habilitado,@nombre,@apellido,@email)", this.Conn);
            cmdInsertarUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuarioActual.NombreUsuario;
            cmdInsertarUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuarioActual.Clave;
            cmdInsertarUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuarioActual.Habilitado;
            cmdInsertarUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuarioActual.Nombre;
            cmdInsertarUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuarioActual.Apellido;
            cmdInsertarUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuarioActual.Email;

            //Abro la Conexión
            this.Conn.Open();
            //Ejecuto la instrucción SQL de INSERT
            cmdInsertarUsuario.ExecuteNonQuery();
            //Cierro la Conexión
            this.Conn.Close();
        }
        public Usuario GetOne(int ID)
        {
            Usuario usr = new Usuario();
            try
            {
                Conn.Open();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios where id_usuario = @id", Conn);
                cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Conn.Close();
            }
            return usr;
        }
    }


    public class Usuario
    {
        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public bool Habilitado { get; set; }
    } 

}
