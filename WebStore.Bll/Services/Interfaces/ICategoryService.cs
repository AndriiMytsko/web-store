using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;

namespace WebStore.Bll.Services.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryDto dto);
        Task<CategoryDto> GetAsync(int id);
        Task WriteToExcel(string fileName);
        byte[] GetFile(string fileName);
        Task<IEnumerable<ProductDto>> GetProductsByCategoryIdAsync(int id);
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task UpdateAsync(CategoryDto dto);
        Task DeleteAsync(int id);
    }
}
