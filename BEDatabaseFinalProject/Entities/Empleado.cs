using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDatabaseFinalProject.Entities
{
    public class Empleado
    {
        [Key] 
        public int Id{ get; set; }
        public string? CorreoEmpleado{ get; set; }
        [ForeignKey(nameof(HotelNombreHotel))] 
        public string? HotelNombreHotel { get; set; }
        
    }
}
