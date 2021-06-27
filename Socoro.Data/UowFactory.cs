using System.Configuration;
using System.Data.Entity;
using Socoro.Data.Core;

namespace Socoro.Data
{
    public static class UowFactory
    {
        public static string ConnectionString { get; set; } = string.Empty;
        static UowFactory()
        {
            var DisableEfCodeFirst = ConfigurationManager.AppSettings["DisableEfCodeFirst"];
            if (DisableEfCodeFirst.Equals("true"))
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Migration.Configuration>("DBConnection"));
            }
        }
        public static IUnitOfWork Create()
        {
            var context = new DatabaseContext(ConnectionString);
            var uow = new UnitOfWork(context);
            return uow;
        }
    }
}
