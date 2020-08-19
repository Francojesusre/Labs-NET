namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comisione
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comisione()
        {
            cursos = new HashSet<curso>();
        }

        [Key]
        public int id_comision { get; set; }

        [Required]
        [StringLength(50)]
        public string desc_comision { get; set; }

        public int anio_especialidad { get; set; }

        public int id_plan { get; set; }

        public virtual plane plane { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> cursos { get; set; }
    }
}
