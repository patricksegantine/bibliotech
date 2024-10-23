using Bibliotech.Api.Application.Usecases.Assuntos;
using Bibliotech.Api.Domain.Enums;
using Bibliotech.Api.Infrastrucuture.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/assuntos")]
public class AsuntosController : ControllerBase
{
    //private readonly BibliotechContext _bibliotechContext;
    private readonly BuscarAssuntoUsecase _buscarUsecase;
    private readonly CriarAssuntoUsecase _criarUsecase;

    public AsuntosController(
        //BibliotechContext bibliotechContext
        BuscarAssuntoUsecase buscarUsecase,
        CriarAssuntoUsecase criarUsecase)
    {
        //_bibliotechContext = bibliotechContext;
        _buscarUsecase = buscarUsecase;
        _criarUsecase = criarUsecase;
    }

    [HttpGet("buscar")]
    public async Task<IActionResult> Buscar([FromQuery] string? descricao, [FromQuery] Status? status)
    {
        //var assuntos = await _bibliotechContext.Assuntos.ToListAsync();

        var filtro = new BuscarAssuntoDto
        {
            Descricao = descricao,
            Status = status
        };

        var assuntos = _buscarUsecase.Handle(filtro);

        return Ok(assuntos);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CriarAssuntoDto dto)
    {
        var assunto = _criarUsecase.Handle(dto);

        return Ok(assunto);
    }

    // TODO: tarefa para a proxima aula
    //[HttpPut("{id}")]
    //public async Task<IActionResult> Update([FromRoute] int id, [FromBody] AtualizarAssuntoDto dto)
    //{
    //    var assunto = _atualizarUsecase.Handle(dto);

    //    return Ok(assunto);
    //}
}
