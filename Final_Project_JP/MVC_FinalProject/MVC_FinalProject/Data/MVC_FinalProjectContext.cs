using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_FinalProject.Models;

namespace MVC_FinalProject.Models
{
    public class MVC_FinalProjectContext : DbContext
    {
        public MVC_FinalProjectContext (DbContextOptions<MVC_FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_FinalProject.Models.GameStuff> GameStuff { get; set; }

        public DbSet<MVC_FinalProject.Models.Match> Match { get; set; }

        public DbSet<MVC_FinalProject.Models.Player> Player { get; set; }
    }
}
