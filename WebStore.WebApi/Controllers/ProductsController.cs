using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;

namespace WebStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<ProductDto> Post(ProductDto product)
        {
            await _productService.CreateAsync(product);

            return product;
        }

        //[HttpGet]
        //public async Task<IEnumerable<ProductDto>> Get()

        //{
        //    return await _productService.GetAllAsync();
        //}

        [HttpGet("{id}")] // productWithCategory
        public async Task<ProductDto> Get(int id)
        {
            return await _productService.GetAsync(id);
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetProducts([FromQuery]IList<int> ids)
        {
            return await _productService.GetProductsAsync(ids);
        }

        [HttpGet("top-products")]
        public async Task<IEnumerable<ProductDto>> GetTop()
        {
            const int countTopProducts = 10;
            return await _productService.GetTopAsync(countTopProducts);
        }

        [HttpPut("{id}")]
        public async Task Put(ProductDto product)
        {
            await _productService.UpdateAsync(product);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _productService.DeleteAsync(id);
        }
    }
}