using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_sharp
{
    class taskSix
        
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter your number");
             string symbols = Console.ReadLine();
             int number;
             number = 0;
                 try
                     {
                         number = int.Parse(symbols);

                         if (number > 0)
                         {
                             Console.WriteLine("Possitive");
                         }
                         else
                         {
                             Console.WriteLine("Negative");
                         }
                     }
                 
                 catch (Exception)
                     {
                         Console.WriteLine("Wrong inpute data, please enter a propper number"); 
                     }
        }
    }
}