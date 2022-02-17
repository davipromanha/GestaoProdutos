using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GestaoProdutos.Infrastructure.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<SqlContext>
    {
        public SqlContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações
            var connectionString = "Data Source=server;Password=pass;Persist Security Info=True;User ID=user;Initial Catalog=AppTeste;";
            var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new SqlContext(optionsBuilder.Options);
        }
    }
}
