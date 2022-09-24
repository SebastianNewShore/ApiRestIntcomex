using ProductsInformation.Application.Interfaces;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Application.Services
{
    public class Categories : IAddBaseService<Category, Guid>
    {
        private readonly IAddBaseRepository<Category, Guid> _CategoryRepo;

        public Categories(IAddBaseRepository<Category, Guid> CategoryRepo)
        {
            _CategoryRepo = CategoryRepo;
        }

        public Category Add(Category entity)
        {
            try
            {
                if (entity != null)
                {
                    var result = _CategoryRepo.Add(entity);
                    _CategoryRepo.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("The Category is Required, error: " + ex);
            }
            return new Category();
        }
    }
}
