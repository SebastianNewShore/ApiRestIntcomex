using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Config
{
    internal class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("tbOrderDetail");

            builder.Property(e => e.UnitPrice).HasColumnType("money");

            builder.HasOne(d => d.IdOrdersNavigation)
                .WithMany(p => p.OrderDetail)
                .HasForeignKey(d => d.IdOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbOrderDetails_tbOrders");

            builder.HasOne(d => d.IdProductsNavigation)
                .WithMany(p => p.OrderDetail)
                .HasForeignKey(d => d.IdProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbOrderDetails_tbProducts");
        }
    }
}
