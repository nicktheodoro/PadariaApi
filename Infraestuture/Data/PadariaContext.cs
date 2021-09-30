using Microsoft.EntityFrameworkCore;
using PadariaApi.Domains.Models;

namespace PadariaApi.Infraestuture.Data
{
    public class PadariaContext : DbContext
    {
        public PadariaContext(DbContextOptions<PadariaContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}