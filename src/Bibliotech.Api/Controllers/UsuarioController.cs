using Bibliotech.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/usuarios")]
public class UsuarioController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var usuario1 = new Usuario()
        {
            Nome = "Patrick Segantine",
            Cpf = "00011122233",
            DataNascimento = new DateTime(1984, 11, 8),
            Email = "patrick@email.com",
            //Status = "Active",
            //Permissao = "Admin"
        };
        
        //usuario1.UpdateStatus("ativo");
        //usuario1.UpdatePermissao("admin");

        return Ok(usuario1);
    }
}
