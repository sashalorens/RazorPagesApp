using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public List<Service> Services { get; set; } = new List<Service>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Services.Add(new Service("Simple", "simple.png"));
            Services.Add(new Service("No coding", "nocoding.png"));
            Services.Add(new Service("500+ sites","sites.png"));
            Services.Add(new Service("Gifts", "gifts.png"));
        }
    }
}