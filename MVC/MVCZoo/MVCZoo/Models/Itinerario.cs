using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo.Models
{
    public class Itinerario
    {
        public int Id { get; set; }
        public int Còdigo { get; set; }
        public int Duracion { get; set; }
        public int Visitantes { get; set; }
        public double Longitud { get; set; }
        public ICollection<Habitat> Habitats { get; set; }
    }
}
