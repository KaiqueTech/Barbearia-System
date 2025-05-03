
namespace Barbearia.DAL.Models
{
    public class ClienteModel
    {
        public int ClienteId {get; set;}
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public string Email {get; set;}
        public ICollection<AgendamentoModel> Agendamentos {get; set;}
    }
}