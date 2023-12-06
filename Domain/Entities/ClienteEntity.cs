
namespace Domain.Entities
{
    public class ClienteEntity : BaseEntity
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public string Celular { get; set; }
    }
}
