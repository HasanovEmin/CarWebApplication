using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarWebApplication.Data;

namespace CarWebApplication.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CarWebApplicationDbContext _context;

        public IndexModel(CarWebApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Car> Cars { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cars != null)
            {
                Cars = await _context.Cars.ToListAsync();
            }
        }
    }
}
