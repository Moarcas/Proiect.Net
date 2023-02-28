using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectTest.Data;
using ProiectTest.Models;
using ProiectTest.Services.CategoryService;

namespace ProiectTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // async method
        [HttpGet]
        public async Task<ActionResult<List<CategoryDTO>>> GetAll()
        {
            var categories = await _categoryService.GetAll();

            return Ok(categories);
        }
        

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _categoryService.Delete(id);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            var newCategory = await _categoryService.CreateCategory(category);

            return Ok(newCategory);
        }
    } 
}