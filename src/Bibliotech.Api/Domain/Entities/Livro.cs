using Bibliotech.Api.Domain.Enums;

namespace Bibliotech.Api.Domain.Entities;

public class Livro : Entity
{
    public string Titulo { get; set; }
    public string ISBN { get; set; }
    public string Editora { get; set; }
    public int AnoPublicacao { get; set; }
    public int AssuntoId { get; set; }
    public int AutorId { get; set; }
    public Status Status { get; set; }


    // ORM EF: Propriedades de Navegação
    public Assunto Assunto { get; set; }
    public Autor Autor { get; set; }
}
