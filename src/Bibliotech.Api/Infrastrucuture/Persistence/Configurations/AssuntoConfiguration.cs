using Bibliotech.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Bibliotech.Api.Infrastrucuture.Persistence.Configurations;

public class AssuntoConfiguration : IEntityTypeConfiguration<Assunto>
{
    public void Configure(EntityTypeBuilder<Assunto> builder)
    {
        builder.ToTable("assunto");
        builder.HasKey(e => e.Id);

        builder.Property(a => a.Id)
            .HasColumnName("Id")
            .HasColumnType("integer")
            .IsRequired()
            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

        builder.Property(e => e.Descricao)
            .IsRequired()
            .HasMaxLength(80);

        builder.Property(e => e.Status)
            .IsRequired()
        .HasConversion<int>();
    }
}
