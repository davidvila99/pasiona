using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo2.Models
{
    public class MVCZoo2Context : DbContext
    {
        public MVCZoo2Context(DbContextOptions<MVCZoo2Context> options)
            : base(options)
        {
        }

        public DbSet<Especie> Especies { get; set; }
        public DbSet<Habitat> Habitats { get; set; }
        public DbSet<ViveEn> ViveEns { get; set; }
        public DbSet<Itinerario> Itinerarios { get; set; }
    }
}
