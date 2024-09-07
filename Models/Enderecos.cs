using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade.Models
{
    public enum UF
    {
        AC, AL, AM, AP, BA, CE, DF, ES, GO, MA, MG, MS, MT, PA, PB, PE, PI, PR, RJ, RN, RO, RR, RS, SC, SE, SP, TO
    }

    public class Enderecos
    {

        public int Id { get; set; }

        public string? Street { get; set; }

        public string? Number { get; set; }

        public string? City { get; set; }

        public UF UF { get; set; }

        public string? Country { get; set; } = "Brasil";

        public int PessoaId { get; set; }

        [ForeignKey("PessoaId")]
        public Pessoa? Pessoa { get; set; }
    }
}