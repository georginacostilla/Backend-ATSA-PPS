using System;
namespace Backend_ATSA.Entities
{
	public class CicloLectivo
	{
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Eliminado { get; set; } = 0;
    }
}

