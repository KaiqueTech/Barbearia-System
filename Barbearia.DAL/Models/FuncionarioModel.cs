
namespace Barbearia.DAL.Models
{
    public class FuncionarioModel
    {
        public int FuncionarioId {get; set;}
        public string Nome {get; set;}
        public string Cargo {get; set;}
        public bool Ativo {get; set;} = true;
        public int BarbeariaId {get; set;}
        public BarbeariaModel Barbearia {get; set;}
        public ICollection<AgendamentoModel> Agendamentos {get; set;}

    }
}