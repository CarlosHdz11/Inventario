//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using VentasEnLinea.AcessoDatos.Data;
using System.Reflection;






namespace VentasEnLinea.AcessoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //nombre del modelo y de la tabla en oracle
        public DbSet<Bodega>Bodegas {get; set;}
        // Este metodo reconocera los archivos de configuracion de cada modelo
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            // Configuraciones adicionales del modelo aquí
        }
    }
}
