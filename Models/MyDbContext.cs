using Microsoft.EntityFrameworkCore;

namespace Atividade.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pessoa> Usuarios { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
    }
}
