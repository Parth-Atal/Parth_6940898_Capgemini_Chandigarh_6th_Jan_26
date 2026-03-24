using System.ComponentModel.DataAnnotations;
namespace EcommerceApp.Models
{

    public class ShippingDetail
    {
        public int ShippingDetailId { get; set; }

        [Required]
        public string Address { get; set; }

        public string Status { get; set; } = "Pending";

        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
