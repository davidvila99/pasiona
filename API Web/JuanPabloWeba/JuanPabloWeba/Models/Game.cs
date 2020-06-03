using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPabloWeba.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double Precio { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }

    }
}
