namespace RazorPagesApp.Models
{
    public class Service
    {
        public string Title { get; set; }
        public string ImageName { get; set; }

        public Service(string title, string imageName)
        {
            Title = title;
            ImageName = imageName;
        }

        public Service(string title) : this(title, "placeholder.png") { }
        public Service() : this("Service") { }
    }
}
