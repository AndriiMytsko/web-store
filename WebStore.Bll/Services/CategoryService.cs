using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;
using WebStore.Dal.Entities;
using WebStore.Dal.Repositories.Interfaces;

namespace WebStore.Bll.Services
{
    
    public class CategoryService : ICategoryService
{
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(
          IMapper mapper,
          ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task CreateAsync(CategoryDto dto)
        {
            var entity = _mapper.Map<Category>(dto);

            await _categoryRepository.CreateAsync(entity);
        }

        public async Task<CategoryDto> GetAsync(int id)
        {
            var entity = await _categoryRepository.GetAsync(id);
            var category = _mapper.Map<CategoryDto>(entity);

            return category;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsByCategoryIdAsync(int id)
        {
            var entities = await _categoryRepository.GetProductsByCategoryIdAsync(id);
            var products = _mapper.Map<IEnumerable<ProductDto>>(entities);

            return products;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var entities = await _categoryRepository.GetAllAsync();
            var categories = _mapper.Map<IEnumerable<CategoryDto>>(entities);

            return categories;
        }

        public async Task UpdateAsync(CategoryDto dto)
        {
            var entity = await _categoryRepository.GetAsync(dto.Id);
            entity.Name = dto.Name;

            await _categoryRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _categoryRepository.GetAsync(id);
            if (entity == null)
            {
                return;
            }

            await _categoryRepository.DeleteAsync(id);
        }
    }
}
