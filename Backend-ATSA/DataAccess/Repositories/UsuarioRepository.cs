using System;
using Backend_ATSA.DataAccess.Repositories.Interfaces;
using Backend_ATSA.DTOs;
using Backend_ATSA.Entities;
using Backend_ATSA.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Backend_ATSA.DataAccess.Repositories
{
	public class UsuarioRepository : IUsuarioRepository
	{
        protected readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
		{
			_context = context;
		}

        public async Task<Usuario?> AuthenticateCredentials(AuthenticateDto dto)
        {
            var contrasenaEncriptada = PasswordEncryptHelper.EncryptPassword(dto.Contrasena, dto.Email);

            return await _context.Usuarios.Include(o => o.Rol).SingleOrDefaultAsync(x => x.Email == dto.Email && x.Contrasena == contrasenaEncriptada && x.Eliminado == 0);
        }

        public async Task<List<Usuario>> ObtenerUsuarios()
        {
            var lista = await _context.Set<Usuario>()
                .Include(u => u.Rol)
                .Where(usuario => (int)usuario.Eliminado == 0)
                .ToListAsync();

            return lista;
        }

        public async Task<Usuario> ObtenerUsuarioPorId(int id)
        {
            var usuario = await _context.Set<Usuario>()
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.Id == id);

            return usuario;
        }

        public async Task<bool> InsertarUsuario(UsuarioRegistroDto dto)
        {
            var rol = await _context.Set<Rol>()
                .FirstOrDefaultAsync(r => r.Id == dto.RolId);

            if (rol == null) {
                return false;
            }

            var usuario = new Usuario()
            {
                Email = dto.Email,
                Contrasena = PasswordEncryptHelper.EncryptPassword(dto.Contrasena, dto.Email),
                ApyNom = dto.ApyNom,
                Rol = rol
            };

            await _context.Set<Usuario>().AddAsync(usuario);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> ActualizarUsuario(int id, UsuarioActualizacionDto dto)
        {
            var rol = await _context.Set<Rol>()
                .FirstOrDefaultAsync(r => r.Id == dto.RolId);

            if (rol == null)
            {
                return false;
            }

            var usuario = await _context.Set<Usuario>()
                .FirstOrDefaultAsync(r => r.Id == id);

            if (!string.IsNullOrEmpty(dto.Contrasena))
            {
                usuario.Email = dto.Email;
                usuario.Contrasena = PasswordEncryptHelper.EncryptPassword(dto.Contrasena, dto.Email);
                usuario.ApyNom = dto.ApyNom;
                usuario.Rol = rol;
            }
            else
            {
                usuario.Email = dto.Email;
                usuario.ApyNom = dto.ApyNom;
                usuario.Rol = rol;
            }

            _context.Set<Usuario>().Update(usuario);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarUsuario(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (usuario == null) { return false; }

            usuario.Eliminado = 1;

            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<bool> UsuarioExiste(string email)
        {
            return await _context.Usuarios.AnyAsync(x => x.Email == email);
        }

        public async Task<bool> UsuarioExiste(int id)
        {
            return await _context.Usuarios.AnyAsync(x => x.Id == id);
        }


    }
}

