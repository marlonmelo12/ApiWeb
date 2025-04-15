using ApiWeb.Domain.Models;

namespace ApiWeb.Domain.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> ListAsync();
        Task<Supplier?> FindByIdAsync(int id);
        Task AddAsync(Supplier supplier);
        void Update(Supplier supplier);
        void Remove(Supplier supplier);
    }
}
