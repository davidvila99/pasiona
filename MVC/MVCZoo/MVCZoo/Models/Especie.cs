using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoo.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Foto { get; set; }
        public string NombreCompuesto { get; set; }
        public string NombreCientifico { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Vive_En> Vive_Ens { get; set; }

    }
}
