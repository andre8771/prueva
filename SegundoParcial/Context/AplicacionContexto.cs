using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace VideoJuego.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }


        public DbSet<Musica> Musica { get; set; }
        public DbSet<Disco> Disco { get; set; }

    }
}
