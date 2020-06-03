using JuanPabloWeba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPabloWeba.DTO
{
    public class DTOGame
    {
        public string Titulo { get; set; }
        public double Price { get; set; }
        public string CategoriesString { get; set; }
        public Category Categories { get; set; }

    }
}
