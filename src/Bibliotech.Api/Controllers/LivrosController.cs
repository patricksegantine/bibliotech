using Bibliotech.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/livros")]
public class LivrosController : ControllerBase
{
    [HttpGet("buscar")]
    public IActionResult Buscar(string titulo)
    {
        // TODO: acessar o banco de dados e pesquisar

        var livros = MockLivros();


        return Ok(livros);
    }

    private List<Livro> MockLivros()
    {
        var autores = new List<Autor>
        {
            new Autor { Id = 1, Nome = "Delia Owens", Email = "delia@owens.com", DataNascimento = new DateTime(1949, 4, 4), Status = Domain.Enums.Status.Ativo },
            new Autor { Id = 2, Nome = "Colleen Hoover", Email = "colleen@hoover.com", DataNascimento = new DateTime(1979, 12, 11), Status = Domain.Enums.Status.Ativo },
            new Autor { Id = 3, Nome = "Michelle Obama", Email = "michelle@obama.com", DataNascimento = new DateTime(1964, 1, 17), Status = Domain.Enums.Status.Ativo },
            new Autor { Id = 4, Nome = "James Clear", Email = "james@clear.com", DataNascimento = new DateTime(1986, 5, 22), Status = Domain.Enums.Status.Ativo },
            new Autor { Id = 5, Nome = "Taylor Jenkins Reid", Email = "taylor@jenkins.com", DataNascimento = new DateTime(1983, 12, 20), Status = Domain.Enums.Status.Ativo },
        };

        var assuntos = new List<Assunto>
        {
            new Assunto { Id = 1, Descricao = "Ficção", Status = Domain.Enums.Status.Ativo },
            new Assunto { Id = 2, Descricao = "Biografia", Status = Domain.Enums.Status.Ativo },
            new Assunto { Id = 3, Descricao = "Autoajuda", Status = Domain.Enums.Status.Ativo },
            new Assunto { Id = 4, Descricao = "Romance", Status = Domain.Enums.Status.Ativo },
            new Assunto { Id = 5, Descricao = "História", Status = Domain.Enums.Status.Ativo },
        };

        var livros = new List<Livro>
        {
            new Livro { Id = 1, Titulo = "Onde Cantam os Pássaros", ISBN = "978-1234567890", Editora = "Intrínseca", AnoPublicacao = 2018, AutorId = 1, AssuntoId = 1, Autor = autores[0], Assunto = assuntos[0] },
            new Livro { Id = 2, Titulo = "Verity", ISBN = "978-1234567891", Editora = "Galera", AnoPublicacao = 2021, AutorId = 2, AssuntoId = 4, Autor = autores[1], Assunto = assuntos[3] },
            new Livro { Id = 3, Titulo = "Minha História", ISBN = "978-1234567892", Editora = "Objetiva", AnoPublicacao = 2018, AutorId = 3, AssuntoId = 2, Autor = autores[2], Assunto = assuntos[1] },
            new Livro { Id = 4, Titulo = "Hábitos Atômicos", ISBN = "978-1234567893", Editora = "Alta Books", AnoPublicacao = 2018, AutorId = 4, AssuntoId = 3, Autor = autores[3], Assunto = assuntos[2] },
            new Livro { Id = 5, Titulo = "Malibu Renasce", ISBN = "978-1234567894", Editora = "Paralela", AnoPublicacao = 2021, AutorId = 5, AssuntoId = 1, Autor = autores[4], Assunto = assuntos[0] },
            new Livro { Id = 6, Titulo = "O Homem Mais Rico da Babilônia", ISBN = "978-1234567895", Editora = "HarperCollins", AnoPublicacao = 2017, AutorId = 3, AssuntoId = 3, Autor = autores[2], Assunto = assuntos[2] },
            new Livro { Id = 7, Titulo = "A Casa no Lago", ISBN = "978-1234567896", Editora = "HarperCollins", AnoPublicacao = 2020, AutorId = 2, AssuntoId = 1, Autor = autores[1], Assunto = assuntos[0] },
            new Livro { Id = 8, Titulo = "A Vida Invisível de Addie LaRue", ISBN = "978-1234567897", Editora = "Galera", AnoPublicacao = 2020, AutorId = 5, AssuntoId = 1, Autor = autores[4], Assunto = assuntos[0] },
            new Livro { Id = 9, Titulo = "Pequeno Manual Antirracista", ISBN = "978-1234567898", Editora = "Companhia das Letras", AnoPublicacao = 2019, AutorId = 1, AssuntoId = 5, Autor = autores[0], Assunto = assuntos[4] },
            new Livro { Id = 10, Titulo = "A Sutil Arte de Ligar o F*da-se", ISBN = "978-1234567899", Editora = "Intrínseca", AnoPublicacao = 2017, AutorId = 3, AssuntoId = 3, Autor = autores[2], Assunto = assuntos[2] },
        };

        return livros;
    }
}