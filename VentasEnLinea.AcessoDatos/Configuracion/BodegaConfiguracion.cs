using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VentasEnLinea.AcessoDatos.Configuracion
{
    //Va a heredar del tipo de dato bodega
    public class BodegaConfiguracion : IEntityTypeConfiguration<Bodega>
    {
        //Bodega es el nombre del modelo
        public void Configure(EntityTypeBuilder<Bodega> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(X => X.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(X => X.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(X => X.Estado).IsRequired().HasMaxLength(100);


        }
    }
}
