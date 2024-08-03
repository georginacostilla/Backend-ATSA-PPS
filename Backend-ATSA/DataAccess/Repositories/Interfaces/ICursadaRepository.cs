using System;
using Backend_ATSA.DTOs;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
	public interface ICursadaRepository
	{
        public Task<List<CursadaDetalleDto>> ObtenerCursadas();
    }
}

