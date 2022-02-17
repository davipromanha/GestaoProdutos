using GestaoProdutos.Dominio.Entity;
using System;
using System.Threading.Tasks;

namespace GestaoProdutos.Dominio.Repositorio.Interfaces.Services
{
    public interface IServicoProdutos : IServicoComum<Produtos>
    {
        Task<bool> Post(Produtos entidade);

        Task<bool> Put(Produtos entidade);

        Task<bool> Put(int id);

        bool ValidaDataFabricacao(DateTime data_fabricacao, DateTime data_validade);
    }
}