using System;
namespace Backend_ATSA.Entities
{
	public class Usuario
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string ApyNom { get; set;}
		public string Contrasena { get; set; }
		public Rol Rol { get; set; }
		public int Eliminado { get; set; }
    }
}

