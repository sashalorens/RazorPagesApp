using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class OwnerModel : PageModel
    {
        private AppDBContext _dbContext;
        [BindProperty]
        public List<Owner> Owners { get; set; } = new List<Owner>();
        public OwnerModel(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }
        public async void OnGetAsync()
        {
            {
                try
                {
                    Owners = await _dbContext.Owners.ToListAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
