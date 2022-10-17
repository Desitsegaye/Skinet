using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entitis;
using Infrastracture.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
[Route("api/[controller]")]
// [Route("api/controller")]
    public class ProductsController : ControllerBase
    {
        private readonly StorContext _context;
        public ProductsController(StorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return products;

            //return "this will be a list of Product";
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Product>> GetProduct(int id )
        {
           return  await _context.Products.FindAsync(id);
        }

    }
}