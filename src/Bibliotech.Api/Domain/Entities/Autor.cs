using Bibliotech.Api.Domain.Enums;

namespace Bibliotech.Api.Domain.Entities;

public class Autor : Entity
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public Status Status { get; set; }
}
