using System;
using System.Collections.Generic;
using System.Text;
using ProductsInformation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductsInformation.Infrastructure.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //builder.ToTable("tbProducts");
            //builder.HasKey(x => x.id);

            //builder.HasOne(category => category.Category).WithMany
        }
    }
}
