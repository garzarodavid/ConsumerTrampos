using ConsumerTrampos.Domain.Common;

namespace ConsumerTrampos.Domain.Consumers;

public class Consumer : Entity
{
    public string CompanyName { get; private set; }
    public CompanySize CompanySize { get; private set; }

    // Construtor privado para garantir que a entidade seja criada com os dados necessários
    private Consumer() { }

    public Consumer(string companyName, CompanySize companySize)
    {
        CompanyName = companyName;
        CompanySize = companySize;
    }

    // Método para atualizar os dados do Consumer
    public void Update(string companyName, CompanySize companySize)
    {
        CompanyName = companyName;
        CompanySize = companySize;
    }
}

public enum CompanySize
{
    Small,
    Medium,
    Large
}