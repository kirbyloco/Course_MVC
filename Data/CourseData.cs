using Microsoft.EntityFrameworkCore;
using course_std.Models;

namespace course_std.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }

    }

}
