using GestaoProdutos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoProdutos.Infrastructure.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection,
                                                        IConfiguration configuration)
        {
            var secaoBanco = configuration.GetSection("DatabaseOptions");
            var connection = $"Server={secaoBanco.GetSection("Server").Value}" +
                $";Database={secaoBanco.GetSection("Database").Value}" +
                $";User Id={secaoBanco.GetSection("UserId").Value}" +
                $";Password={secaoBanco.GetSection("Password").Value}" +
                ";Persist Security Info=True;";

            serviceCollection.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
        }
    }
}