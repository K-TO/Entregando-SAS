using Entregando.Infraestructure.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace Entregando.Data.Context
{
    public class EntregandoContext : DbContext
    {
        public EntregandoContext() : base("EntregandoContext")
        {

        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var typesToRegister = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => !(String.IsNullOrEmpty(t.Namespace)))
                .Where(t => t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance); 
            }
        }

        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Viaje> Viaje { get; set; }
        public DbSet<EmpleadoViaje> EmpleadoViajes { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
    }
}
