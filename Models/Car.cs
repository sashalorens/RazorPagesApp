namespace RazorPagesApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Manufacturer { get; set; } = "";
        public int Year { get; set; } = 0;
        public Owner? Owner { get; set; }
    }
}
