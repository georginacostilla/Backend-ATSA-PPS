using System;
namespace Backend_ATSA.Entities
{
	public class Regularidad
	{
		public int Id { get; set; }
		public Alumno Alumno { get; set; }
		public Cursada Origen { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FechaFin { get; set; }
    }
}

