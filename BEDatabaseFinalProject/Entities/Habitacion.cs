using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDatabaseFinalProject.Entities
{
    public class Habitacion
    {
        [Key]
        public int NumHabitacion { get; set; }
        public int Capacidad { get; set; }
        public bool Disponible { get; set; }
        [ForeignKey(nameof(GerenteClaveGerente))]
        public int GerenteClaveGerente { get; set; }
    }
}
