using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPabloWeba.Models
{
    public class JuanPabloWebaContext : DbContext
    {
        public JuanPabloWebaContext()
        {

        }

        public JuanPabloWebaContext(DbContextOptions<JuanPabloWebaContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Category> Categories { get; set; }



    }
}
