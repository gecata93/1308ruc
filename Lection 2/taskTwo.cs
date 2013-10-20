using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class taskTwo
        
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Side A");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Side B");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Height");
            int height = int.Parse(Console.ReadLine());

            float area = ((sideA + sideB) / 2) * height;
            Console.WriteLine("Area is {0}", area);

            
        }
    }
}
