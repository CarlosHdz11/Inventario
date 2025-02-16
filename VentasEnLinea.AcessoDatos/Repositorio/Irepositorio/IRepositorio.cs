using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VentasEnLinea.AcessoDatos.Data;

namespace VentasEnLinea.AcessoDatos.Repositorio.Irepositorio
{
    //generico para que pueda recibir cualquier tipo de objeto
    public interface Interface1<T> where T:class
    {
       
      Task<T> Obtener(int id);

        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T,bool>>filtro=null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string incluirPrioiedades = null,
            bool istracking = true


            );
      Task<T> ObtenerPrimero(
            Expression<Func<T, bool>> filtro = null,
            string incluirPrioiedades = null,
            bool istracking = true

            );
        Task Agregar(T entidad);
        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);

    }
}
