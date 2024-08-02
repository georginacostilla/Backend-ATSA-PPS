using System;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.DTOs;
using Backend_ATSA.Helpers;
using Backend_ATSA.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ATSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
	{
        private TokenJWTHelper _tokenJWTHelper;
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController(IUsuarioRepository usuarioRepository, IConfiguration configuration)
		{
            _tokenJWTHelper = new TokenJWTHelper(configuration);
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthenticateDto dto)
        {
            var userCredentials = await _usuarioRepository.AuthenticateCredentials(dto);
            if (userCredentials is null) return ResponseFactory.CreateErrorResponse(402, "Las credenciales son incorrectas o el usuario no existe");

            var token = _tokenJWTHelper.GenerateToken(userCredentials);
            var usuario = new UsuarioLoginDto()
            {
                ApYNom = userCredentials.ApyNom,
                Email = userCredentials.Email,
                Rol = new RolUsuarioDto
                {
                    Id = userCredentials.Rol.Id,
                    Nombre = userCredentials.Rol.Nombre
                },
                Token = token
            };

            return ResponseFactory.CreateSuccessResponse(200, usuario);
        }

    }
}

