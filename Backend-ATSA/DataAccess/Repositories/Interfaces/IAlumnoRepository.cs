using System;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
	public interface IAlumnoRepository
	{
        public Task<List<Alumno>> BuscarAlumnos(string criterio);
        public Task<string> ChequearAlumnoCursada(int alumnoid, int materiaid);
    }
}

