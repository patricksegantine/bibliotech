using Bibliotech.Api.Domain.Entities;
using Bibliotech.Api.Domain.Enums;
using Bibliotech.Api.Infrastrucuture.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Bibliotech.Api.Application.Usecases.Assuntos;

public record BuscarAssuntoDto
{
    public string? Descricao { get; set; }
    public Status? Status { get; set; }
}

public class BuscarAssuntoUsecase
{
    private readonly BibliotechContext _bibliotechContext;

    public BuscarAssuntoUsecase(BibliotechContext bibliotechContext)
    {
        _bibliotechContext = bibliotechContext;
    }

    public List<Assunto> Handle(BuscarAssuntoDto filtro)
    {
        var query = _bibliotechContext.Assuntos.AsQueryable();

        if (!string.IsNullOrWhiteSpace(filtro.Descricao))
        {
            query = query.Where(a => EF.Functions.ILike(a.Descricao, $"%{filtro}%"));
        }

        if (filtro.Status.HasValue)
        {
            query = query.Where(a => a.Status == filtro.Status.Value);
        }

        var resultado = query.ToList();

        return resultado;
    }
}
