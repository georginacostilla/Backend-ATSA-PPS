using System;
using Backend_ATSA.DataAccess.Repositories;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ATSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
	{
        private readonly IPlanRepository _planRepository;

        public PlanController(IPlanRepository planRepository)
        {
            _planRepository = planRepository;
        }

        [HttpGet("Carrera/{id}")]
        public async Task<IActionResult> ObtenerCiclosLectivos([FromRoute] int id)
        {
            var lista = await _planRepository.ObtenerPlanes(id);

            return ResponseFactory.CreateSuccessResponse(200, lista);
        }
    }
}

