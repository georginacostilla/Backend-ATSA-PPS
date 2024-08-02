using System;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess.Repositories
{
	public class CicloLectivoRepository : ICicloLectivoRepository
	{
        protected readonly ApplicationDbContext _context;

        public CicloLectivoRepository(ApplicationDbContext context)
		{
            _context = context;
        }

        public async Task<List<CicloLectivo>> ObtenerCiclosLectivos()
        {
            var lista = await _context.Set<CicloLectivo>()
                .Where(ciclo => (int)ciclo.Eliminado == 0)
                .ToListAsync();

            return lista;
        }
    }
}

