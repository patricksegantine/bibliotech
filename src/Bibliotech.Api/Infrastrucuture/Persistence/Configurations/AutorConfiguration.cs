﻿using Bibliotech.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bibliotech.Api.Infrastrucuture.Persistence.Configurations;

public class AutorConfiguration : IEntityTypeConfiguration<Autor>
{
    public void Configure(EntityTypeBuilder<Autor> builder)
    {
        builder.ToTable("autor");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Nome)
            .IsRequired()
            .HasMaxLength(80);

        builder.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(80);

        builder.Property(e => e.Status)
            .IsRequired()
        .HasConversion<int>();
    }
}
