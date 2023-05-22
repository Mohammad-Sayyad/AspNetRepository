using Microsoft.EntityFrameworkCore;

namespace AspNetRepository.Models
{
    public class DBMohammadpour: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DBMohammadpourRepository;Integrated Security=True");
        }
    }
}
