
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Intrastructure.Entities
{
    public class OrderItemEntity
    {
        [Key]
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }

        public OrderEntity Order { get; set; } = null!;

       
        public int ProductId { get; set; }

        public ProductEntity Product { get; set; } = null!;

       
    }
}

