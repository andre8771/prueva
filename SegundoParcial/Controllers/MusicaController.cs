using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicaController : ControllerBase
    {
        private readonly ILogger<MusicaController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public MusicaController(
            ILogger<MusicaController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Add(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Musica> Get()
        {
            return _aplicacionContexto.Musica.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Update(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int musicaID)
        {
            _aplicacionContexto.Musica.Remove(
                _aplicacionContexto.Musica.ToList()
                .Where(x=>x.idMusica == musicaID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(musicaID);
        }
    }
}