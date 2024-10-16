using Bibliotech.Api.Infrastrucuture.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/assuntos")]
public class AsuntosController : ControllerBase
{
    private readonly BibliotechContext _bibliotechContext;

    public AsuntosController(BibliotechContext bibliotechContext)
    {
        _bibliotechContext = bibliotechContext;
    }

    [HttpGet("buscar")]
    public async Task<IActionResult> Buscar([FromQuery] string descricao)
    {
        var assuntos = await _bibliotechContext.Assuntos.ToListAsync();

        return Ok(assuntos);
    }
}
