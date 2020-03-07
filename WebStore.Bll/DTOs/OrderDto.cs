using System.Collections.Generic;

namespace WebStore.Bll.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public CustomerDto Customer { get; set; }
        public IEnumerable<OrderDetailsDto> OrderDetails { get; set; }
    }
}