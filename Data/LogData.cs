using Microsoft.EntityFrameworkCore;
using course_std.Models;

namespace course_std.Data
{
    public class LogContext : DbContext
    {
        public LogContext(DbContextOptions<LogContext> options)
            : base(options)
        {
        }


        public DbSet<Log> Log { get; set; }
    }
}
