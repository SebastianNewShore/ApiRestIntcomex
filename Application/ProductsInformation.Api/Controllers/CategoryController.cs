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
    public class CategoryController : ControllerBase
    {
        ///<summary>
        ///Instance for consumption of services is created.
        ///</summary>
        Categories CreateService()
        {
            PersistenceContext db = new PersistenceContext();
            CategoryRepository repo = new CategoryRepository(db);
            Categories service = new Categories(repo);
            return service;
        }

        ///<summary>
        ///Post method creating the category.
        ///</summary>
        [HttpPost]
        public ActionResult Post([FromBody] Category category)
        {
            var service = CreateService();
            service.Add(category);
            return Ok(Constants.Constants.addedInformation);
        }
    }
}
