using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Linq
{
    class turret
    {
        public string Nombre { get; set; }
        public int Rango { get; set; }
        public int Ataque { get; set; }

        public turret(string nombre, int rango, int ataque)
        {
            Nombre = nombre;
            Rango = rango;
            Ataque = ataque;

        }
    }
        
    struct posiciones {
        public int x { get; set; }
        public int y { get; set; }


    }
}
