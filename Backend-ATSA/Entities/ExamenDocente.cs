using System;
namespace Backend_ATSA.Entities
{
    public class ExamenDocente
    {
        public int Id { get; set; }
        public Docente Docente { get; set; }
        public int ExamenId { get; set; }
    }
}

