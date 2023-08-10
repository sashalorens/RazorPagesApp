using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class SellerModel : PageModel
    {
        private AppDBContext _dbContext;
        [BindProperty]
        public List<Seller> Sellers { get; set; } = new List<Seller>();

        public SellerModel(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }
        public async void OnGetAsync()
        {
            try
            {
                Sellers = await _dbContext.Sellers.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
