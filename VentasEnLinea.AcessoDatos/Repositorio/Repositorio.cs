using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VentasEnLinea.AcessoDatos.Data;
using VentasEnLinea.AcessoDatos.Repositorio.Irepositorio;
using Microsoft.EntityFrameworkCore;

namespace VentasEnLinea.AcessoDatos.Repositorio
{
    public class Repositorio<T> : Interface1<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repositorio(ApplicationDbContext db)
        {
            _db = db;
            // this.dbSet = _db.Set<T>();
            this.dbSet = _db.Set<T>();

        }
  

        public  async Task Agregar(T entidad)
        {
            await dbSet.AddAsync(entidad); //insert into
        }

        public async Task<T> Obtener(int id)
        {
            return await dbSet.FindAsync(id);// select*from por id
        }

        public async Task<T> ObtenerPrimero(Expression<Func<T, bool>> filtro = null, string incluirPrioiedades = null, bool istracking = true)
        {
            IQueryable<T> query = dbSet;
            if (filtro != null)
            {
                query = query.Where(filtro); // select*from where
            }
            if (incluirPrioiedades != null)
            {
                foreach (var incluirProp in incluirPrioiedades.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incluirProp);//categoria, marca

                }
            }
            
            if (!istracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync();


        }

        public async Task<IEnumerable<T>> ObtenerTodos(Expression<Func<T, bool>> filtro = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string incluirPrioiedades = null, bool istracking = true)
        {
            IQueryable<T> query = dbSet;
            if (filtro != null)
            {
                query = query.Where(filtro); // select*from where
            }
            if (incluirPrioiedades != null)
            {
                foreach (var incluirProp in incluirPrioiedades.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries ))
                {
                    query = query.Include(incluirProp);//categoria, marca

                }
            }
            if(orderBy != null)
            {
                query = orderBy(query);
            }
            if (!istracking)
            {
                query = query.AsNoTracking();
            }
            return await query.ToListAsync();


        }

        public void Remover(T entidad)
        {
            dbSet.Remove(entidad);
        
        }

        public void RemoverRango(IEnumerable<T> entidad)
        {
            dbSet.RemoveRange(entidad);
        }
    }
}
