using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace Lab02
{
    class ManejadorArchivo
    {
        protected DataTable misContactos;
        public ManejadorArchivo()
        {
            misContactos = getTabla();
        }

        public virtual DataTable getTabla()
        {
            return new DataTable();
        }
        public virtual void aplicaCambios()
        {

        }
        public void listar()
        {
            foreach(DataRow fila in misContactos.Rows)
            {
                if(fila.RowState != DataRowState.Deleted)
                {
                    foreach(DataColumn col in misContactos.Columns)
                    {
                        Console.WriteLine("{0}: {1}", col.ColumnName, fila[col]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void nuevaFila()
        {
            DataRow fila = misContactos.NewRow();
            foreach(DataColumn col in misContactos.Columns)
            {
                Console.WriteLine("ingrese {0}:", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
            misContactos.Rows.Add(fila);
        }

        public void editarFila()
        {
            Console.WriteLine("ingrese el numero de fila a editar");
            int nroFila = int.Parse(Console.ReadLine());
            DataRow fila = misContactos.Rows[nroFila - 1];
            for (int nroCol = 1; nroCol < misContactos.Columns.Count; nroCol++)
            {
                DataColumn col = misContactos.Columns[nroCol];
                Console.Write("ingrese {0}:", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
        }
        public void eliminarFila()
        {
            Console.WriteLine("ingrese el numero de fila a eliminar");
            int fila = int.Parse(Console.ReadLine());
            misContactos.Rows[fila - 1].Delete();
        }
    }
}
