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
    public class CategoryController : ControllerBase
    {
        Categories CreateService()
        {
            PersistenceContext db = new PersistenceContext();
            CategoryRepository repo = new CategoryRepository(db);
            Categories service = new Categories(repo);
            return service;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public ActionResult Post([FromBody] Category category)
        {
            var service = CreateService();
            service.Add(category);
            return Ok(Constants.Constants.addedInformation);
        }
    }
}
