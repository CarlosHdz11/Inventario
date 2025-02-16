using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VentasEnLinea.AcessoDatos.Data;
using VentasEnLinea.AcessoDatos.Repositorio.Irepositorio;
using Microsoft.EntityFrameworkCore;

namespace VentasEnLinea.AcessoDatos.Repositorio
{
    public class BodegaRepositorio : Repositorio<Bodega>, IBodegaRepositorio
    {
        private readonly ApplicationDbContext _db;
        public BodegaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Actualizar(Bodega bodega)
        {
            var bodegaBD = _db.Bodegas.FirstOrDefault(b => b.Id == bodega.Id);
            if (bodegaBD != null){
                bodegaBD.Nombre=bodega.Nombre;
                bodegaBD.Descripcion = bodega.Descripcion;
                bodegaBD.Estado = bodega.Estado;
                _db.SaveChanges();

            }
            
        }

        public Task Agregar(Bodega entidad)
        {
            throw new NotImplementedException();
        }

        public Task<Bodega> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Bodega> ObtenerPrimero(Expression<Func<Bodega, bool>> filtro = null, string incluirPrioiedades = null, bool istracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bodega>> ObtenerTodos(Expression<Func<Bodega, bool>> filtro = null, Func<IQueryable<Bodega>, IOrderedQueryable<Bodega>> orderBy = null, string incluirPrioiedades = null, bool istracking = true)
        {
            throw new NotImplementedException();
        }

        public void Remover(Bodega entidad)
        {
            throw new NotImplementedException();
        }

        public void RemoverRango(IEnumerable<Bodega> entidad)
        {
            throw new NotImplementedException();
        }
    }
}
