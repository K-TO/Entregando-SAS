using Entregando.Infraestructure.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Entregando.Data.Mapping
{
    public class EmpleadoMap : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoMap()
        {
            ToTable("Empleado");
            Property(x => x.Nombres).IsRequired().HasMaxLength(50);
            Property(x => x.Apellidos).IsRequired().HasMaxLength(50);
            Property(x => x.Documento).IsRequired().HasMaxLength(20);
            Property(x => x.Cargo).IsRequired().HasMaxLength(50);
            Property(x => x.Email).IsRequired().HasMaxLength(50);
            Property(x => x.Celular).IsRequired().HasMaxLength(10);
            Property(x => x.FechaNacimiento).IsOptional();
            Property(x => x.TieneHijos).IsRequired();
        }
    }
}