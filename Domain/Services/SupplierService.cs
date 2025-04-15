using ApiWeb.Domain.Models;
using ApiWeb.Domain.Repositories.Interfaces;
using ApiWeb.Domain.Services.Interfaces;
using ApiWeb.Persistence;

namespace ApiWeb.Domain.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repository;
        private readonly AppDbContext _context;

        public SupplierService(ISupplierRepository repository, AppDbContext context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> ListAsync() => await _repository.ListAsync();
        public async Task<Supplier?> FindByIdAsync(int id) => await _repository.FindByIdAsync(id);
        public async Task<Supplier> CreateAsync(Supplier supplier)
        {
            await _repository.AddAsync(supplier);
            await _context.SaveChangesAsync();
            return supplier;
        }

        public async Task<Supplier?> UpdateAsync(int id, Supplier supplier)
        {
            var existing = await _repository.FindByIdAsync(id);
            if (existing == null) return null;
            existing.Name = supplier.Name;
            existing.Email = supplier.Email;
            _repository.Update(existing);
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<Supplier?> DeleteAsync(int id)
        {
            var existing = await _repository.FindByIdAsync(id);
            if (existing == null) return null;
            _repository.Remove(existing);
            await _context.SaveChangesAsync();
            return existing;
        }
    }
}
