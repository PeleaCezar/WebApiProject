using ApiProjectPostman.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProjectPostman.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}
