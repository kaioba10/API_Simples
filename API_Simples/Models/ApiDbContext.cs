using Microsoft.EntityFrameworkCore;

namespace API_Simples.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
