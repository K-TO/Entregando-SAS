using Entregando.Data.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entregando.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Props
        private EntregandoContext _context;
        private readonly DbSet<T> table;
        #endregion

        #region Ctor
        public GenericRepository(EntregandoContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        #endregion

        #region Methods
        public void Delete(T obj)
        {
            T exists = table.Find(obj);
            table.Remove(exists);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }


        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public IEnumerable<T> ExecSP(string name, object[] parameters)
        {
            return _context.Database.SqlQuery<T>(name, parameters);
        }
        #endregion
    }
}