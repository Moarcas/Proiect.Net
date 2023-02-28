using ProiectTest.Models;

namespace ProiectTest.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAll();

        // Delete category by id
        Task Delete(Guid id);

        // Create a new category
        Task<Category> CreateCategory(Category category);
    }
}