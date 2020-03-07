namespace WebStore.Bll.DTOs
{
    public class OrderDetailsDto
    {
        public int Quantity { get; set; }
        public OrderDto Order { get; set; }
        public ProductDto Product { get; set; }
    }
}
