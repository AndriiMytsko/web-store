using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Dal.Entities;

namespace WebStore.Dal.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task CreateAsync(Category category);
        Task DeleteAsync(int id);
        Task<Category> GetAsync(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task UpdateAsync(Category category);
    }
}