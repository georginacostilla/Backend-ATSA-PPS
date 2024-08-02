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
    public class CicloLectivoController : ControllerBase
	{
        private readonly ICicloLectivoRepository _cicloLectivoRepository;

        public CicloLectivoController(ICicloLectivoRepository cicloLectivoRepository)
		{
            _cicloLectivoRepository = cicloLectivoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerCiclosLectivos()
        {
            var lista = await _cicloLectivoRepository.ObtenerCiclosLectivos();

            return ResponseFactory.CreateSuccessResponse(200, lista);
        }

    }
}

