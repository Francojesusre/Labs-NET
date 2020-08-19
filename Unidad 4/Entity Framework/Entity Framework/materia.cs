namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class materia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public materia()
        {
            cursos = new HashSet<curso>();
        }

        [Key]
        public int id_materia { get; set; }

        [Required]
        [StringLength(50)]
        public string desc_materia { get; set; }

        public int hs_semanales { get; set; }

        public int hs_totales { get; set; }

        public int id_plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> cursos { get; set; }

        public virtual plane plane { get; set; }
    }
}
