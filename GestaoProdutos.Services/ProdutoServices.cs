using GestaoProdutos.Dominio.Entity;
using GestaoProdutos.Dominio.Repositorio.Interfaces;
using GestaoProdutos.Dominio.Repositorio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Services
{
    public class ProdutoServices : IServicoProdutos
    {
        private IRepositorioProdutos repositorioProdutos;

        public ProdutoServices(IRepositorioProdutos repositorio)
        {
            this.repositorioProdutos = repositorio;
        }

        public async Task<Produtos> Get(int id)
        {
            return await repositorioProdutos.RecuperarRegistroPorCodigo(id);
        }

        public async Task<IEnumerable<Produtos>> GetAll()
        {
            return await repositorioProdutos.ListaRegistros();
        }

        public async Task<bool> Post(Produtos entidade)
        {
            if (ValidaDataFabricacao(entidade.DataFabricao, entidade.DataValidade)) 
            {
                return await repositorioProdutos.Inserir(entidade);
            }
            return false;            
        }

        public async Task<Produtos> Put(Produtos entidade)
        {
            if (ValidaDataFabricacao(entidade.DataFabricao, entidade.DataValidade))
            {
                return await repositorioProdutos.Editar(entidade);
            }
            return null;
            
        }

        public async Task<bool> Put(int id)
        {
            return await repositorioProdutos.RemoveProduto(id);
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