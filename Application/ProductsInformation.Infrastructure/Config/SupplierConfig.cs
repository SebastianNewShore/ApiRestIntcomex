using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Config
{
    internal class SupplierConfig : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("tbSupplier");

            builder.Property(e => e.adress)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.companyName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.contactName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.contactTitle)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.fax)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.homePage)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.phone)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.postalCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.IdCityNavigation)
                .WithMany(p => p.Supplier)
                .HasForeignKey(d => d.idCity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbSuppliers_tbCity");
        }
    }
}
