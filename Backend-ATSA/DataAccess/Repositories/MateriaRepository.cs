using System;
using System.Numerics;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess.Repositories
{
	public class MateriaRepository : IMateriaRepository
	{
        protected readonly ApplicationDbContext _context;

        public MateriaRepository(ApplicationDbContext context)
		{
            _context = context;
        }

        public async Task<List<Materia>> ObtenerMateriasPorPlan(int planid)
        {
            var lista = _context.Set<PlanMateria>()
                              .Where(pm => pm.Plan.Id == planid && pm.Plan.Eliminado == 0 && pm.Materia.Eliminado == 0)
                              .Select(pm => pm.Materia)
                              .ToList();

            return lista;
        }

    }
}

