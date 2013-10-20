using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class taskThree
        
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Side A");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Side B");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Side C");
            int sideC = int.Parse(Console.ReadLine());

            float halfPerimeter = (sideA + sideB + sideC) / 2;
            float p = halfPerimeter;

            double area = Math.Sqrt((p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine("Area is {0}", area);
        }
    }
}
