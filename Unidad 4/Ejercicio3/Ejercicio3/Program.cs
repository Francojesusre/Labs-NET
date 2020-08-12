using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicia dataset
            dsUniversidad miUniversidad = new dsUniversidad();

            //inica las tablas
            dsUniversidad.dtAlumnoDataTable dtAlumnos = new dsUniversidad.dtAlumnoDataTable();
            dsUniversidad.dtCursoDataTable dtCursos = new dsUniversidad.dtCursoDataTable();

            //crea un nueva fila dentro de la tabla alumno
            dsUniversidad.dtAlumnoRow rowAlumno = dtAlumnos.NewdtAlumnoRow();
            rowAlumno.Apellido = "Perez";
            rowAlumno.Nombre = "Juan";
            dtAlumnos.AdddtAlumnoRow(rowAlumno);

            //crea una nueva fila en la tabla curso
            dsUniversidad.dtCursoRow rowCurso = dtCursos.NewdtCursoRow();
            rowCurso.Curso = "Informatica";
            dtCursos.AdddtCursoRow(rowCurso);

            //inicia tabla de relacion
            dsUniversidad.dt_Alumnos_CursosDataTable dt_Alumnos_Cursos = new dsUniversidad.dt_Alumnos_CursosDataTable();

            //dsUniversidad.dt_Alumnos_CursosRow rowAlumnosCursos = dt_Alumnos_Cursos.Newdt_Alumnos_CursosRow();

            //agrega la fila y le pasa como paramerto un alumno y el curso
            dt_Alumnos_Cursos.Adddt_Alumnos_CursosRow(rowAlumno, rowCurso);

            //crea un nueva fila dentro de la tabla alumno
            rowAlumno = dtAlumnos.NewdtAlumnoRow();
            rowAlumno.Apellido = "Perez";
            rowAlumno.Nombre = "Pedro";
            dtAlumnos.AdddtAlumnoRow(rowAlumno);

            //agrega la fila y le pasa como paramerto un alumno y el curso
            dt_Alumnos_Cursos.Adddt_Alumnos_CursosRow(rowAlumno, rowCurso);
        }
    }
}
