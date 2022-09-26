using ProductsInformation.Domain;
using ProductsInformation.Domain.Interfaces.Repositories;
using ProductsInformation.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;

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
            try
            {
                entity.Id = Guid.NewGuid();
                _db.Product.Add(entity);
                return entity;
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("error creating product object" + ex);
            }
        }

        ///<summary>
        ///infrastructure layer that ultimately communicates with the database for listing products.
        ///</summary>
        public List<Product> ListAll(int pag, int reg)
        {
            try
            {
                return _db.Product.OrderBy(x => x.Id).Skip(pag).Take(reg).ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("error consulting products" + ex);
            }
        }

        ///<summary>
        ///infrastructure layer that finally communicates with the database to list product by id.
        ///</summary>
        public Product ListById(Guid entityId)
        {
            try
            {
                return _db.Product.Where(x => x.Id == entityId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("error when querying product" + ex);
            }
        }

        ///<summary>
        ///Saves new or modified information in database.
        ///</summary>
        public void SaveChanges()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("Error creating product" + ex);
            }
        }
    }
}
