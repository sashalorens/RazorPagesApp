using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class CarModel : PageModel
    {
        private AppDBContext _dbContext;
        [BindProperty]
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarModel(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }
        public async void OnGetAsync()
        {
            try
            {
                Cars = await _dbContext.Cars.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
