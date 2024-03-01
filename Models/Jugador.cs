using System.ComponentModel.DataAnnotations;

namespace juego.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador {get; set;}
        public string? Nombre {get; set;}

    }
}

