using LanchesJardim.NET6._0.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesJardim.NET6._0.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}
