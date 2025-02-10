using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Push_RPM.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status_ { get; set; }


        public int? CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customers Customers { get; set; }




    }
}
