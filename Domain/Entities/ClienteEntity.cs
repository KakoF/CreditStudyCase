
namespace Domain.Entities
{
    public class ClienteEntity : BaseEntity
    {
        public ClienteEntity(long id, string cpf, string nome, string uf, string celular) : base(id)
        {
            Cpf = cpf;
            Nome = nome;
            UF = uf;
            Celular = celular;
        }

        public ClienteEntity(string cpf, string nome, string uF, string celular)
        {
            Cpf = cpf;
            Nome = nome;
            UF = uF;
            Celular = celular;
        }

        public string Cpf { get; }
        public string Nome { get; }
        public string UF { get; }
        public string Celular { get; }
    }
}
