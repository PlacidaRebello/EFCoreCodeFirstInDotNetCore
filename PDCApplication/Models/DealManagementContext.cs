using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PDCApplication.Models
{
    public class DealManagementContext:DbContext
    {
        public DealManagementContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Property> Property { get; set; }
        public DbSet<Deal> Deal { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
