using System;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
	public interface IPlanRepository
	{
        public Task<List<Plan>> ObtenerPlanesPorCarrera(int carreraid);
    }
}

