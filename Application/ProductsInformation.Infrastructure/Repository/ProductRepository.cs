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

        ///<summary>
        ///The dependency for database consumption is injected.
        ///</summary>
        public ProductRepository(PersistenceContext db)
        {
            _db = db;
        }

        ///<summary>
        ///infrastructure layer that ultimately communicates with the database for the creation of products.
        ///</summary>
        public Product Add(Product entity)
        {
            entity.Id = Guid.NewGuid();
            _db.Product.Add(entity);
            return entity;
        }

        ///<summary>
        ///infrastructure layer that ultimately communicates with the database for listing products.
        ///</summary>
        public List<Product> ListAll()
        {
            return _db.Product.ToList();
        }

        ///<summary>
        ///infrastructure layer that finally communicates with the database to list product by id.
        ///</summary>
        public Product ListById(Guid entityId)
        {
            return _db.Product.Where(x => x.Id == entityId).FirstOrDefault();
        }

        ///<summary>
        ///Saves new or modified information in database.
        ///</summary>
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
