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
        private readonly IRepositorioProdutos repositorioProdutos;

        public ProdutoServices(IRepositorioProdutos repositorioProdutos)
        {
            this.repositorioProdutos = repositorioProdutos;
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
            return await repositorioProdutos.Inserir(entidade);
        }

        public async Task<Produtos> Put(Produtos entidade)
        {
            return await repositorioProdutos.Editar(entidade);
        }

        public async Task<bool> Put(int id)
        {
            return await repositorioProdutos.RemoveProduto(id);
        }

        public bool ValidaDataFabricacao(DateTime data_fabricacao, DateTime data_validade)
        {
            return repositorioProdutos.ValidaDataFabricacao(data_fabricacao, data_validade);
        }
    }
}