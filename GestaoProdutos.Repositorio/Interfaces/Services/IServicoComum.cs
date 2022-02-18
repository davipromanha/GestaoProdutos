using GestaoProdutos.Dominio.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Dominio.Repositorio.Interfaces.Services
{
    public interface IServicoComum<T> where T : Produtos
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);
    }
}