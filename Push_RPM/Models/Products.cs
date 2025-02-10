using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Push_RPM.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string Name_ { get; set; }
        public string Description_ { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageURL { get; set; }

        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Categories { get; set; }


        //public List<Products> products { get; set; } = new List<Products>();
    }
}
