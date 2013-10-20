using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_sharp
{
    class taskEight
        
    {
        static void Main(string[] args)
        {

         
            Console.WriteLine("Please enter your numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double discriminant;
            double rootOne;
            double rootTwo;

            discriminant = Math.Pow(b,2)-4*a*c;
            if (discriminant > 0)
            {
                Console.WriteLine("Discriminant is {0}", discriminant);
                rootOne = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("First root is {0}", (float)rootOne);
                rootTwo = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Second root is {0}", (float)rootTwo);
            }
            else if (discriminant == 0)
            {
                rootOne = rootTwo = ((-b) + Math.Sqrt(discriminant)) / (2 * a); ;
                Console.WriteLine("Double equal root is {0}", (float)rootOne);
            }
            else
            {
                Console.WriteLine("Discriminant negative! No propper solution for the equation. ");
            }

           
        }
    }
}
