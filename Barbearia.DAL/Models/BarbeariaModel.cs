
namespace Barbearia.DAL.Models
{
    public class BarbeariaModel
    {
        public int BarbeariaId {get; set;}
        public string Nome {get; set;}
        public string Endereco {get; set;}
        public string Telefone {get; set;}
        public ICollection<FuncionarioModel> Funcionarios {get; set;}
    }
}