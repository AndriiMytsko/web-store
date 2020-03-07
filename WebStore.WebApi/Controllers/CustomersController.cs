using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;

namespace WebStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<CustomerDto> Post(CustomerDto customer)
        {
            await _customerService.CreateAsync(customer);

            return customer;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> Get()
        {
            return await _customerService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<CustomerDto> Get(int id)
        {
            return await _customerService.GetAsync(id);
        }

        [HttpPut("{id}")]
        public async Task Put(CustomerDto customer)
        {
            await _customerService.UpdateAsync(customer);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _customerService.DeleteAsync(id);
        }
    }
}