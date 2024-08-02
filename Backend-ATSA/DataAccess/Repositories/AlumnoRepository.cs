using System;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.DTOs;
using Backend_ATSA.Entities;
using Backend_ATSA.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess.Repositories
{
	public class AlumnoRepository : IAlumnoRepository
	{
        protected readonly ApplicationDbContext _context;

        public AlumnoRepository(ApplicationDbContext context)
		{
            _context = context;
        }

        public async Task<List<Alumno>> BuscarAlumnos(string criterio)
        {
            IQueryable<Alumno> query;

            if (int.TryParse(criterio, out int searchInt))
            {
                query = _context.Set<Alumno>().Where(a => a.Legajo == searchInt || a.Dni == searchInt);
            }
            else
            {
                query = _context.Set<Alumno>().Where(a => a.Apellidos.Contains(criterio) || a.Nombres.Contains(criterio));
            }

            return query.ToList();
        }

        public async Task<string> ChequearAlumnoCursada(int alumnoid, int materiaid)
        {
            string output = "";

            int?[] correlativasRegulares = _context.Set<Correlatividad>()
                  .Where(c => c.MateriaId == materiaid && c.Rendir == 0)
                  .Select(c => c.MateriaRegularId)
                  .ToArray();

            int?[] correlativasAprobadas = _context.Set<Correlatividad>()
                  .Where(c => c.MateriaId == materiaid && c.Rendir == 0)
                  .Select(c => c.MateriaAprobadaId)
                  .ToArray();

            if (correlativasAprobadas == null && correlativasRegulares == null)
            {
                output = "Ok";
                return output;
            }

            

            return output;
        }

    }
}

