using System;
using Backend_ATSA.DataAccess.Repositories;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ATSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
	{
        private readonly ICarreraRepository _carreraRepository;

        public CarreraController(ICarreraRepository carreraRepository)
        {
            _carreraRepository = carreraRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerCarreras()
        {
            var lista = await _carreraRepository.ObtenerCarreras();

            return ResponseFactory.CreateSuccessResponse(200, lista);
        }

    }
}

