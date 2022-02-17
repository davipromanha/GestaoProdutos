using GestaoProdutos.Dominio.Entity;
using GestaoProdutos.Dominio.Objetos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Infrastructure.Data.Repositorios
{
    public class ProdutosRepositorios
    {
        protected readonly SqlContext sqlContext;
        private DbSet<Produtos> dataset;

        public ProdutosRepositorios(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
            this.dataset = sqlContext.Set<Produtos>();
        }

        public async Task<bool> Editar(Produtos entidade)
        {
            try
            {
                sqlContext.Update(entidade);
                await sqlContext.SaveChangesAsync();
                return true;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public async Task<bool> Inserir(Produtos entidade)
        {
            try
            {
                await dataset.AddAsync(entidade);
                //await sqlContext.AddAsync(entidade);
                await sqlContext.SaveChangesAsync();
                return true;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public async Task<IEnumerable<Produtos>> ListaRegistros()
        {
            try
            {
                return await dataset.ToListAsync();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public async Task<Produtos> RecuperarRegistroPorCodigo(int id)
        {
            try
            {
                return await dataset.SingleOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public async Task<bool> RemoveProduto(int id)
        {
            var result = await dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result == null)
            {
                return false;
            }
            result.situacaoProduto = Situacoes.Inativo;
            sqlContext.Entry(result).OriginalValues.SetValues(sqlContext.Entry(result).CurrentValues);
            await sqlContext.SaveChangesAsync();
            return true;
        }
    }
}