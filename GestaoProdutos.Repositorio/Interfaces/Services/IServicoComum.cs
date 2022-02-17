using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Dominio.Repositorio.Interfaces.Services
{
    public interface IServicoComum<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);
    }
}