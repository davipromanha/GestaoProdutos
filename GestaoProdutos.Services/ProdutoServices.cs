using GestaoProdutos.Dominio.Entity;
using GestaoProdutos.Dominio.Repositorio.Interfaces.Services;
using GestaoProdutos.Infrastructure.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Services
{
    public class ProdutoServices : IServicoProdutos
    {
        private readonly ProdutosRepositorios produtosRepositorios;

        public ProdutoServices(ProdutosRepositorios produtosRepositorios)
        {
            this.produtosRepositorios = produtosRepositorios;
        }

        public async Task<Produtos> Get(int id)
        {
            return await produtosRepositorios.RecuperarRegistroPorCodigo(id);
        }

        public async Task<IEnumerable<Produtos>> GetAll()
        {
            return await produtosRepositorios.ListaRegistros();
        }

        public async Task<bool> Post(Produtos entidade)
        {
            if (ValidaDataFabricacao(entidade.DataFabricao, entidade.DataValidade)) 
            {
                return await produtosRepositorios.Inserir(entidade);
            }
            return false;            
        }

        public async Task<bool> Put(Produtos entidade)
        {
            if (ValidaDataFabricacao(entidade.DataFabricao, entidade.DataValidade))
            {
                return await produtosRepositorios.Editar(entidade);
            }
            return false;
            
        }

        public async Task<bool> Put(int id)
        {
            return await produtosRepositorios.RemoveProduto(id);
        }

        public bool ValidaDataFabricacao(DateTime data_fabricacao, DateTime data_validade)
        {
            if (data_fabricacao < data_validade)
            {
                return true;
            }
            return false;
        }
    }
}