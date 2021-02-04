﻿using CustomerAppService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAppService.DataBaseContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
