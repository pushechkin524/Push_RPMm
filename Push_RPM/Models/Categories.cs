using System.ComponentModel.DataAnnotations;

namespace Push_RPM.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description_ { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
