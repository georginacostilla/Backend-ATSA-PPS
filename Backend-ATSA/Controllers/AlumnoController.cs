using System;
using Backend_ATSA.DataAccess.Repositories;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.DTOs;
using Backend_ATSA.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ATSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
	{
        private readonly IAlumnoRepository _alumnoRepository;

        public AlumnoController(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarAlumnos(string criterio)
        {
            var resultado = await _alumnoRepository.BuscarAlumnos(criterio);

            if (resultado == null)
            {
                return ResponseFactory.CreateErrorResponse(404, "No se encontraron resultados");
            }
            else
            {
                return ResponseFactory.CreateSuccessResponse(200, resultado);
            };
        }

    }
}

