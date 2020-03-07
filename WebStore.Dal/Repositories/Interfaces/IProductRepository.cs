using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Dal.Entities;

namespace WebStore.Dal.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task CreateAsync(Product product);
        Task DeleteAsync(int id);
        Task<Product> GetAsync(int id);
        Task<IEnumerable<Product>> GetTopAsync(int count);
        Task<IEnumerable<Product>> GetAllAsync();
        Task UpdateAsync(Product product);
    }
}