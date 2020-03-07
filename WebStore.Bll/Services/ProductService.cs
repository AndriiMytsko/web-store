using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;
using WebStore.Dal.Entities;
using WebStore.Dal.Repositories.Interfaces;

namespace WebStore.Bll.Services
{

    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(
            IMapper mapper,
            IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task CreateAsync(ProductDto dto)
        {
            var entity = _mapper.Map<Product>(dto); 

            await _productRepository.CreateAsync(entity);
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            var entity = await _productRepository.GetAsync(id);
            var product = _mapper.Map<ProductDto>(entity);

            return product;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var entities = await _productRepository.GetAllAsync();
            var products = _mapper.Map<IEnumerable<ProductDto>>(entities);

            return products;
        }

        public async Task<IEnumerable<ProductDto>> GetTopAsync(int count)
        {
            var entities = await _productRepository.GetTopAsync(count);
            var products = _mapper.Map<IEnumerable<ProductDto>>(entities);

            return products;
        }

        public async Task UpdateAsync(ProductDto dto)
        {
            var entity = await _productRepository.GetAsync(dto.Id);
            entity.Name = dto.Name;
            entity.Price = dto.Price;
            if (dto.Category != null)
            {
                entity.CategoryId = dto.Category.Id;
            }
            await _productRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await _productRepository.GetAsync(Id);
            if (entity == null)
            {
                return;
            }

            await _productRepository.DeleteAsync(Id);
        }
    }
}