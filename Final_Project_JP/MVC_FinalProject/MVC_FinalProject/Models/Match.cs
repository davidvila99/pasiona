using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_FinalProject.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public string Difficult { get; set; }
        public ICollection<GameStuff> GameStuff { get; set; }
    }
}
