using System;
namespace Backend_ATSA.Entities
{
	public class Alumno
	{
		public int Id { get; set; }
		public int? Legajo { get; set; }
		public int Dni { get; set; }
		public string Apellidos { get; set; }
		public string Nombres { get; set; }
        public int Ingreso { get; set; }
		public int DeudorDoc { get; set; }
		public string? DeudorDocComentario { get; set; }
		public int DeudorArancelario { get; set; } = 0;
		public string? DeudorArancelarioComentario { get; set; }
		public int Eliminado { get; set; } = 0;
    }
}

