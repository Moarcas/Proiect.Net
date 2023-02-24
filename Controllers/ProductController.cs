using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectTest.Data;
using ProiectTest.Models;
using ProiectTest.Models.DTOs;

namespace ProiectTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProiectTestContext _context;

        public ProductController(ProiectTestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("ProductById/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] Guid id)
        {
            // Varianta 1
            // var productById = from product in _context.Products
            //                   where product.Id == id
            //                   select product;

            // Varianta 2
            var productById = _context.Products.FirstOrDefaultAsync(product => product.Id == id);

            return Ok(productById);
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> Create(ProductDTO productDTO)
        {
            var newProduct = new Product
            {
                Name = productDTO.Name,
                Price = productDTO.Price,
                CategoryId = productDTO.CategoryId
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
            return Ok(newProduct);
        } 
    }
}