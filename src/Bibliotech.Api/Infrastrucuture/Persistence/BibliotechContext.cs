using Bibliotech.Api.Domain.Entities;
using Bibliotech.Api.Infrastrucuture.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bibliotech.Api.Infrastrucuture.Persistence;

public class BibliotechContext : DbContext
{
    public DbSet<Assunto> Assuntos { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    public BibliotechContext(DbContextOptions<BibliotechContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .LogTo(Console.WriteLine)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AssuntoConfiguration());
        modelBuilder.ApplyConfiguration(new AutorConfiguration());
        modelBuilder.ApplyConfiguration(new LivroConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

        // Configurar todas as propriedades DateTime para serem UTC
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                if (property.ClrType == typeof(DateTime) || property.ClrType == typeof(DateTime?))
                {
                    property.SetValueConverter(new ValueConverter<DateTime, DateTime>(
                        v => v.ToUniversalTime(),
                        v => DateTime.SpecifyKind(v, DateTimeKind.Utc)));
                }
            }
        }
    }
}
