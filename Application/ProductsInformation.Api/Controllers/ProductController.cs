using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsInformation.Domain;
using ProductsInformation.Application.Services;
using ProductsInformation.Infrastructure.Context;
using ProductsInformation.Infrastructure.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsInformation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        Products CreateService()
        {
            PersistenceContext db = new PersistenceContext();
            ProductRepository repo = new ProductRepository(db);
            Products service = new Products(repo,repo);
            return service;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var response = CreateService().ListAll();
            if(response.Count > 0)
                return Ok(response);
            else
                return Ok(Constants.Constants.existInformation);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(Guid id)
        {
            var response = CreateService().ListById(id);
            if (response != null)
                return Ok(response);
            else
                return Ok(Constants.Constants.notFound);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            var service = CreateService();
            service.Add(product);
            return Ok(Constants.Constants.addedInformation);
        }
    }
}
