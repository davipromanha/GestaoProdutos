using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoProdutos.Dominio.Repositorio.Interfaces
{
    public interface IRepositorioComum<T> where T : class
    {
        Task<IEnumerable<T>> ListaRegistros();

        Task<T> RecuperarRegistroPorCodigo(int id);
    }
}