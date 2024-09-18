using Microsoft.AspNetCore.Mvc;
using Bibliotech.Api.Domain.Entities;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/autores")]
public class AutoresController : ControllerBase
{
    private List<Autor> autores;

    // Construtor da classe 
    public AutoresController()
    {
        autores = GerarAutoresMockados();
    }

    [HttpGet("buscar")]
    public IActionResult Buscar(string nomeAutor)
    {
        // TODO: acessar o banco de dados e pesquisar pelo autor

        var result = autores.Where(a => a.Nome.Contains(nomeAutor, StringComparison.OrdinalIgnoreCase)).ToList();

        return Ok(result);
    }

    private List<Autor> GerarAutoresMockados()
    {
        return new List<Autor>
        {
            new Autor { Nome = "Milton Hatoum", Email = "milton@literatura.com", DataNascimento = new DateTime(1952, 8, 19), Status = "Vivo" },
            new Autor { Nome = "Chico Buarque", Email = "chico@literatura.com", DataNascimento = new DateTime(1944, 6, 19), Status = "Vivo" },
            new Autor { Nome = "Cristovão Tezza", Email = "cristovao@literatura.com", DataNascimento = new DateTime(1952, 8, 21), Status = "Vivo" },
            new Autor { Nome = "Adriana Lisboa", Email = "adriana@literatura.com", DataNascimento = new DateTime(1970, 4, 25), Status = "Viva" },
            new Autor { Nome = "Bernardo Carvalho", Email = "bernardo@literatura.com", DataNascimento = new DateTime(1960, 10, 29), Status = "Vivo" },
            new Autor { Nome = "Paulo Lins", Email = "paulo@literatura.com", DataNascimento = new DateTime(1958, 6, 11), Status = "Vivo" },
            new Autor { Nome = "Marçal Aquino", Email = "marcal@literatura.com", DataNascimento = new DateTime(1958, 3, 1), Status = "Vivo" },
            new Autor { Nome = "Daniel Galera", Email = "daniel@literatura.com", DataNascimento = new DateTime(1979, 7, 13), Status = "Vivo" },
            new Autor { Nome = "Michel Laub", Email = "michel@literatura.com", DataNascimento = new DateTime(1973, 5, 26), Status = "Vivo" },
            new Autor { Nome = "Tatiana Salem Levy", Email = "tatiana@literatura.com", DataNascimento = new DateTime(1979, 1, 24), Status = "Viva" },
            new Autor { Nome = "Joca Reiners Terron", Email = "joca@literatura.com", DataNascimento = new DateTime(1968, 2, 8), Status = "Vivo" },
            new Autor { Nome = "Ana Paula Maia", Email = "ana@literatura.com", DataNascimento = new DateTime(1977, 10, 15), Status = "Viva" },
            new Autor { Nome = "Luiz Ruffato", Email = "luiz@literatura.com", DataNascimento = new DateTime(1961, 2, 4), Status = "Vivo" },
            new Autor { Nome = "João Paulo Cuenca", Email = "joao@literatura.com", DataNascimento = new DateTime(1978, 6, 26), Status = "Vivo" },
            new Autor { Nome = "Carola Saavedra", Email = "carola@literatura.com", DataNascimento = new DateTime(1973, 10, 20), Status = "Viva" },
            new Autor { Nome = "Vanessa Barbara", Email = "vanessa@literatura.com", DataNascimento = new DateTime(1982, 6, 14), Status = "Viva" },
            new Autor { Nome = "Julián Fuks", Email = "julian@literatura.com", DataNascimento = new DateTime(1981, 12, 23), Status = "Vivo" },
            new Autor { Nome = "Marcelino Freire", Email = "marcelino@literatura.com", DataNascimento = new DateTime(1967, 3, 20), Status = "Vivo" },
            new Autor { Nome = "Elvira Vigna", Email = "elvira@literatura.com", DataNascimento = new DateTime(1947, 9, 29), Status = "Falecida" },
            new Autor { Nome = "Patrícia Melo", Email = "patricia@literatura.com", DataNascimento = new DateTime(1962, 10, 2), Status = "Viva" }
        };
    }
}
