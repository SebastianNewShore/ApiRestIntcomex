using ProductsInformation.Domain;
using ProductsInformation.Domain.Interfaces.Repositories;
using ProductsInformation.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProductsInformation.Infrastructure.Repository
{
    public class CategoryRepository : IAddBaseRepository<Category, Guid>
    {
        private PersistenceContext _db;

        ///<summary>
        ///The dependency for database consumption is injected.
        ///</summary>
        public CategoryRepository(PersistenceContext db)
        {
            _db = db;
        }

        ///<summary>
        ///infrastructure layer that ultimately communicates with the database for category creation.
        ///</summary>
        public Category Add(Category entity)
        {
            entity.Id = Guid.NewGuid();
            _db.Category.Add(entity);
            return entity;
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
