using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;

namespace WebStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<CategoryDto> Post(CategoryDto category)
        {
            await _categoryService.CreateAsync(category);

            return category;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryDto>> Get()
        {
            return await _categoryService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<CategoryDto> Get(int id)
        {
            return await _categoryService.GetAsync(id);
        }

        [HttpGet("{id}/products")]
        public async Task<IEnumerable<ProductDto>> GetProductsByCategory(int id)
        {
            return await _categoryService.GetProductsByCategoryIdAsync(id);
        }

        [HttpPut("{id}")]
        public async Task Put(CategoryDto category)
        {
            await _categoryService.UpdateAsync(category);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _categoryService.DeleteAsync(id);
        }
    }
}
