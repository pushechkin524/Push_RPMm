using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Push_RPM.Models
{
    public class Payments
    {
        [Key]
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }


        public int? OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Orders Orders { get; set; }
    }
}
