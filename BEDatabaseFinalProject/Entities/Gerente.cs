using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEDatabaseFinalProject.Entities
{
    public class Gerente
    {
        [Key]
        public int ClaveGerente { get; set; }
        public string? CorreoGerente { get; set; }
        [ForeignKey(nameof(HotelNombreHotel))]
        public string? HotelNombreHotel { get; set; }
        public string? NumTelefono { get; set; }
    }
}
