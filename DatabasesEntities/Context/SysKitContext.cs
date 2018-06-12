using DatabasesEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabasesEntities.Context
{
    public class SysKitContext : DbContext, ISysKitContext
    {
        #region Constructors

        public SysKitContext(DbContextOptions options) : base(options) { }

        #endregion Constructors

        #region DbSets

        public DbSet<Employee> Employees { get; set; }

        #endregion DbSets
    }
}
