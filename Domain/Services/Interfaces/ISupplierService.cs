using ApiWeb.Domain.Models;

namespace ApiWeb.Domain.Services.Interfaces
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> ListAsync();
        Task<Supplier?> FindByIdAsync(int id);
        Task<Supplier> CreateAsync(Supplier supplier);
        Task<Supplier?> UpdateAsync(int id, Supplier supplier);
        Task<Supplier?> DeleteAsync(int id);
    }
}
