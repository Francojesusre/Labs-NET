namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public persona()
        {
            alumnos_inscripciones = new HashSet<alumnos_inscripciones>();
            docentes_cursos = new HashSet<docentes_cursos>();
            usuarios = new HashSet<usuario>();
        }

        [Key]
        public int id_persona { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        public DateTime fecha_nac { get; set; }

        public int? legajo { get; set; }

        public int tipo_persona { get; set; }

        public int id_plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alumnos_inscripciones> alumnos_inscripciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<docentes_cursos> docentes_cursos { get; set; }

        public virtual plane plane { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
