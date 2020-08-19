namespace Entity_Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Academia : DbContext
    {
        public Academia()
            : base("name=Academia")
        {
        }

        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
