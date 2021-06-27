using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Socoro.Data.Core
{
    public class BaseContext : DbContext
    {
        public BaseContext(string connectionStringName) : base (connectionStringName) { }
        public BaseContext() { }
        public void ChangeObjectState(object entity, EntityState entityState)
        {
            ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.ChangeObjectState(entity, entityState);
        }
    }
}
