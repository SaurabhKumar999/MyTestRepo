using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.AppDBContext
{
        public class AppDBContext : DbContext
        {
            public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }
            public DbSet<Teachers> Teacher
            {
                get;
                set;
            }
       
    }
    }

