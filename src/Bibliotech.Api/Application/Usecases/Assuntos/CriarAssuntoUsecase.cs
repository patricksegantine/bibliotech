using Bibliotech.Api.Domain.Entities;
using Bibliotech.Api.Infrastrucuture.Persistence;

namespace Bibliotech.Api.Application.Usecases.Assuntos;

public record CriarAssuntoDto
{
    public string Descricao { get; set; }
}

public class CriarAssuntoUsecase
{
    private readonly BibliotechContext _bibliotechContext;

    public CriarAssuntoUsecase(BibliotechContext bibliotechContext)
    {
        _bibliotechContext = bibliotechContext;
    }

    public Assunto Handle(CriarAssuntoDto dto)
    {
        if (string.IsNullOrEmpty(dto.Descricao))
        {
            throw new ArgumentNullException(nameof(dto.Descricao));
        }

        // criar um objeto assunto
        var assunto = new Assunto()
        {
            Descricao = dto.Descricao,
            Status = Domain.Enums.Status.Ativo,
        };

        // inserir no banco de dados
        _bibliotechContext.Assuntos.Add(assunto);
        _bibliotechContext.SaveChanges();

        return assunto;
    }
}
