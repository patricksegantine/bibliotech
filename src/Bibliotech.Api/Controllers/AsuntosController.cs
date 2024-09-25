using Microsoft.AspNetCore.Mvc;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/assuntos")]
public class AsuntosController : ControllerBase
{
    [HttpGet("buscar")]
    public IActionResult Buscar(string nomeAutor)
    {
        // TODO: acessar o banco de dados e pesquisar

        

        return Ok();
    }
}
