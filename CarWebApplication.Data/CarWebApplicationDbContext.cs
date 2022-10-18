using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWebApplication.Data
{
    public class CarWebApplicationDbContext : DbContext
    {
        public CarWebApplicationDbContext(DbContextOptions<CarWebApplicationDbContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
    }
}
