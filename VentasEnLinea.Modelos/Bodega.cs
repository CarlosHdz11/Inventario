using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasEnLinea.AcessoDatos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")][MaxLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripcion es requerido")]
        [MaxLength(100)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Estado es requerido")]
        
        public bool Estado { get; set; }
    }
}
