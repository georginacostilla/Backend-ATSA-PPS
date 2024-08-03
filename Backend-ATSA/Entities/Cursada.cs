using System;
namespace Backend_ATSA.Entities
{
	public class Cursada
	{
		public int Id { get; set; }
		public CicloLectivo CicloLectivo { get; set; }
		public Regimen Regimen { get; set; }
		public int Activo { get; set; }
		public Materia Materia { get; set; }
		public Docente Docente { get; set; }
		public ICollection<CursadaAlumno> CursadaAlumnos { get; set; }
        public int Eliminado { get; set; } = 0;
    }

	public enum Regimen
	{
		PrimerCuat = 1,
		SegundoCuat = 2,
		Anual = 3
	}


}

