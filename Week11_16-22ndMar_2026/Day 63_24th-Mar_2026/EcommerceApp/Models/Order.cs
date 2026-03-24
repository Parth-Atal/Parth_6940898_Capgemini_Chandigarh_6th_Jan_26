using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{

    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }

        public ShippingDetail? ShippingDetail { get; set; }
    }
}
