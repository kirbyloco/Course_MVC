using Microsoft.EntityFrameworkCore;
using course_std.Models;

namespace course_std.Data
{
    public class CreditsContext : DbContext
    {
        public CreditsContext(DbContextOptions<CreditsContext> options)
            : base(options)
        {
        }

        public DbSet<Credits> Credits { get; set; }
    }
}
