using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAccess
{
    public class AplicationDbcontext : DbContext
    {
        public DbSet<Employees> employees { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Position> position { get; set; }
        public AplicationDbcontext(DbContextOptions options):base(options)
        {
           
            
        }   
    }
}
