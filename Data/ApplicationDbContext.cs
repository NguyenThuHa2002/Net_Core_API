using Microsoft.EntityFrameworkCore;
using Net_Core_API.Models;

namespace Net_Core_API.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Student> Student { get ; set;}
        
    }
}
