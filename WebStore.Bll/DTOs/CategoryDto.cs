using System.Collections;
using System.Collections.Generic;

namespace WebStore.Bll.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}