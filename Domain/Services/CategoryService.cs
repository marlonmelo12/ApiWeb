using ApiWeb.Domain.Models;
using ApiWeb.Domain.Repositories.Interfaces;
using ApiWeb.Domain.Services.Interfaces;
using ApiWeb.Persistence;

namespace ApiWeb.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly AppDbContext _context;

        public CategoryService(ICategoryRepository repository, AppDbContext context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<IEnumerable<Category>> ListAsync() => await _repository.ListAsync();
        public async Task<Category?> FindByIdAsync(int id) => await _repository.FindByIdAsync(id);
        public async Task<Category> CreateAsync(Category category)
        {
            await _repository.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category?> UpdateAsync(int id, Category category)
        {
            var existing = await _repository.FindByIdAsync(id);
            if (existing == null) return null;
            existing.Name = category.Name;
            _repository.Update(existing);
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<Category?> DeleteAsync(int id)
        {
            var existing = await _repository.FindByIdAsync(id);
            if (existing == null) return null;
            _repository.Remove(existing);
            await _context.SaveChangesAsync();
            return existing;
        }
    }
}
