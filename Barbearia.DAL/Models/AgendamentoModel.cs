
namespace Barbearia.DAL.Models
{
    public class AgendamentoModel
    {
        public int AgendamentoId {get; set;}
        public DateTime DataHora {get; set;}
        public int ClienteId {get; set;}
        public int FuncionarioId {get; set;}
        public FuncionarioModel Funcionario {get; set;}
        public ClienteModel Cliente {get; set;}
    }
}