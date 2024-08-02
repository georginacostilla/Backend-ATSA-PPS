using System;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
    public interface ICarreraRepository
    {
        public Task<List<Carrera>> ObtenerCarreras();
    }
}

