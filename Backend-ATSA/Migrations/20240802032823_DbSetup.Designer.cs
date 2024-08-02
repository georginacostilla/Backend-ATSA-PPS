﻿// <auto-generated />
using System;
using Backend_ATSA.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_ATSA.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240802032823_DbSetup")]
    partial class DbSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend_ATSA.Entities.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeudorArancelario")
                        .HasColumnType("int");

                    b.Property<string>("DeudorArancelarioComentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeudorDoc")
                        .HasColumnType("int");

                    b.Property<string>("DeudorDocComentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<int>("Eliminado")
                        .HasColumnType("int");

                    b.Property<int>("Ingreso")
                        .HasColumnType("int");

                    b.Property<int?>("Legajo")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Eliminado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.CicloLectivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Eliminado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CiclosLectivos");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Correlatividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MateriaAprobadaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaRegularId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Rendir")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MateriaAprobadaId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("MateriaRegularId");

                    b.ToTable("Correlatividades");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Cursada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Activo")
                        .HasColumnType("int");

                    b.Property<int>("CicloLectivoId")
                        .HasColumnType("int");

                    b.Property<int>("DocenteId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int>("Regimen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CicloLectivoId");

                    b.HasIndex("DocenteId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Cursadas");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.CursadaAlumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<int>("CondicionAlumno")
                        .HasColumnType("int");

                    b.Property<int>("CursadaId")
                        .HasColumnType("int");

                    b.Property<double?>("Parcial1")
                        .HasColumnType("float");

                    b.Property<double?>("Parcial2")
                        .HasColumnType("float");

                    b.Property<double?>("Parcial3")
                        .HasColumnType("float");

                    b.Property<double?>("Parcial4")
                        .HasColumnType("float");

                    b.Property<int?>("PorcentajeHoras")
                        .HasColumnType("int");

                    b.Property<int?>("PromedioParciales")
                        .HasColumnType("int");

                    b.Property<double?>("Rec1")
                        .HasColumnType("float");

                    b.Property<double?>("Rec2")
                        .HasColumnType("float");

                    b.Property<double?>("Rec3")
                        .HasColumnType("float");

                    b.Property<double?>("Rec4")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("CursadaId");

                    b.ToTable("CursadaAlumnos");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Docente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Cuil")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Eliminado")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Docentes");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Equivalencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Eliminado")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("Equivalencias");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Examen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Acta")
                        .HasColumnType("int");

                    b.Property<int>("Activo")
                        .HasColumnType("int");

                    b.Property<int>("CicloLectivoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Libro")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int>("Tomo")
                        .HasColumnType("int");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CicloLectivoId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Examenes");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.ExamenAlumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<int>("Condicion")
                        .HasColumnType("int");

                    b.Property<int>("ExamenId")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<string>("Permiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("ExamenId");

                    b.ToTable("ExamenAlumnos");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.ExamenDocente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DocenteId")
                        .HasColumnType("int");

                    b.Property<int>("ExamenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocenteId");

                    b.HasIndex("ExamenId");

                    b.ToTable("ExamenDocentes");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<int>("Eliminado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarreraId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.PlanMateria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.HasIndex("PlanId");

                    b.ToTable("PlanMaterias");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Regularidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrigenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("OrigenId");

                    b.ToTable("Regularidades");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApyNom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Eliminado")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Correlatividad", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Materia", "MateriaAprobada")
                        .WithMany()
                        .HasForeignKey("MateriaAprobadaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Materia", "MateriaRegular")
                        .WithMany()
                        .HasForeignKey("MateriaRegularId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("MateriaAprobada");

                    b.Navigation("MateriaRegular");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Cursada", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.CicloLectivo", "CicloLectivo")
                        .WithMany()
                        .HasForeignKey("CicloLectivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("DocenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CicloLectivo");

                    b.Navigation("Docente");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.CursadaAlumno", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Cursada", null)
                        .WithMany("CursadaAlumnos")
                        .HasForeignKey("CursadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Equivalencia", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Examen", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.CicloLectivo", "CicloLectivo")
                        .WithMany()
                        .HasForeignKey("CicloLectivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CicloLectivo");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.ExamenAlumno", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Examen", null)
                        .WithMany("ExamenAlumno")
                        .HasForeignKey("ExamenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.ExamenDocente", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("DocenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Examen", null)
                        .WithMany("Tribunal")
                        .HasForeignKey("ExamenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Docente");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Materia", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Plan", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.PlanMateria", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Plan", null)
                        .WithMany("PlanMaterias")
                        .HasForeignKey("PlanId");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Regularidad", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_ATSA.Entities.Cursada", "Origen")
                        .WithMany()
                        .HasForeignKey("OrigenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("Origen");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Usuario", b =>
                {
                    b.HasOne("Backend_ATSA.Entities.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Cursada", b =>
                {
                    b.Navigation("CursadaAlumnos");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Examen", b =>
                {
                    b.Navigation("ExamenAlumno");

                    b.Navigation("Tribunal");
                });

            modelBuilder.Entity("Backend_ATSA.Entities.Plan", b =>
                {
                    b.Navigation("PlanMaterias");
                });
#pragma warning restore 612, 618
        }
    }
}
