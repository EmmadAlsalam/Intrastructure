
using System.ComponentModel.DataAnnotations;


namespace Intrastructure.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;
                    
       
        public int CategoryId { get; set; }

 
        public CategoryEntity Category { get; set; } = null!;
    }
}
