using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>()
            {
                new Alumno("Eva",20,6.0),
                new Alumno("Ana",22,7.0),
                new Alumno("Rosa",22,4.0),
                new Alumno("Ot",20,3.0),
                new Alumno("Iu",30,6.8),
                new Alumno("Pep",32,5.9),
                new Alumno("Laia",30,2.3),
                new Alumno("Quim",32,1.7),
            };
            //Seleccionamos todos los alumnos (devuelve un IEnumerable de  tipo Alumno)
            Console.WriteLine("Consulta que devuelve un IEnumerable de tipo Alumno");
            var alumnos = from alumno in listaAlumnos select alumno;
            foreach (Alumno al in alumnos)
            {
                Console.WriteLine(al);
            }

            //Para concatenar todos los elementos de una lista
            Console.WriteLine();
            Console.WriteLine("Concatenar lista de tipo alumnos");
            Console.WriteLine(String.Join(",", alumnos));
            Console.WriteLine();

            //Seleccionamos sólo el nombre de los alumnos (devuelve un IEnumerable de tipo string)
            Console.WriteLine("Consulta que devuelve un IEnumerable de tipo String");
            IEnumerable <string> alumnos2 = from alumno in listaAlumnos select alumno.Nombre;
            foreach (string al in alumnos2)
            {
                Console.WriteLine(al);
            }
            Console.WriteLine();
            Console.WriteLine("Concatenar lista de strings");
            Console.WriteLine(String.Join(",", alumnos2));

            //Sólo los aprobados
            Console.WriteLine();
            Console.WriteLine("Consulta que devuelve solo los alumnos aprovados");
            alumnos = from alumno in listaAlumnos where alumno.Nota >= 5 select alumno;
            Console.WriteLine(String.Join(" | ", alumnos));

            //Añadir un alumno
            Console.WriteLine();
            Console.WriteLine("Consulta que añade a un alumno");
            listaAlumnos.Add(new Alumno("Einstein", 50, 10));
            Console.WriteLine(String.Join(" | ", alumnos));

            //Ejecución inmediata
            List<Alumno> inmediato = (from alumno in listaAlumnos where alumno.Nota >= 5 select alumno).ToList<Alumno>();

            //Podemos usar las funciones de los enumerables
            Console.WriteLine();
            Console.WriteLine("Consulta que devuelve el número de alumnos aprovados de la lista");
            Console.WriteLine(alumnos.Count());
            Console.WriteLine(String.Join(" | ", alumnos.Reverse()));

            //Ordenado ascendente o descendente
            Console.WriteLine();
            Console.WriteLine("Consulta para ordenar ascendente o descendentemente");
            alumnos = from alumno in listaAlumnos where alumno.Nota >= 5 orderby alumno.Nota descending select alumno;
            Console.WriteLine(String.Join(" | ", alumnos));

            //Agrupaciones
            Console.WriteLine();
            Console.WriteLine("Consulta de agrupar por edades");
            var agrupado = from alumno in listaAlumnos group alumno by alumno.Edad;
            foreach (var grupo in agrupado)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key + " años");
                foreach (Alumno al in grupo)
                {
                    Console.WriteLine(al);
                }
            }

            //Ordenado descendientemente
            Console.WriteLine();
            Console.WriteLine("Misma lista ordenada descendiente");
            agrupado = from alumno in listaAlumnos group alumno by alumno.Edad into g orderby g.Key descending select g;
            foreach (var grupo in agrupado)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key + " años");
                foreach (Alumno al in grupo)
                {
                    Console.WriteLine(al);
                }
            }

            //exercici1
            Console.WriteLine();
            Console.WriteLine("-----exercici1-----");
            var consulta = from alumno in listaAlumnos where alumno.Edad > 30 select alumno.Nombre;
            Console.WriteLine(String.Join(" | ", alumnos));

            //exercici2
            Console.WriteLine();
            Console.WriteLine("-----exercici2-----");
            var consulta2 = from alumno in listaAlumnos group alumno by alumno.Nota >= 5;
            foreach (var grupo in consulta2)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key);
                foreach (Alumno al in grupo)
                {
                    Console.WriteLine(al);
                }
            }

            //exercici3
            Console.WriteLine();
            Console.WriteLine("-----exercici3-----");
            var consulta3 = from alumno in listaAlumnos orderby alumno.Nombre.Length descending group alumno by alumno.Nombre.Length;

            foreach (var grupo in consulta3)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key + " carácteres");
                foreach (Alumno al in grupo)
                {
                    Console.WriteLine("\t" + al);
                }
            }

            //exercici4
            Console.WriteLine();
            Console.WriteLine("-----exercici4-----");
            var consulta4 = from alumno in listaAlumnos
                            group alumno by alumno.Nombre.Length into g
                            where g.Sum(item => item.Edad) > 60
                            select g;

            foreach (var grupo in consulta4)
            {
                Console.WriteLine("Agrupado por el valor: " + grupo.Key + " carácteres");
                foreach (Alumno al in grupo)
                {
                    Console.WriteLine("\t" + al);
                }
            }
            Console.ReadKey();
        }
    }
}
