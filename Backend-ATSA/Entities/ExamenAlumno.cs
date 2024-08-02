using System;
namespace Backend_ATSA.Entities
{
	public class ExamenAlumno
	{
		public int Id { get; set; }
		public Alumno Alumno { get; set; }
		public int ExamenId { get; set; }
        public string Permiso { get; set; }
		public int Nota { get; set; }
		public CondicionExamen Condicion { get; set; }
    }

    public enum CondicionExamen
    {
        Ausente = 1,
        Aprobado = 2,
        Desaprobado = 3
    }

}

