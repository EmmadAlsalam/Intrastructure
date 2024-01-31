
using System.ComponentModel.DataAnnotations;


namespace Intrastructure.Entities
{
    public class OrderItemEntity
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }


        public int OrderId { get; set; }

       
        public OrderEntity Order { get; set; } = null!;

        public int ProductId { get; set; }

     
        public ProductEntity Product { get; set; } = null!;


    }
}
