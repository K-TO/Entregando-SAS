using Entregando.Data.It;
using Entregando.Data.Repository;
using Entregando.Infraestructure.Domain;
using Entregando.Infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entregando.Service
{
    public class EmpleadoService : IEmpleadoService
    {
        #region Members
        private readonly IEmpleadoRepository _repository;
        #endregion

        #region Ctor
        public EmpleadoService(IEmpleadoRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public List<Empleado> GetAll()
        {
            try
            {
                return _repository.GetAll().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Empleado GetById(int Id)
        {
            try
            {
                return _repository.GetById(Id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Empleado GetByDoc(string Documento)
        {
            try
            {
                return _repository.GetAll().Where(x => x.Documento.Equals(Documento)).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Create(Empleado empleado)
        {
            try
            {
                Empleado empleadoExist = GetByDoc(empleado.Documento);
                if (empleadoExist != null)
                {
                    Update(empleado);
                    return true;
                }
                else
                {
                    _repository.Insert(empleado);
                    _repository.Save();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el empleado, contacte al administrador.");
                return false;
            }
        }

        public bool Update(Empleado empleado)
        {
            try
            {
                Empleado empleadoExist = GetByDoc(empleado.Documento);
                if (empleadoExist != null)
                {
                    PropCopy.Copy(empleado, empleadoExist);
                    _repository.Update(empleadoExist);
                    _repository.Save();
                    return true;
                }
                else
                {
                    throw new Exception("El empleado no existe.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool Delete(Empleado empleado)
        {
            try
            {
                Empleado empleadoExist = GetByDoc(empleado.Documento);
                if (empleadoExist != null)
                {
                    _repository.Delete(empleado);
                    _repository.Save();
                    return true;
                }
                else
                {
                    throw new Exception("El empleado no existe.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
        #endregion
    }
}
