using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCrud.Models;

namespace MvcCrud.Data
{
    public class MvcCrudContext : DbContext
    {
        public MvcCrudContext (DbContextOptions<MvcCrudContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCrud.Models.Department> Department { get; set; } = default!;
    }
}
