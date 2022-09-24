using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Config
{
    internal class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("tbCountry");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
