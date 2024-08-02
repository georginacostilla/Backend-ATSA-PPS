using System;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
	public interface IMateriaRepository
	{
        public Task<List<Carrera>> ObtenerCarreras(int planid);
    }
}

