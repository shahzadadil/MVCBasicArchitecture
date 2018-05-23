using System.Data.Entity;
using Tas.Data.Entities;

namespace Tas.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=TasDbConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }

        public DataContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
