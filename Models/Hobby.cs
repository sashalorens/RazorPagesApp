namespace RazorPagesApp.Models
{
    public class Hobby
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Hobby(string name, string description) {
            Name = name;
            Description = description;
        }

        public Hobby(string name) : this(name, "In time, you will know the tragic extent of my failings...") { }

        public Hobby(): this("Fan the flames! Mold the metal! We are raising an army!") { }
    }
}
