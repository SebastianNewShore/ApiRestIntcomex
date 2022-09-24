using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsInformation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Config
{
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("tbCategory");

            builder.Property(e => e.categoryname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(e => e.description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(e => e.picture)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            
        }
    }
}
