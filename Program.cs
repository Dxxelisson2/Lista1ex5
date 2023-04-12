using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double v3;
            double v4;
            double media;

            Console.WriteLine("digite o valor 1");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor 2");
            v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor 3");
            v3 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor 4");
            v4 = double.Parse(Console.ReadLine());
           
            media = (v1 + v2 + v3 + v4 )/ 4;
            Console.WriteLine("media:"+ media);

        }
    }
}
