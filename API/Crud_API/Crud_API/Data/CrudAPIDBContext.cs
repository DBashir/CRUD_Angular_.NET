using Crud_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_API.Data
{
    public class CrudAPIDBContext : DbContext
    {
        public CrudAPIDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
