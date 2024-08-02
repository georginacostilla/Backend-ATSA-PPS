using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend_ATSA.Migrations
{
    /// <inheritdoc />
    public partial class DbSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Legajo = table.Column<int>(type: "int", nullable: true),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingreso = table.Column<int>(type: "int", nullable: false),
                    DeudorDoc = table.Column<int>(type: "int", nullable: false),
                    DeudorDocComentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeudorArancelario = table.Column<int>(type: "int", nullable: false),
                    DeudorArancelarioComentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eliminado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eliminado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CiclosLectivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eliminado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiclosLectivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuil = table.Column<int>(type: "int", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eliminado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planes_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApyNom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materias_Planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Correlatividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    Rendir = table.Column<int>(type: "int", nullable: false),
                    MateriaRegularId = table.Column<int>(type: "int", nullable: false),
                    MateriaAprobadaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correlatividades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Correlatividades_Materias_MateriaAprobadaId",
                        column: x => x.MateriaAprobadaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Correlatividades_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Correlatividades_Materias_MateriaRegularId",
                        column: x => x.MateriaRegularId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cursadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CicloLectivoId = table.Column<int>(type: "int", nullable: false),
                    Regimen = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    DocenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursadas_CiclosLectivos_CicloLectivoId",
                        column: x => x.CicloLectivoId,
                        principalTable: "CiclosLectivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cursadas_Docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "Docentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cursadas_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equivalencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eliminado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equivalencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equivalencias_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CicloLectivoId = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    Libro = table.Column<int>(type: "int", nullable: false),
                    Tomo = table.Column<int>(type: "int", nullable: false),
                    Acta = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examenes_CiclosLectivos_CicloLectivoId",
                        column: x => x.CicloLectivoId,
                        principalTable: "CiclosLectivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examenes_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanMaterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMaterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanMaterias_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanMaterias_Planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Planes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CursadaAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    CursadaId = table.Column<int>(type: "int", nullable: false),
                    Parcial1 = table.Column<double>(type: "float", nullable: true),
                    Parcial2 = table.Column<double>(type: "float", nullable: true),
                    Parcial3 = table.Column<double>(type: "float", nullable: true),
                    Parcial4 = table.Column<double>(type: "float", nullable: true),
                    Rec1 = table.Column<double>(type: "float", nullable: true),
                    Rec2 = table.Column<double>(type: "float", nullable: true),
                    Rec3 = table.Column<double>(type: "float", nullable: true),
                    Rec4 = table.Column<double>(type: "float", nullable: true),
                    PromedioParciales = table.Column<int>(type: "int", nullable: true),
                    PorcentajeHoras = table.Column<int>(type: "int", nullable: true),
                    CondicionAlumno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursadaAlumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursadaAlumnos_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursadaAlumnos_Cursadas_CursadaId",
                        column: x => x.CursadaId,
                        principalTable: "Cursadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regularidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    OrigenId = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regularidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regularidades_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regularidades_Cursadas_OrigenId",
                        column: x => x.OrigenId,
                        principalTable: "Cursadas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamenAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    ExamenId = table.Column<int>(type: "int", nullable: false),
                    Permiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Condicion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamenAlumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamenAlumnos_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamenAlumnos_Examenes_ExamenId",
                        column: x => x.ExamenId,
                        principalTable: "Examenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamenDocentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocenteId = table.Column<int>(type: "int", nullable: false),
                    ExamenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamenDocentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamenDocentes_Docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "Docentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamenDocentes_Examenes_ExamenId",
                        column: x => x.ExamenId,
                        principalTable: "Examenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Correlatividades_MateriaAprobadaId",
                table: "Correlatividades",
                column: "MateriaAprobadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Correlatividades_MateriaId",
                table: "Correlatividades",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Correlatividades_MateriaRegularId",
                table: "Correlatividades",
                column: "MateriaRegularId");

            migrationBuilder.CreateIndex(
                name: "IX_CursadaAlumnos_AlumnoId",
                table: "CursadaAlumnos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_CursadaAlumnos_CursadaId",
                table: "CursadaAlumnos",
                column: "CursadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursadas_CicloLectivoId",
                table: "Cursadas",
                column: "CicloLectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursadas_DocenteId",
                table: "Cursadas",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursadas_MateriaId",
                table: "Cursadas",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equivalencias_MateriaId",
                table: "Equivalencias",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamenAlumnos_AlumnoId",
                table: "ExamenAlumnos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamenAlumnos_ExamenId",
                table: "ExamenAlumnos",
                column: "ExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamenDocentes_DocenteId",
                table: "ExamenDocentes",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamenDocentes_ExamenId",
                table: "ExamenDocentes",
                column: "ExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_CicloLectivoId",
                table: "Examenes",
                column: "CicloLectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_MateriaId",
                table: "Examenes",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_PlanId",
                table: "Materias",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_CarreraId",
                table: "Planes",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMaterias_MateriaId",
                table: "PlanMaterias",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMaterias_PlanId",
                table: "PlanMaterias",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Regularidades_AlumnoId",
                table: "Regularidades",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Regularidades_OrigenId",
                table: "Regularidades",
                column: "OrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Correlatividades");

            migrationBuilder.DropTable(
                name: "CursadaAlumnos");

            migrationBuilder.DropTable(
                name: "Equivalencias");

            migrationBuilder.DropTable(
                name: "ExamenAlumnos");

            migrationBuilder.DropTable(
                name: "ExamenDocentes");

            migrationBuilder.DropTable(
                name: "PlanMaterias");

            migrationBuilder.DropTable(
                name: "Regularidades");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Examenes");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Cursadas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "CiclosLectivos");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Carreras");
        }
    }
}
