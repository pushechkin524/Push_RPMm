using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Push_RPM.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int? OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Orders Orders { get; set; }

        public int? ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Products Products { get; set; }



    }
}
