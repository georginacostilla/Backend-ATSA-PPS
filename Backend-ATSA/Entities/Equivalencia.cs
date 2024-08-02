using System;
namespace Backend_ATSA.Entities
{
	public class Equivalencia
	{
        public int Id { get; set; }
        public Materia Materia { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public int Eliminado { get; set; }
    }
}

