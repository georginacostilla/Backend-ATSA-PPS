using System;
namespace Backend_ATSA.Entities
{
	public class Examen
	{
		public int Id { get; set; }
		public CicloLectivo CicloLectivo { get; set; }
		public Materia Materia { get; set; }
		public int Libro { get; set; }
		public int Tomo { get; set; }
		public int Acta { get; set; }
		public DateTime Fecha { get; set; }
		public string Turno { get; set; }
		public int Activo { get; set; }
		public ICollection<ExamenDocente> Tribunal { get; set; }
		public ICollection<ExamenAlumno> ExamenAlumno { get; set; }
    }
}

