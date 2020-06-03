using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_with_lambdas;

namespace Linq_with_lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listanumeros = Enumerable.Range(1, 20).ToList();
            
             
            
        Random random = new Random();
        int randomNumber = random.Next(0, 1000);
    }
    }
}
