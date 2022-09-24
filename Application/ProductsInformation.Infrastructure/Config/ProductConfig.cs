using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Config
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("tbProduct");

            builder.Property(e => e.productName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.unitPrice).HasColumnType("money");

            builder.HasOne(d => d.IdCategoryNavigation)
                .WithMany(p => p.Product)
                .HasForeignKey(d => d.idCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbProducts_tbCategories");

            builder.HasOne(d => d.IdSuppliersNavigation)
                .WithMany(p => p.Product)
                .HasForeignKey(d => d.idSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbProducts_tbSuppliers");
        }
    }
}
