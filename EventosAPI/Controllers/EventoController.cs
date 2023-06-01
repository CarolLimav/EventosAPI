using EventosAPI.Data;
using EventosAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly EventosDbContext _context; 

        public EventoController(EventosDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public IActionResult Get() {
        }
        [HttpPost]
        public IActionResult Post(Evento evento) {
        }
        [HttpGet("{id}")] //qro por id
        public IActionResult GetById(int id) { 
        }
        [HttpPut("{id}")]
        public IActionResult Update(Evento evento, int id)
        {
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) { }
    }
}
