using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Migracion.Model;

namespace Migracion.Data
{
    public class MigracionContext : DbContext
    {
        public MigracionContext (DbContextOptions<MigracionContext> options)
            : base(options)
        {
        }

        public DbSet<Migracion.Model.Humano> Humano { get; set; }
    }
}
