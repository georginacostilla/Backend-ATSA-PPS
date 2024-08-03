using System;
using Backend_ATSA.DataAccess.Repositories;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ATSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
	{
        private readonly IMateriaRepository _materiaRepository;

        public MateriaController(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [HttpGet("Plan/{id}")]
        public async Task<IActionResult> ObtenerMateriasPorPlan([FromRoute] int id)
        {
            var lista = await _materiaRepository.ObtenerMateriasPorPlan(id);

            return ResponseFactory.CreateSuccessResponse(200, lista);
        }

    }
}

