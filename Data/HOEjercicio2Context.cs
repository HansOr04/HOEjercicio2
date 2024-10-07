using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HOEjercicio2.Models;

namespace HOEjercicio2.Data
{
    public class HOEjercicio2Context : DbContext
    {
        public HOEjercicio2Context (DbContextOptions<HOEjercicio2Context> options)
            : base(options)
        {
        }

        public DbSet<HOEjercicio2.Models.Burger> Burger { get; set; } = default!;
    }
}
