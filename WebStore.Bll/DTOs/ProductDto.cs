namespace WebStore.Bll.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public CategoryDto Category { get; set; }
    }
}
