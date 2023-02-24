using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectTest.Data;
using ProiectTest.Models;

namespace ProiectTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ProiectTestContext _context;

        public CategoryController(ProiectTestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await _context.Categories.ToListAsync());
        }

        [HttpGet("CategoryById/{id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] Guid id)
        {
            var categoryById = _context.Categories.FirstOrDefaultAsync(category => category.Id == id);

            return Ok(categoryById);
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> Create(CategoryDTO categoryDTO)
        {
            var newCategory = new Category
            {
                Name = categoryDTO.Name
            };
            await _context.Categories.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return Ok(newCategory);
        }
    } 
}