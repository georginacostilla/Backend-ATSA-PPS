using System;
namespace Backend_ATSA.Entities
{
	public class Correlatividad
	{
		public int Id { get; set; }
		public int MateriaId { get; set; }
		public int Rendir { get; set; }
        public Materia Materia { get; set; }
		public int? MateriaRegularId { get; set; }
        public Materia MateriaRegular { get; set; }
		public int? MateriaAprobadaId { get; set; }
        public Materia MateriaAprobada { get; set; }
    }
}

