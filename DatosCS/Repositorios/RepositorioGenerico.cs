
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DatosCS.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T>
        where T : class
    {
        public IEnumerable<T> ObtenerTodos()
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Set<T>()
                    .AsNoTracking()
                    .ToList();
            }
        }

        public T ObtenerPorId(int id)
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Set<T>().Find(id);
            }
        }

        public void Agregar(T entidad)
        {
            using (var contexto = new AppDbContext())
            {
                contexto.Set<T>().Add(entidad);
                contexto.SaveChanges();
            }
        }

        public void Actualizar(T entidad)
        {
            using (var contexto = new AppDbContext())
            {
                var tabla = contexto.Set<T>();

                var tipoEntidad = contexto.Model.FindEntityType(typeof(T));
                var clave = tipoEntidad?.FindPrimaryKey();

                if (clave == null || clave.Properties.Count != 1)
                    throw new InvalidOperationException(
                        "La entidad no tiene una clave primaria simple."
                    );

                var valorClave = contexto.Entry(entidad)
                    .Property(clave.Properties[0].Name)
                    .CurrentValue;

                var existente = tabla.Find(valorClave);

                if (existente == null)
                    throw new InvalidOperationException(
                        "No se encontró el registro que desea actualizar."
                    );

                contexto.Entry(existente)
                    .CurrentValues.SetValues(entidad);

                contexto.SaveChanges();
            }
        }

        public void Eliminar(T entidad)
        {
            using (var contexto = new AppDbContext())
            {
                var tabla = contexto.Set<T>();

                var tipoEntidad = contexto.Model.FindEntityType(typeof(T));
                var clave = tipoEntidad?.FindPrimaryKey();

                if (clave == null || clave.Properties.Count != 1)
                    throw new InvalidOperationException(
                        "La entidad no tiene una clave primaria simple."
                    );

                var valorClave = contexto.Entry(entidad)
                    .Property(clave.Properties[0].Name)
                    .CurrentValue;

                var existente = tabla.Find(valorClave);

                if (existente == null)
                    throw new InvalidOperationException(
                        "El registro que desea eliminar ya no existe."
                    );

                tabla.Remove(existente);

                contexto.SaveChanges();
            }
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> filtro)
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Set<T>()
                    .AsNoTracking()
                    .Where(filtro)
                    .ToList();
            }
        }
    }
}
