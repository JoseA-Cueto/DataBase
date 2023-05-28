using System.ComponentModel.DataAnnotations;

namespace BEDatabaseFinalProject.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Pais { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Usario { get; set; }
        public string? Contraseña { get; set; }
    }
}