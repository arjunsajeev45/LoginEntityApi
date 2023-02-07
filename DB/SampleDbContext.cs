using LoginEntityApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LoginEntityApi.DB
{
    public class SampleDbContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = "Server=DESKTOP-TPF0JOE\\SQLEXPRESS;Database=CustomerLoginApi;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);

            base.OnConfiguring(optionsBuilder);
        }
    }

}
