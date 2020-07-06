using Entregando.Infraestructure.Domain;
using System.Collections.Generic;

namespace Entregando.Service
{
    public interface IEmpleadoService
    {
        /// <summary>
        /// Obtiene todos los empleados registrados.
        /// </summary>
        /// <returns></returns>
        List<Empleado> GetAll();

        /// <summary>
        /// Obtiene un empleado por Id
        /// </summary>
        /// <param name="Id">Id del empleado</param>
        /// <returns></returns>
        Empleado GetById(int Id);

        /// <summary>
        /// Obtiene un empleado usando su identificación/documento
        /// </summary>
        /// <param name="Documento">Documento del empleado.</param>
        /// <returns></returns>
        Empleado GetByDoc(string Documento);

        /// <summary>
        /// Crea un empleado
        /// </summary>
        /// <param name="empleado">Empleado</param>
        /// <returns></returns>
        bool Create(Empleado empleado);

        /// <summary>
        /// Actualiza un empleado existente.
        /// </summary>
        /// <param name="empleado">Empleado</param>
        /// <returns></returns>
        bool Update(Empleado empleado);

        /// <summary>
        /// Elimina un empleado.
        /// </summary>
        /// <param name="empleado">Empleado</param>
        /// <returns></returns>
        bool Delete(Empleado empleado);
    }
}
