using System;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
	public interface ICicloLectivoRepository
	{
        public Task<List<CicloLectivo>> ObtenerCiclosLectivos();
    }
}

