using System;
using System.Linq;
using Backend_ATSA.DTOs;
using Backend_ATSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
	public class CursadaRepository : ICursadaRepository
	{
        protected readonly ApplicationDbContext _context;

        public CursadaRepository(ApplicationDbContext context)
		{
            _context = context;
        }

        public async Task<List<CursadaDetalleDto>> ObtenerCursadas()
        {
            var cursadas = await _context.Set<Cursada>()
                .Include(c => c.CursadaAlumnos)
                .ThenInclude(ca => ca.Alumno)
                .Include(c => c.CicloLectivo)
                .Include(c => c.Materia)
                .Include(c => c.Docente)
                .Where(cursada => (int)cursada.Eliminado == 0)
                .ToListAsync();

            List<CursadaDetalleDto> lista = cursadas.Select(entity => new CursadaDetalleDto
            {
                Id = entity.Id,
                CicloLectivoId = entity.CicloLectivo.Id,
                CicloLectivoNombre = entity.CicloLectivo.Nombre,
                RegimenId = (int)entity.Regimen,
                RegimenNombre = entity.Regimen.ToString(),
                Activo = entity.Activo,
                MateriaId = entity.Materia.Id,
                MateriaNombre = entity.Materia.Nombre,
                DocenteId = entity.Docente.Id,
                DocenteApellidos = entity.Docente.Apellidos,
                DocenteNombres = entity.Docente.Nombres,
                CursadaAlumnos = entity.CursadaAlumnos.Select(ca => new CursadaAlumnoDetalleDto
                {
                    Id = ca.Id,
                    AlumnoId = ca.Alumno.Id,
                    Legajo = ca.Alumno.Legajo ?? 0,
                    Dni = ca.Alumno.Dni,
                    Apellidos = ca.Alumno.Apellidos,
                    Nombres = ca.Alumno.Nombres,
                    Parcial1 = ca.Parcial1,
                    Parcial2 = ca.Parcial2,
                    Parcial3 = ca.Parcial3,
                    Parcial4 = ca.Parcial4,
                    Rec1 = ca.Rec1,
                    Rec2 = ca.Rec2,
                    Rec3 = ca.Rec3,
                    Rec4 = ca.Rec4,
                    PromedioParciales = ca.PromedioParciales,
                    PorcentajeHoras = ca.PorcentajeHoras,
                    CondicionAlumnoId = (int)ca.CondicionAlumno,
                    CondicionAlumnoNombre = ca.CondicionAlumno.ToString(),
                }).ToList()
            }).ToList();

            return lista;
        }

    }
}

