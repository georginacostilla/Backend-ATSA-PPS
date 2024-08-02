using System;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess.Repositories
{
	public class CarreraRepository : ICarreraRepository
	{
        protected readonly ApplicationDbContext _context;

        public CarreraRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Carrera>> ObtenerCarreras()
        {
            var lista = await _context.Set<Carrera>()
                .Where(carrera => (int)carrera.Eliminado == 0)
                .ToListAsync();

            return lista;
        }
    }
}

