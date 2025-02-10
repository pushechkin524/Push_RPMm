using System.ComponentModel.DataAnnotations;

namespace Push_RPM.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
