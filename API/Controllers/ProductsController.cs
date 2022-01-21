using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext db;

        public ProductsController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = db.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            
            return db.Products.Find(id);
        }
    }
}