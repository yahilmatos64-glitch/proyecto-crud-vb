using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DatosCS.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T>
        where T : class
    {

        private readonly AppDbContext contexto;

        private readonly DbSet<T> tabla;


        public RepositorioGenerico()
        {
            contexto = new AppDbContext();
            tabla = contexto.Set<T>();
        }


        public IEnumerable<T> ObtenerTodos()
        {
            return tabla.ToList();
        }


        public T ObtenerPorId(int id)
        {
            return tabla.Find(id);
        }


        public void Agregar(T entidad)
        {
            tabla.Add(entidad);
            contexto.SaveChanges();
        }


        public void Actualizar(T entidad)
        {
            tabla.Update(entidad);
            contexto.SaveChanges();
        }


        public void Eliminar(T entidad)
        {
            tabla.Remove(entidad);
            contexto.SaveChanges();
        }


        public IEnumerable<T> Buscar(Expression<Func<T, bool>> filtro)
        {
            return tabla.Where(filtro).ToList();
        }

    }
}