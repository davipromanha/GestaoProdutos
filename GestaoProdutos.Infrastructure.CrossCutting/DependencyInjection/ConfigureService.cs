using GestaoProdutos.Dominio.Repositorio.Interfaces.Services;
using GestaoProdutos.Infrastructure.Data.Repositorios;
using GestaoProdutos.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoProdutos.Infrastructure.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IServicoProdutos, ProdutoServices>();
        }
    }
}