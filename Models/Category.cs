using ProiectTest.Models.Base;

namespace ProiectTest.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        // I want default value for this property
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
} 