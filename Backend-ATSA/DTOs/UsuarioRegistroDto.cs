using System;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DTOs
{
	public class UsuarioRegistroDto
	{
        public string Email { get; set; }
        public string ApyNom { get; set; }
        public string Contrasena { get; set; }
        public int RolId { get; set; }
    }
}

