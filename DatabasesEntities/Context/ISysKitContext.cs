using DatabasesEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabasesEntities.Context
{
    public interface ISysKitContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Company> Companies { get; set; }
    }
}
