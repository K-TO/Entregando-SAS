using Entregando.Infraestructure.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Entregando.Data.Mapping
{
    public class VehiculoMap : EntityTypeConfiguration<Vehiculo>
    {
        public VehiculoMap()
        {
            ToTable("Vehiculo");
            Property(x => x.Placa).IsRequired().HasMaxLength(10);
        }
    }
}
