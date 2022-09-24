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

        public CategoryRepository(PersistenceContext db)
        {
            _db = db;
        }

        public Category Add(Category entity)
        {
            entity.Id = Guid.NewGuid();
            _db.Category.Add(entity);
            return entity;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
