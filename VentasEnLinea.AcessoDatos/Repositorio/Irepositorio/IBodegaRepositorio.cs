using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasEnLinea.AcessoDatos.Repositorio.Irepositorio
{
    public interface IBodegaRepositorio : Interface1<Bodega>
    {
        void Actualizar(Bodega bodega);
    }
}
