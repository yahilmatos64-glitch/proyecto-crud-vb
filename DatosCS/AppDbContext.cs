using Entidad;
using Microsoft.EntityFrameworkCore;

namespace DatosCS
{
    public class AppDbContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Idioma> Idiomas { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Inscripcion> Inscripciones { get; set; }

        public DbSet<Pago> Pagos { get; set; }

        public DbSet<Aula> Aulas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(
@"Server=(localdb)\MSSQLLocalDB;Database=AcademiaIdiomasDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>()
    .ToTable("Usuarios", "dbo");

            modelBuilder.Entity<Estudiante>()
                .ToTable("Estudiantes", "dbo");

            modelBuilder.Entity<Profesor>()
                .ToTable("Profesores", "dbo");

            modelBuilder.Entity<Idioma>()
                .ToTable("Idiomas", "dbo");

            modelBuilder.Entity<Curso>()
                .ToTable("Cursos", "dbo");

            modelBuilder.Entity<Inscripcion>()
                .ToTable("Inscripciones", "dbo");

            modelBuilder.Entity<Pago>()
                .ToTable("Pagos", "dbo");

            modelBuilder.Entity<Aula>()
                .ToTable("Aulas", "dbo");

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Curso>()
                .HasOne(c => c.Idioma)
                .WithMany(i => i.Cursos)
                .HasForeignKey(c => c.IdIdioma);


            modelBuilder.Entity<Curso>()
                .HasOne(c => c.Profesor)
                .WithMany(p => p.Cursos)
                .HasForeignKey(c => c.IdProfesor);


            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Estudiante)
                .WithMany(e => e.Inscripciones)
                .HasForeignKey(i => i.IdEstudiante);


            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Curso)
                .WithMany(c => c.Inscripciones)
                .HasForeignKey(i => i.IdCurso);


            modelBuilder.Entity<Pago>()
                .HasOne(p => p.Inscripcion)
                .WithMany(i => i.Pagos)
                .HasForeignKey(p => p.IdInscripcion);

        }

    }
}