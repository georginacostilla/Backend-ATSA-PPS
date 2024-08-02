using System;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess.Repositories
{
	public class PlanRepository : IPlanRepository
	{
        protected readonly ApplicationDbContext _context;

        public PlanRepository(ApplicationDbContext context)
		{
            _context = context;
        }

        public async Task<List<Plan>> ObtenerPlanes(int carreraid)
        {
            var lista = await _context.Set<Plan>()
                .Where(plan => (int)plan.Eliminado == 0 && plan.CarreraId == carreraid)
                .ToListAsync();

            return lista;
        }

    }
}

