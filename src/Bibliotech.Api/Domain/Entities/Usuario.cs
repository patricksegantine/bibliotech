namespace Bibliotech.Api.Domain.Entities;

public class Usuario
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; }
    public string Status { get; private set; }
    public string Permissao { get; private set; }

    public void UpdateStatus(string status)
    {
        Status = status;
    }

    public void UpdatePermissao(string permissao)
    {
        Permissao = permissao;
    }
}
