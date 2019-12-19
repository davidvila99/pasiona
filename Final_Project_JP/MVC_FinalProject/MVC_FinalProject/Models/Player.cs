using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_FinalProject.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public ICollection<GameStuff> GameStuff { get; set; }
    }
}
