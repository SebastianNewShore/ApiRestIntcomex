using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsInformation.Domain;
using ProductsInformation.Application.Services;
using ProductsInformation.Infrastructure.Context;
using ProductsInformation.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsInformation.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [RequireHttps]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ///<summary>
        ///Instance for consumption of services is created.
        ///</summary>
        Products CreateService()
        {
            PersistenceContext db = new PersistenceContext();
            ProductRepository repo = new ProductRepository(db);
            Products service = new Products(repo,repo);
            return service;
        }

        ///<summary>
        ///GET() method that fetches all the existing products.
        ///</summary>
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var response = CreateService().ListAll();
            if(response.Count > 0)
                return Ok(response);
            else
                return Ok(Constants.Constants.existInformation);
        }

        ///<summary>
        ///GET() method querying a product by Id.
        ///</summary>
        [HttpGet("{id}")]
        public ActionResult<Product> Get(Guid id)
        {
            var response = CreateService().ListById(id);
            if (response != null)
                return Ok(response);
            else
                return Ok(Constants.Constants.notFound);
        }

        ///<summary>
        ///POST method creating the Product.
        ///</summary>
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            var service = CreateService();
            service.Add(product);
            return Ok(Constants.Constants.addedInformation);
        }
    }
}
