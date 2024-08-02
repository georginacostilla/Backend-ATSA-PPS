using System;
using System.Collections.Generic;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.DTOs;
using Backend_ATSA.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Backend_ATSA.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		private readonly IUsuarioRepository _usuarioRepository;

		public UsuarioController(IUsuarioRepository usuarioRepository)
		{
			_usuarioRepository = usuarioRepository;
		}

		[HttpGet]
		public async Task<IActionResult> ObtenerUsuarios()
		{
			var usuarios = await _usuarioRepository.ObtenerUsuarios();

            List<UsuarioDetalleDto> lista = usuarios.Select(entity => new UsuarioDetalleDto
            {
                Id = entity.Id,
				Email = entity.Email,
				ApyNom = entity.ApyNom,
				Rol = new RolUsuarioDto {
					Id = entity.Rol.Id,
					Nombre = entity.Rol.Nombre
				}
            }).ToList();

            return ResponseFactory.CreateSuccessResponse(200, lista);
		}

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerUsuarioPorId([FromRoute] int id)
		{
			var resultado = await _usuarioRepository.ObtenerUsuarioPorId(id);

			if (resultado == null)
			{
				return ResponseFactory.CreateErrorResponse(404, "No existe el usuario");
			}
			else
			{
				var usuario = new UsuarioDetalleDto()
				{
					Id = resultado.Id,
					Email = resultado.Email,
					ApyNom = resultado.Email,
					Rol = new RolUsuarioDto
					{
						Id = resultado.Rol.Id,
						Nombre = resultado.Rol.Nombre
					}
				};

				return ResponseFactory.CreateSuccessResponse(200, usuario);
			};
		}

        [HttpPost]
		public async Task<IActionResult> InsertarUsuario(UsuarioRegistroDto dto)
		{
			if (await _usuarioRepository.UsuarioExiste(dto.Email))
				return ResponseFactory.CreateErrorResponse(409, "Ya existe un usuario con ese email");

			var respuesta = await _usuarioRepository.InsertarUsuario(dto);

			if (respuesta == false)
			{
				return ResponseFactory.CreateErrorResponse(400, "Error al registrar usuario");
			}
			else
			{
				return ResponseFactory.CreateSuccessResponse(201, "Usuario registrado con éxito");
			}
		}


		[HttpPut("{id}")]
		public async Task<IActionResult> ActualizarUsuario([FromRoute] int id, UsuarioActualizacionDto dto)
		{
            if (await _usuarioRepository.UsuarioExiste(id) == false)
                return ResponseFactory.CreateErrorResponse(404, "No existe el usuario.");

            var respuesta = await _usuarioRepository.ActualizarUsuario(id, dto);

            if (respuesta == false)
            {
                return ResponseFactory.CreateErrorResponse(400, "Error al actualizar usuario");
            }
            else
            {
                return ResponseFactory.CreateSuccessResponse(201, "Usuario modificado con éxito");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarUsuario([FromRoute] int id)
        {
            var resultado = await _usuarioRepository.EliminarUsuario(id);

            if (!resultado)
            {
                return ResponseFactory.CreateErrorResponse(500, "Hubo un error al eliminar el usuario");
            }
            else
            {
                return ResponseFactory.CreateSuccessResponse(200, "Usuario eliminado con éxito");
            }
        }

    }
}
