using Microsoft.EntityFrameworkCore;

namespace juego.Models

{
    public class JuegoContext : DbContext
    {

        public JuegoContext(DbContextOptions<JuegoContext> options) : base(options)
        {

        }

        public DbSet<Jugador> Jugador {get;set;}
    }

}