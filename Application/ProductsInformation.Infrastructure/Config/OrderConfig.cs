using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Config
{
    internal class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("tbOrder");

            builder.Property(e => e.OrderDate).HasColumnType("date");

            builder.Property(e => e.ShipAdress)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.ShipName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ShipPostalCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.ShipVia)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ShippedDate).HasColumnType("date");

            builder.HasOne(d => d.IdCityNavigation)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.IdCity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbOrders_tbCity");

            builder.HasOne(d => d.IdCustomersNavigation)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.IdCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbOrders_tbCustomers");

            builder.HasOne(d => d.IdEmployeesNavigation)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.IdEmployees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbOrders_tbEmployees");

            builder.HasOne(d => d.IdShippersNavigation)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.IdShippers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbOrders_tbShippers");
        }
    }
}
