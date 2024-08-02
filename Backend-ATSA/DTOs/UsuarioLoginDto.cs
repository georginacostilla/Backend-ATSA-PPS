using System;
namespace Backend_ATSA.DTOs
{
	public class UsuarioLoginDto
	{
        public string ApYNom { get; set; }
        public string Email { get; set; }
        public RolUsuarioDto Rol { get; set; }
        public string Token { get; set; }
    }
}

