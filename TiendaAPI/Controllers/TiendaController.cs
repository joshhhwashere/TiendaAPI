using Microsoft.AspNetCore.Mvc;
using TiendaAPI.DATA;
using TiendaAPI.MODELS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TiendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaController : ControllerBase
    {
        private readonly APIDbContext dbContext;

        public TiendaController(APIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<TiendaController>
        [HttpGet]
        public IEnumerable<Películas> Get()
        {
            return dbContext.Películas;
        }

        // GET api/<TiendaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Películas peli = dbContext.Películas.Find(id);
            return Ok(peli);
        }

        // POST api/<TiendaController>
        //nuevo
        [HttpPost]
        public IActionResult Post([FromBody] Películas value)
        {
            var peli = new Películas
            {
                Nombre = value.Nombre,
                Género = value.Género,
                Director = value.Director,
                Duración = value.Duración,
                Precio = value.Precio
            };
            dbContext.Películas.Add(peli);
            dbContext.SaveChanges();
            return Ok("La película se agregó satisfactoriamente");
        }

        // PUT api/<TiendaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Películas updatePeli)
        {
            var existingPeli = dbContext.Películas.Find(id);
            existingPeli.Nombre = updatePeli.Nombre;
            existingPeli.Duración = updatePeli.Duración;
            existingPeli.Director = updatePeli.Director;
            existingPeli.Precio = updatePeli.Precio;
            existingPeli.Género = updatePeli.Género;
            dbContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<TiendaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var peliToDelete = dbContext.Películas.Find(id);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
