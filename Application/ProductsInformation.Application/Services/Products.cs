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
        private readonly IListBaseRepository<Product, Guid> _ListProducRepo;
        private readonly IAddBaseRepository<Product, Guid> _AddProducRepo;

        public Products(IListBaseRepository<Product, Guid> listProducRepo, IAddBaseRepository<Product, Guid> addProducRepo)
        {
            _ListProducRepo = listProducRepo;
            _AddProducRepo = addProducRepo;
        }

        public Product Add(Product entity)
        {
            try
            {
                if (entity != null)
                {
                    var result = _AddProducRepo.Add(entity);
                    _AddProducRepo.SaveChanges();
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
                return _ListProducRepo.ListAll();
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
                return _ListProducRepo.ListById(entityId);
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("error bringing product: " + ex);
            }
        }
    }
}
