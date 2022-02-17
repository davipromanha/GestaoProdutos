using GestaoProdutos.Dominio.Entity;
using GestaoProdutos.Dominio.Repositorio.Interfaces;

namespace GestaoProdutos.Dominio.Servicos
{
    public class ServicoProdutos : ServicoComum<Produtos>, IServicoProdutos
    {
        private readonly IRepositorioProdutos repositorioProdutos;

        public ServicoProdutos(IRepositorioProdutos repositorioProdutos) : base(repositorioProdutos)
        {
            this.repositorioProdutos = repositorioProdutos;
        }

        public void RemoveProduto(int id)
        {
            repositorioProdutos.RemoveProduto(id);
        }

        public bool ValidaDataFabricacao(Produtos entidade)
        {
            return repositorioProdutos.ValidaDataFabricacao(entidade);
        }
    }
}