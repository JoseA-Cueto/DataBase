using System.ComponentModel.DataAnnotations;

namespace BEDatabaseFinalProject.Entities
{
    public class Hotel
    {
        [Key]
        public string NombreHotel { get; set; }
        public double Ingresos { get; set; }
        public string? Direccion { get; set; }
    }
}
