using Microsoft.EntityFrameworkCore;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Entities;
using ProductsInformation.Infrastructure.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Infrastructure.Context
{
    ///<summary>
    ///Class mapping the database and its structure.
    ///</summary>
    public partial class PersistenceContext: DbContext
    {
        public PersistenceContext()
        {

        }

        public PersistenceContext(DbContextOptions<PersistenceContext> options)
            :base(options)
        {

        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }

        ///<summary>
        ///Database connection is configured
        ///</summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=pruebasebasql.database.windows.net; Database=INTCOMEX;User Id=adminSql;Password=Luciana1227");
                //optionsBuilder.UseSqlServer("Server=PC-SCASTANO; Database=INTCOMEX; Trusted_Connection=True;");
            }
        }

        ///<summary>
        ///information is obtained for each of the entities, with their respective structure
        ///</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new OrderDetailConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new RegionConfig());
            modelBuilder.ApplyConfiguration(new ShipperConfig());
            modelBuilder.ApplyConfiguration(new SupplierConfig());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
