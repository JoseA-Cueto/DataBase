using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDatabaseFinalProject.Entities
{
    public class EmpleadoReserva
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(IdEmpleado))]
        public int IdEmpleado { get; set; }
        [ForeignKey(nameof(ReservaHabitacionReservada))]
        public int ReservaHabitacionReservada { get; set; }
    }
}
