using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;

namespace WebStore.Bll.Services.Interfaces
{
    public interface IProductService
    { 
        Task CreateAsync(ProductDto dto);
        Task<ProductDto> GetAsync(int id);
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<IEnumerable<ProductDto>> GetTopAsync(int count);
        Task WriteToExcel(string fileName);
        Task<IEnumerable<ProductDto>> GetProductsAsync(IEnumerable<int> ids);
        Task UpdateAsync(ProductDto dto);
        Task DeleteAsync(int id);
    }
}
