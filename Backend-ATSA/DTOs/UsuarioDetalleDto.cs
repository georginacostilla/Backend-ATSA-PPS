using System;
namespace Backend_ATSA.DTOs
{
	public class UsuarioDetalleDto
	{
        public int Id { get; set; }
        public string Email { get; set; }
        public string ApyNom { get; set; }
        public RolUsuarioDto Rol { get; set; }
    }
}

