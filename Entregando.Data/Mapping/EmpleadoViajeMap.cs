using Entregando.Infraestructure.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Entregando.Data.Mapping
{
    public class EmpleadoViajeMap : EntityTypeConfiguration<EmpleadoViaje>
    {
        public EmpleadoViajeMap()
        {
            ToTable("Empleado_Viaje");
            Property(x => x.EmpleadoId).IsRequired();
            Property(x => x.ViajeId).IsRequired();
        }
    }
}
