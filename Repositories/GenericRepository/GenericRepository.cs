using Microsoft.EntityFrameworkCore;
using ProiectTest.Data;
using ProiectTest.Models.Base;

namespace ProiectTest.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity 
    {
        protected readonly ProiectTestContext _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(ProiectTestContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        // Get all
        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        public IQueryable<TEntity> GetAllAsQueryable()
        {
            return _table.AsNoTracking();
        }

        // Create 

        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        // Update

        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        // Delete

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => _table.Remove(entity));
        }

        // Find

        public TEntity FindById(Guid id)
        {
            return _table.Find(id);
        }

        public async Task<TEntity> FindByIdAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }

        // Save

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}