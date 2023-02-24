using ProiectTest.GenericRepository;
using ProiectTest.Models;

namespace ProiectTest.CategoryRepository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetCategoriesWithProducts();
        List<Category> GetAllWithJoin();
    }
}