using ProiectTest.Models.Base;

namespace ProiectTest.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        // Get all data
        Task<List<TEntity>> GetAll();
        IQueryable<TEntity> GetAllAsQueryable();   

        // Create
        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        // Update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        // Delete
        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);

        // Find
        TEntity FindById(Guid id);
        Task<TEntity> FindByIdAsync(Guid id);

        // Save
        void Save();
        Task<bool> SaveAsync();
    }
}