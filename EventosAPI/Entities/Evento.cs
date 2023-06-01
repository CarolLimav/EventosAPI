namespace EventosAPI.Entities
{
    public class Evento
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Local { get; set; }
        public DateTime DataInicial  { get; set; }
        public DateTime DataFinal { get; set; }
        public string Descricao { get; set; }
        public List<Palestrante> Palestrantes { get; set;}
        
        public Evento()
        {
            this.Id = Guid.NewGuid(); //pré-definidos
            this.Palestrantes = new List<Palestrante>();
        }
    }
}
