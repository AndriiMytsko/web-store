using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;

namespace WebStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/orderdetails")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailsService _orderDetailsService;
        public OrderDetailsController(IOrderDetailsService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }

        [HttpPost]
        public async Task<OrderDetailsDto> Post(OrderDetailsDto orderDetails)
        {
            await _orderDetailsService.CreateAsync(orderDetails);

            return orderDetails;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDetailsDto>> Get()
        {
            return await _orderDetailsService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<OrderDetailsDto> Get(int id)
        {
            return await _orderDetailsService.GetAsync(id);
        }

        [HttpPut("{id}")]
        public async Task Put(OrderDetailsDto orderDetails)
        {
            await _orderDetailsService.UpdateAsync(orderDetails);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _orderDetailsService.DeleteAsync(id);
        }
    }
}