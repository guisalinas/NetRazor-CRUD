using CRUD_NetRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NetRazor.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
                
        }
        public DbSet<Course> Course { get; set; }
    }
}
