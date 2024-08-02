using System;
namespace Backend_ATSA.Entities
{
	public class Docente
	{
		public int Id { get; set; }
		public int? Cuil { get; set; }
		public string Apellidos { get; set; }
		public string Nombres { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Titulo { get; set; }
        public int Eliminado { get; set; }
    }
}

