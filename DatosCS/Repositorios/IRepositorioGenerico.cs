using System.Linq.Expressions;

namespace DatosCS.Repositorios
{
    public interface IRepositorioGenerico<T> where T : class
    {

        IEnumerable<T> ObtenerTodos();

        T ObtenerPorId(int id);

        void Agregar(T entidad);

        void Actualizar(T entidad);

        void Eliminar(T entidad);

        IEnumerable<T> Buscar(Expression<Func<T, bool>> filtro);

    }
}