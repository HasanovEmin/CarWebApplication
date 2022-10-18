using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarWebApplication.Data;

namespace CarWebApplication.Pages.Cars
{
    public class DetailsModel : PageModel
    {
        private readonly CarWebApplicationDbContext _context;

        public DetailsModel(CarWebApplicationDbContext context)
        {
            _context = context;
        }

      public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            else 
            {
                Car = car;
            }
            return Page();
        }
    }
}
