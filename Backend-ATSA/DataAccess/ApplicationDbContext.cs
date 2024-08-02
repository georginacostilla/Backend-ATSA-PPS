using System;
using Backend_ATSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<CicloLectivo> CiclosLectivos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<PlanMateria> PlanMaterias { get; set; }
        public DbSet<Correlatividad> Correlatividades { get; set; }
        public DbSet<Equivalencia> Equivalencias { get; set; }
        public DbSet<Cursada> Cursadas { get; set; }
        public DbSet<CursadaAlumno> CursadaAlumnos { get; set; }
        public DbSet<Regularidad> Regularidades { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<ExamenAlumno> ExamenAlumnos { get; set; }
        public DbSet<ExamenDocente> ExamenDocentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Correlatividad>()
               .HasOne(c => c.Materia)
               .WithMany()
               .HasForeignKey(c => c.MateriaId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Correlatividad>()
                .HasOne(c => c.MateriaRegular)
                .WithMany()
                .HasForeignKey(c => c.MateriaRegularId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Correlatividad>()
                .HasOne(c => c.MateriaAprobada)
                .WithMany()
                .HasForeignKey(c => c.MateriaAprobadaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

