using ApiWeb.Domain.Models;
using ApiWeb.Domain.Repositories.Interfaces;
using ApiWeb.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Domain.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext _context;
        public SupplierRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Supplier>> ListAsync() => await _context.Suppliers.ToListAsync();
        public async Task<Supplier?> FindByIdAsync(int id) => await _context.Suppliers.FindAsync(id);
        public async Task AddAsync(Supplier supplier) => await _context.Suppliers.AddAsync(supplier);
        public void Update(Supplier supplier) => _context.Suppliers.Update(supplier);
        public void Remove(Supplier supplier) => _context.Suppliers.Remove(supplier);
    }
}
