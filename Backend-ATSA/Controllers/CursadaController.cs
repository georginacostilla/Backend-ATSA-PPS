using System;
using Backend_ATSA.DataAccess.Repositories;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ATSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursadaController : ControllerBase
    {
        private readonly ICursadaRepository _cursadaRepository;

        public CursadaController(ICursadaRepository cursadaRepository)
		{
            _cursadaRepository = cursadaRepository;
		}

        [HttpGet]
        public async Task<IActionResult> ObtenerCursadas()
        {
            var lista = await _cursadaRepository.ObtenerCursadas();

            return ResponseFactory.CreateSuccessResponse(200, lista);
        }
    }
}

