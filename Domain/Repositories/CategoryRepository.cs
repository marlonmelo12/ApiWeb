using ApiWeb.Domain.Models;
using ApiWeb.Domain.Repositories.Interfaces;
using ApiWeb.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Domain.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Category>> ListAsync() => await _context.Categories.ToListAsync();
        public async Task<Category?> FindByIdAsync(int id) => await _context.Categories.FindAsync(id);
        public async Task AddAsync(Category category) => await _context.Categories.AddAsync(category);
        public void Update(Category category) => _context.Categories.Update(category);
        public void Remove(Category category) => _context.Categories.Remove(category);
    }
}
