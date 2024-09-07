namespace Atividade.Models
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly Birthday { get; set; }
        public List<Enderecos>? Enderecos { get; set; } 
        
    }
}
