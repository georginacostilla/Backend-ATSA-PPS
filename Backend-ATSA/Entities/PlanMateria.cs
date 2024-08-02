using System;
namespace Backend_ATSA.Entities
{
	public class PlanMateria
	{
		public int Id { get; set; }
		public int Ano { get; set; }
		public Plan Plan { get; set; }
        public Materia Materia { get; set; }
    }
}

