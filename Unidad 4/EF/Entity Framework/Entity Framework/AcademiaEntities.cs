namespace Entity_Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AcademiaEntities : DbContext
    {
        public AcademiaEntities()
            : base("name=AcademiaEntities")
        {
        }

        public virtual DbSet<especialidade> especialidades { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<especialidade>()
                .Property(e => e.desc_especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.nombre_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
