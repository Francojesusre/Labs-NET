using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Lab02
{
    class ManejadorArchivoTxt:ManejadorArchivo
    {
        protected string connectionString { 
            get 
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;
                       Data Source=D:\ISI\2020\.NET\Unidades\Unidad 4\Lab02\Lab02\bin\Debug;" +
                       "Extended Properties='text;HDR=Yes;FMT=Delimited'";
            } 
        }
        public override DataTable getTabla()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdSelect = new OleDbCommand("select * from agenda.txt", conn);
                conn.Open();
                OleDbDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if(reader != null)
                {
                    contactos.Load(reader);
                }
                conn.Close();
                return contactos;
            }          
        }
        public override void aplicaCambios()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdInsert = new OleDbCommand("insert into agenda.txt values (@id,@nombre,@apellido,@email,@telefono)", conn);
                cmdInsert.Parameters.Add("@id", OleDbType.Integer);
                cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@email", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdUpdate = new OleDbCommand("update agenda.txt set nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono where id=@id", conn);
                cmdUpdate.Parameters.Add("@id", OleDbType.Integer);
                cmdUpdate.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdDelete = new OleDbCommand("delete from agenda.txt whefe id=@id", conn);
                cmdDelete.Parameters.Add("@id", OleDbType.Integer);

                DataTable filaNueva = misContactos.GetChanges(DataRowState.Added);
                DataTable filaBorradas = misContactos.GetChanges(DataRowState.Deleted);
                DataTable filaModificadas = misContactos.GetChanges(DataRowState.Modified);

                conn.Open();
                
                if(filaNueva != null)
                {
                    foreach(DataRow fila in filaBorradas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["email"];
                        cmdInsert.Parameters["@telefono"].Value = fila["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                if(filaBorradas != null)
                {
                    foreach(DataRow fila in filaBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = fila["@id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                if (filaModificadas != null)
                {
                    foreach (DataRow fila in filaModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["email"];
                        cmdUpdate.Parameters["@telefono"].Value = fila["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }


            }
        }
    }
}
