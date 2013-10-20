using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_sharp
{
    class taskSeven
        
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your numbers");
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

           
            if (sideA == sideB && sideB != sideC || sideA == sideC && sideC != sideB || sideB == sideC && sideC != sideA)
            {
                Console.WriteLine("Triangle is isosceles");
            }
            else if (sideA == sideB && sideB == sideC) 
            {
                Console.WriteLine("Triangle equilateral");
            }
            else 
            {
                Console.WriteLine("Triangle is scalene"); 
            }

           
        }
    }
}
