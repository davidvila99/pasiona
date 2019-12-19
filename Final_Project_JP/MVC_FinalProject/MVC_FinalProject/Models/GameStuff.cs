﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_FinalProject.Models
{
    public class GameStuff
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public Match Match { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
