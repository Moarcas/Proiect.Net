using Microsoft.EntityFrameworkCore;
using ProiectTest.Data;
using ProiectTest.Models;

namespace ProiectTest.CategoryRepositoryy
{
    public class CategoryRepository : GenericRepository.GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProiectTestContext context) : base(context)
        {       
        }

        public List<Category> GetAllWithJoin()
        {
            var result = _table.Join(_context.Products, category => category.Id, product => product.CategoryId,
                (category, product) => new {category, product}).ToList();

            return result.Select(x => x.category).Distinct().ToList();
        }

        public List<Category> GetCategoriesWithProducts()
        {
            return _table.Include(x => x.Products).ToList();    
        }
    }
}