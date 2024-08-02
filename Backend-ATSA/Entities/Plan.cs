using System;
namespace Backend_ATSA.Entities
{
	public class Plan
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
        public ICollection<PlanMateria> PlanMaterias { get; set; }
        public int Eliminado { get; set; } = 0;
    }
}

