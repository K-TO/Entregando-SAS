using System.Collections.Generic;

namespace Entregando.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(object Id);

        void Insert(T obj);

        void Update(T obj);

        void Delete(T obj);

        void Save();

        IEnumerable<T> ExecSP(string name, object[] parameters);
    }
}
