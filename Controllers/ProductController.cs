using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectTest.Data;
using ProiectTest.Models;
using ProiectTest.Models.DTOs;
using ProiectTest.Services.ProductService;

namespace ProiectTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> GetAll()
        {
            var products = await _productService.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById(Guid id)
        {
            try
            {
                var product = await _productService.GetById(id);

                if(product == null)
                {
                    return NotFound();
                }

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("name/{name}")]
        public ActionResult<ProductDTO> GetProductByName(string name)
        {
            try
            {
                  var product = _productService.GetByName(name);
    
                    if (product == null)
                    {
                        return NotFound();
                    }
    
                    return Ok(product);   
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _productService.Delete(id);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(Product product)
        {
            var newProduct = await _productService.CreateProduct(product);

            return Ok(newProduct);
        }

        [HttpPut("{id}")]
        public void UpdateProduct(Guid id, Product product)
        {
            _productService.UpdateProduct(id, product);
        }
    }
}