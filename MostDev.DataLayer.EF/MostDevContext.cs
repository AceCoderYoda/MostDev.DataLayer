#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.EF.MostDevContext.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Data.Entity;
using MostDev.DataLayer.Entities;
using MySql.Data.Entity;

#endregion

namespace MostDev.DataLayer.EF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MostDevContext : DbContext
    {
        public MostDevContext() : base(Connection.GetMySqlConnection())
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}