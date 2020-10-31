using System;
using Microsoft.EntityFrameworkCore;

namespace poiesis_api
{
    public partial class PoiesisDBContext : DbContext
    {

        public virtual DbSet<Texto> Textos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=PoiesisDB;User=sa;Password=hola1234;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Texto>(entity =>
            {
                entity.HasKey(i => i.idTexto);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Texto)
                    .HasForeignKey(d => d.idUsuario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Texto_Usuario");
            });


            modelBuilder.Entity<Usuario>(entity =>
            {

                entity.HasKey(i => i.idUsuario);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}