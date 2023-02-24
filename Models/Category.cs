using ProiectTest.Models.Base;

namespace ProiectTest.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        // category has many products
        public ICollection<Product> Products { get; set; }
    }
} 