using ProiectTest.Data;
using ProiectTest.Models;

namespace ProiectTest.Helper.Seeders
{
    public class ProductSeeder
    {
        public readonly ProiectTestContext _context;

        public ProductSeeder(ProiectTestContext context)
        {
            _context = context;
        }

        public void SeedInitialProducts()
        {
            if(!_context.Products.Any())
            {
                var product1 = new Product
                {
                    Name = "Product 1",
                    Description = "Description 1",
                    Price = 10,
                    Stock = 10,
                };
                var product2 = new Product
                {
                    Name = "Product 2",
                    Description = "Description 2",
                    Price = 20,
                    Stock = 20,
                };
                var product3 = new Product
                {
                    Name = "Product 3",
                    Description = "Description 3",
                    Price = 30,
                    Stock = 30,
                };

                _context.Products.Add(product1);
                _context.Products.Add(product2);
                _context.Products.Add(product3);

                _context.SaveChanges();
            }
        }
    }
}