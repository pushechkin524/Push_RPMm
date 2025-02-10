namespace Push_RPM.Models
{
    public class HomeViewModel
    {
        public Dictionary<string, DateTime> Time { get; set; }
        public List<Products> Product { get; set; }
        public List<Categories> Category { get; set; }
    }
}
