using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tienda.Entities;

namespace tienda.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<Empleado> Producto { get; set; }
    }
}
