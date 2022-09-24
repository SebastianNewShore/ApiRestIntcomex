using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsInformation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Configs
{
    class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("tbCategories");
            //builder.HasKey(x => x.id);
        }
    }
}
