using Microsoft.EntityFrameworkCore;

namespace test_for_path_project.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                                
        }

        public DbSet<University> Unis {  get; set; }
        public DbSet<test> TS { get; set; }
    }
}
