using CRUD_NET_PROJEKT_WSB.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NET_PROJEKT_WSB.Server.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options)
            : base(options) 
        { 
        
        }
        public DbSet<Person> Person { get; set; }

    }
}
