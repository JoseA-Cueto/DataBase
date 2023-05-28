using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace BEDatabaseFinalProject.Entities
{
    public class Reserva
    {
        [Key]
        public int HabitacionReservada { get; set; }
        public int NumHuesped { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        [ForeignKey(nameof(GerenteClaveGerente))]
        public int GerenteClaveGerente { get; set; }

    }
}
