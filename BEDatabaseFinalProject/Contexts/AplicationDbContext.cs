using BEDatabaseFinalProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace BEDatabaseFinalProject.Contexts
{
    public class AplicationDbContext : DbContext

    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options  ) 
        {
            
        }


        public DbSet<Hotel>Hotels { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<EmpleadoReserva> EmpleadoReservas { get; set; }
        public DbSet<EmpleadoHabitacion> EmpleadoHabitacions { get; set; }
        public DbSet<ClienteNacional> ClienteNacionals{ get; set; }
        public DbSet<ClienteExtranjero> ClienteExtranjeros { get; set; }
      
        
       

    }
}
