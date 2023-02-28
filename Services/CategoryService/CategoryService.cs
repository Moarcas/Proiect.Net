using AutoMapper;
using ProiectTest.CategoryRepositoryy;
using ProiectTest.Models;

namespace ProiectTest.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Delete(Guid id)
        {
            var category = await _categoryRepository.FindByIdAsync(id);

            if(category == null)
            {
                throw new Exception("Category not found");
            }

            await _categoryRepository.DeleteAsync(category);

            await _categoryRepository.SaveAsync();
        }

        public async Task<List<CategoryDTO>> GetAll()
        {
            var categories = await _categoryRepository.GetAll();

            return _mapper.Map<List<CategoryDTO>>(categories);
        }

        // Create a new category 
        public async Task<Category> CreateCategory(Category category)
        {
            await _categoryRepository.CreateAsync(category);
            await _categoryRepository.SaveAsync();

            return category;
        }

    }
}
