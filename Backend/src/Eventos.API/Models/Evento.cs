namespace Eventos.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }     
        public string Local { get; set; } 
        public string DataEvento { get; set; } 
        public string TemaDoEvento { get; set; } 
        public int QtdMaxPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }
}