using ProiectTest.Data;
using ProiectTest.Models;

namespace ProiectTest.Helper.Seeders
{
    public class CategorySeeder
    {
        public readonly ProiectTestContext _context;
        public CategorySeeder(ProiectTestContext context)
        {
            _context = context;
        }

        public void SeedInitialCategories()
        {
            if(!_context.Categories.Any())
            {
                var category1 = new Category
                {
                    Name = "Category 1"
                };
                var category2 = new Category
                {
                    Name = "Category 2"
                };
                var category3 = new Category
                {
                    Name = "Category 3"
                };

                _context.Categories.Add(category1);
                _context.Categories.Add(category2);
                _context.Categories.Add(category3);

                _context.SaveChanges();
            }
        }
    }                   
}
