using System;
using Backend_ATSA.Entities;

namespace Backend_ATSA.DTOs
{
	public class CursadaDetalleDto
	{
        public int Id { get; set; }
        public int CicloLectivoId { get; set; }
        public string CicloLectivoNombre { get; set; }
        public int RegimenId { get; set; }
        public string RegimenNombre { get; set; }
        public int Activo { get; set; }
        public int MateriaId { get; set; }
        public string MateriaNombre { get; set; }
        public int DocenteId { get; set; }
        public string DocenteApellidos { get; set; }
        public string DocenteNombres { get; set; }
        public ICollection<CursadaAlumnoDetalleDto> CursadaAlumnos { get; set; }
    }
}

