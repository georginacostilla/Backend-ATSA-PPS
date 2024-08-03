using System;
namespace Backend_ATSA.DTOs
{
	public class CursadaAlumnoDetalleDto
	{
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public int Legajo { get; set; }
        public int Dni { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
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
        public int CondicionAlumnoId { get; set; }
        public string CondicionAlumnoNombre { get; set; }
    }
}

