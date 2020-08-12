using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //tabla de alumnos con ID
            DataTable dtAlumno = new DataTable();
            DataColumn dtcolidentificador = new DataColumn("ID");
            DataColumn dtcolNombre = new DataColumn("Nombre");
            DataColumn dtcolApellido = new DataColumn("Apellido");
            dtcolidentificador.ReadOnly = true;
            dtcolidentificador.AutoIncrement = true;
            dtcolidentificador.AutoIncrementSeed = 0; // comienza en 0
            dtcolidentificador.AutoIncrementStep = 1; // incrementa +1
            dtAlumno.Columns.Add(dtcolNombre);
            dtAlumno.Columns.Add(dtcolApellido);
            dtAlumno.Columns.Add(dtcolidentificador);
            dtAlumno.PrimaryKey = new DataColumn[] { dtcolidentificador };

            //filas que se agregan a la tabla de alumnos
            DataRow rwAlumno = dtAlumno.NewRow();
            rwAlumno[dtcolNombre] = "Juan";
            rwAlumno[dtcolApellido] = "Perez";
            dtAlumno.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumno.NewRow();
            rwAlumno2[0] = "Pedro";
            rwAlumno2[1] = "Perez";
            dtAlumno.Rows.Add(rwAlumno2);

            //tabla de cursos
            DataTable dtCurso = new DataTable("Cursos");
            DataColumn colID = new DataColumn("IDCurso", typeof(int));
            colID.ReadOnly = true;
            colID.AutoIncrement = true;
            colID.AutoIncrementStep = 1;
            colID.AutoIncrementSeed = 1;
            DataColumn colCurso = new DataColumn("Curso", typeof(string));
            dtCurso.Columns.Add(colID);
            dtCurso.Columns.Add(colCurso);
            dtCurso.PrimaryKey = new DataColumn[] { colID };

            // fila de la tabla curso
            DataRow rwCurso = dtCurso.NewRow();
            rwCurso[colCurso] = "Informatica";
            dtCurso.Rows.Add(rwCurso);

            // dataset que contiene las dos tablas anteriores
            DataSet dsUniversidad = new DataSet("Universidad");
            dsUniversidad.Tables.Add(dtAlumno);
            dsUniversidad.Tables.Add(dtCurso);

            // tabla de relacion entre curso y alumno
            DataTable dtAlumnos_Curso = new DataTable();
            DataColumn col_ac_IDAlumno = new DataColumn("IDAlumno", typeof(int));
            DataColumn col_ac_IDCurso = new DataColumn("IDCursos", typeof(int));
            dtAlumnos_Curso.Columns.Add(col_ac_IDAlumno);
            dtAlumnos_Curso.Columns.Add(col_ac_IDCurso);
            dsUniversidad.Tables.Add(dtAlumnos_Curso);

            //relacuion entre ambas tablas (alamno y curso)
            DataRelation relAlumno_ac = new DataRelation("Alumno_Curso", dtcolidentificador, col_ac_IDAlumno);
            DataRelation relCurso_ac = new DataRelation("Curso_Alumno", colID, col_ac_IDCurso);
            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);

            DataRow rwAlumnoCurso = dtAlumnos_Curso.NewRow();
            rwAlumnoCurso[col_ac_IDAlumno] = 0; //alumno: juan perez
            rwAlumnoCurso[col_ac_IDCurso] = 1; //curso: informatica
            dtAlumnos_Curso.Rows.Add(rwAlumnoCurso);

            rwAlumnoCurso = dtAlumnos_Curso.NewRow();
            rwAlumnoCurso[col_ac_IDAlumno] = 1; //alumno: pedro perez
            rwAlumnoCurso[col_ac_IDCurso] = 1; //curso: informatica
            dtAlumnos_Curso.Rows.Add(rwAlumnoCurso);

            //recorre y muestra lista
            Console.WriteLine("Ingrese nombre del curso: ");
            string materia = Console.ReadLine();
            Console.WriteLine("lista de almnos de: " + materia);
            DataRow[] row_CursoInf = dtCurso.Select("Curso = '" + materia + "'");//crea array de filas recorriendo la tabla de cursos cuya columna curso sea "materia"
            foreach (DataRow rowCu in row_CursoInf)
            {
                DataRow[] row_AlumnoInf = rowCu.GetChildRows(relCurso_ac);
                foreach (DataRow rowAl in row_AlumnoInf)
                {
                    Console.WriteLine(rowAl.GetParentRow(relAlumno_ac)[dtcolApellido].ToString() + ", " + rowAl.GetParentRow(relAlumno_ac)[dtcolNombre].ToString());
                } 
            }
            Console.ReadKey();

            //Console.WriteLine("Listado de Alumnos: ");
            //foreach (DataRow row in dtAlumno.Rows)
            //{
            //    Console.WriteLine(row[dtcolApellido].ToString() + ", " + row[dtcolNombre].ToString());
            //}
            //Console.ReadKey();


        }
    }
}
