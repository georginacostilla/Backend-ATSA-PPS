using System;
using Backend_ATSA.DTOs;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DataAccess.Repositories.Interfaces
{
	public interface IUsuarioRepository
	{
        public Task<Usuario?> AuthenticateCredentials(AuthenticateDto dto);
        public Task<List<Usuario>> ObtenerUsuarios();
        public Task<Usuario> ObtenerUsuarioPorId(int id);
        public Task<bool> InsertarUsuario(UsuarioRegistroDto dto);
        public Task<bool> ActualizarUsuario(int id, UsuarioActualizacionDto dto);
        public Task<bool> EliminarUsuario(int id);
        public Task<bool> UsuarioExiste(string email);
        public Task<bool> UsuarioExiste(int id);
    }
}

