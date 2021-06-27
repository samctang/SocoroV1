using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using Socoro.Model.Core;

namespace Socoro.Data.Core
{
    public class Repository<T> : IRepository<T> where T : class, IIdentifier
    {
        protected DbContext Context { get; set; }
        internal DbSet<T> EntitySet { get; set; }
        public Repository(DbContext context)
        {
            Context = context;
            EntitySet = context.Set<T>();
        }
        private static Tuple<string, object[]> PrepareArguments(string storedProcedure, object parameters)
        {
            List<string> parameterNames = new List<string>();
            List<object> parameterParameters = new List<object>();
            if(parameters != null)
            {
                foreach(PropertyInfo propertyInfo in parameters.GetType().GetProperties())
                {
                    string name = "@" + propertyInfo.Name;
                    object value = propertyInfo.GetValue(parameters, null);

                    parameterNames.Add(name);
                    parameterParameters.Add(new SqlParameter(name, value ?? DBNull.Value));
                }
            }
            if(parameterNames.Count > 0)
            {
                storedProcedure += " " + string.Join(", ", parameterNames);
            }
            return new Tuple<string, object[]>(storedProcedure, parameterParameters.ToArray());
        }
        public T Delete(T entity)
        {
            if(Context.Entry(entity).State == EntityState.Detached)
            {
                EntitySet.Attach(entity);
            }
            return EntitySet.Remove(entity);
        }

        public IEnumerable<T> ExecuteProcedure(string procedureName, object parameters)
        {
            Tuple<string, object[]> arguments = PrepareArguments(procedureName, parameters);
            return Context.Database.SqlQuery<T>(arguments.Item1, arguments.Item2);
        }

        public IQueryable<T> GetAll()
        {
            return EntitySet.AsQueryable();
        }

        public T GetById(int id)
        {
            T entity = EntitySet.Find(id);
        }

        public T InsertOrUpdate(T entity)
        {
            T result = null;
            if(entity.Id == 0)
            {
                result = EntitySet.Add(entity);
            }
            else
            {
                return Update(entity);
            }
            return result;
        }

        public T Update(T entity)
        {
            T result = EntitySet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            return result;
        }
    }
}
