using GestaoProdutos.Dominio.Entity;
using GestaoProdutos.Dominio.Repositorio.Interfaces;
using GestaoProdutos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infrastructure.Data.Repositorios
{
    public class ProdutosRepositorios : IRepositorioProdutos
    {
        protected readonly SqlContext sqlContext;
        //private readonly ProdutoServices produtoServices;
        public ProdutosRepositorios(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
            //this.produtoServices = produtoServices;
        }

        public Task<Produtos> Editar(Produtos entidade)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Inserir(Produtos entidade)
        {
            try
            {
                await sqlContext.AddAsync(entidade);
                await sqlContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IEnumerable<Produtos>> ListaRegistros()
        {
            throw new NotImplementedException();
        }

        public Task<Produtos> RecuperarRegistroPorCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveProduto(int id)
        {
            throw new NotImplementedException();
        }

        public bool ValidaDataFabricacao(DateTime data_fabricacao, DateTime data_validade)
        {
            throw new NotImplementedException();
        }
    }
}
