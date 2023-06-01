using EventosAPI.Entities;

namespace EventosAPI.Data
{
    public class EventosDbContext
    {
        public List<Evento> Eventos { get; set; }

        public EventosDbContext()
        { 
        this.Eventos = new List<Evento>();
        }

    }
}
