using System.Collections.Generic;
using System.Linq;
using Socoro.Model.Core;

namespace Socoro.Data.Core
{
    public interface IRepository<T> where T : class, IIdentifier
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        T InsertOrUpdate(T entity);
        T Update(T entity);
        T Delete(T entity);
        IEnumerable<T> ExecuteProcedure(string procedureName, object parameters);
    }
}
