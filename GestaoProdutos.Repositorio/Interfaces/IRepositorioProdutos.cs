using GestaoProdutos.Dominio.Entity;
using System;
using System.Threading.Tasks;

namespace GestaoProdutos.Dominio.Repositorio.Interfaces
{
    public interface IRepositorioProdutos : IRepositorioComum<Produtos>
    {
        Task<bool> Inserir(Produtos entidade);

        Task<Produtos> Editar(Produtos entidade);

        Task<bool> RemoveProduto(int id);

        bool ValidaDataFabricacao(DateTime data_fabricacao, DateTime data_validade);
    }
}