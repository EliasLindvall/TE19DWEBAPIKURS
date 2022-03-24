using Microsoft.EntityFrameworkCore;

namespace TE19DWEBAPIKURS.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Student> students {get; set;}
    }
}