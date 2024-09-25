namespace Bibliotech.Api.Domain.Entities;

public class Autor : Entity
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Status { get; set; }
}
