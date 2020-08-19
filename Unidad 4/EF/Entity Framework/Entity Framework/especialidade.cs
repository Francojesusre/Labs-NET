namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class especialidade
    {
        [Key]
        public int id_especialidad { get; set; }

        [Required]
        [StringLength(50)]
        public string desc_especialidad { get; set; }
    }
}
