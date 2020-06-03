using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoches.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Cilindros { get; set; }
        public string Matricula { get; set; }
    }
}
