using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDatabaseFinalProject.Entities
{
    public class EmpleadoHabitacion
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(EmpleadoIdEmpleado))]
        public int EmpleadoIdEmpleado { get; set; }
        [ForeignKey(nameof(HabitacionNumHabitacion))]
        public int HabitacionNumHabitacion { get; set; }
    }
}
