using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_FinalProject.Models;

namespace API_FinalProject.Models
{
    public class API_FinalProjectContext : DbContext
    {
        public API_FinalProjectContext (DbContextOptions<API_FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<API_FinalProject.Models.GameStuff> GameStuff { get; set; }

        public DbSet<API_FinalProject.Models.Match> Match { get; set; }

        public DbSet<API_FinalProject.Models.Player> Player { get; set; }
    }
}
