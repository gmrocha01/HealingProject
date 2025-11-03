using System;

namespace Healing.Models
{
    public class TerapiaConsulta
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DataConsulta { get; set; }
        public string TipoTerapia { get; set; }
        public string Observacoes { get; set; }
        public string Status { get; set; }
        public string PessoaNome { get; set; }
        public string PessoaTelefone { get; set; }
        public string PessoaIdade { get; set; }
        public string PessoaCpfCnpj { get; set; }
    }
}
