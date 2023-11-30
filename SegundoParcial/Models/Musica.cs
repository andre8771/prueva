using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Musica
    {
        [Key]
        public int idMusica { get; set; }
        public string Titulo { get; set; }
        public bool Genero { get; set; }
        public int Numeroreproducciones { get; set; }
        public int idDisco { get; set; }

    }
}