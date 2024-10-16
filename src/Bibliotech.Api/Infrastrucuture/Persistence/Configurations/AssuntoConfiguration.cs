using Bibliotech.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bibliotech.Api.Infrastrucuture.Persistence.Configurations;

public class AssuntoConfiguration : IEntityTypeConfiguration<Assunto>
{
    public void Configure(EntityTypeBuilder<Assunto> builder)
    {
        builder.ToTable("assunto");
        builder.HasKey(e => e.Id);

        builder.Property(a => a.Id)
            .HasColumnName("Id")
            .IsRequired();

        builder.Property(e => e.Descricao)
            .IsRequired()
            .HasMaxLength(80);

        builder.Property(e => e.Status)
            .IsRequired()
        .HasConversion<int>();
    }
}
