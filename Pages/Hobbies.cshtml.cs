using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class HobbiesModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
        public void OnGet()
        {
            Hobbies.Add(new Hobby("Observing the stars", "Behold the infinite malignity of the stars!"));
            Hobbies.Add(new Hobby("Learning math", "Curiosity, interest, and obsession - mile markers on my road to damnation."));
            Hobbies.Add(new Hobby());
        }
    }
}
