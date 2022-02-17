using GestaoProdutos.Dominio.Entity;
using GestaoProdutos.Infrastructure.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GestaoProdutos.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produtos>(new ProdutosMap().Configure);
        }
    }
}