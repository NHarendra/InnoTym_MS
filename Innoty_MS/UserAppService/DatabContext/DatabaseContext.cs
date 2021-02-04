using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAppService.Entities;

namespace UserAppService.DatabContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
