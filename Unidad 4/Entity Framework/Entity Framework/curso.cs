namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cursos")]
    public partial class curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curso()
        {
            alumnos_inscripciones = new HashSet<alumnos_inscripciones>();
            docentes_cursos = new HashSet<docentes_cursos>();
        }

        [Key]
        public int id_curso { get; set; }

        public int id_materia { get; set; }

        public int id_comision { get; set; }

        public int anio_calendario { get; set; }

        public int cupo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alumnos_inscripciones> alumnos_inscripciones { get; set; }

        public virtual comisione comisione { get; set; }

        public virtual materia materia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<docentes_cursos> docentes_cursos { get; set; }
    }
}
