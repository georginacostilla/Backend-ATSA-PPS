using System;
namespace Backend_ATSA.Entities
{
	public class CursadaAlumno
	{
		public int Id { get; set; }
		public Alumno Alumno { get; set; }
		public int CursadaId { get; set; }
        public double? Parcial1 { get; set; }
		public double? Parcial2 { get; set; }
		public double? Parcial3 { get; set; }
		public double? Parcial4 { get; set; }
		public double? Rec1 { get; set; }
		public double? Rec2 { get; set; }
		public double? Rec3 { get; set; }
		public double? Rec4 { get; set; }
		public int? PromedioParciales { get; set; }
		public int? PorcentajeHoras { get; set; }
		public CondicionCursada CondicionAlumno { get; set; }
    }

	public enum CondicionCursada
	{
		Regular = 1,
		Promocionado = 2,
		Libre = 3
	}

}

