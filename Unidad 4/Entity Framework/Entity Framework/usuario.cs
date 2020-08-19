namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string clave { get; set; }

        public bool habilitado { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public bool? cambia_clave { get; set; }

        public int? id_persona { get; set; }

        public virtual persona persona { get; set; }
    }
}
