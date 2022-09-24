using ProductsInformation.Domain;
using ProductsInformation.Domain.Interfaces.Repositories;
using ProductsInformation.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsInformation.Infrastructure.Repository
{
    public class ProductRepository : IListBaseRepository<Product, Guid>, IAddBaseRepository<Product, Guid>
    {
        private PersistenceContext _db;

        public ProductRepository(PersistenceContext db)
        {
            _db = db;
        }

        public Product Add(Product entity)
        {
            entity.Id = Guid.NewGuid();
            _db.Product.Add(entity);
            return entity;
        }

        public List<Product> ListAll()
        {
            return _db.Product.ToList();
        }

        public Product ListById(Guid entityId)
        {
            return _db.Product.Where(x => x.Id == entityId).FirstOrDefault();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
