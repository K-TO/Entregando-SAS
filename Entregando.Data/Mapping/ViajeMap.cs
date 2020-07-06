using Entregando.Infraestructure.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Entregando.Data.Mapping
{
    public class ViajeMap : EntityTypeConfiguration<Viaje>
    {
        public ViajeMap()
        {
            ToTable("Viaje");
            Property(x => x.CiudadSalida).IsRequired().HasMaxLength(50);
            Property(x => x.CiudadDestino).IsRequired().HasMaxLength(50);
            Property(x => x.FechaSalida).IsRequired();
            Property(x => x.FechaLlegada).IsOptional();
            Property(x => x.ViajeCancelado).IsRequired();
            Property(x => x.NombrePasajero).IsRequired().HasMaxLength(50);
            Property(x => x.VehiculoId).IsRequired();
        }
    }
}
