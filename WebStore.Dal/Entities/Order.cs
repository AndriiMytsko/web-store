using System.Collections.Generic;

namespace WebStore.Dal.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
