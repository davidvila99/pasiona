using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo.Models
{
    public class MVCZooContext : DbContext
    {
        public MVCZooContext(DbContextOptions<MVCZooContext> options)
            : base(options)
        {
        }

        public DbSet<Especie> Especies { get; set; }
        public DbSet<Habitat> Habitats { get; set; }
        public DbSet<Vive_En> Vive_Ens { get; set; }
        public DbSet<Itinerario> Itinerarios { get; set; }
    }
}
