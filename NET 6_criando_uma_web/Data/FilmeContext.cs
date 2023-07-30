using Microsoft.EntityFrameworkCore;
using NET_6_criando_uma_web.Models;

namespace NET_6_criando_uma_web.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) 
            : base(opts) 
        { 
            
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
