using Bibliotech.Api.Domain.Enums;

namespace Bibliotech.Api.Domain.Entities;

public class Usuario : Entity
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; }
    public Status Status { get; private set; }
    public string Permissao { get; private set; }

    public void UpdateStatus(Status status)
    {
        Status = status;
    }

    public void UpdatePermissao(string permissao)
    {
        Permissao = permissao;
    }
}
