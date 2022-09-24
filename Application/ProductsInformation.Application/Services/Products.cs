using System;
using System.Collections.Generic;
using System.Text;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Interfaces.Repositories;
using ProductsInformation.Application.Interfaces;

namespace ProductsInformation.Application.Services
{
    public class Products : IListBaseService<Product, Guid>, IAddBaseService<Product, Guid>
    {
        private readonly IBaseRepository<Product, Guid> _ProducRepo;

        public Products(IBaseRepository<Product, Guid> ProducRepo)
        {
            _ProducRepo = ProducRepo;
        }

        public Product Add(Product entity)
        {
            try
            {
                if (entity != null)
                {
                    var result = _ProducRepo.Add(entity);
                    _ProducRepo.SaveChanges();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw new ArgumentNullException("The product is Required, error: " + ex);
            }
            return new Product();
        }

        public List<Product> ListAll()
        {
            try
            {
                return _ProducRepo.ListAll();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("error bringing list of products: " + ex);
            }
        }
        
        public Product ListById(Guid entityId)
        {
            try
            {
                return _ProducRepo.ListById(entityId);
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("error bringing product: " + ex);
            }
        }
    }
}
