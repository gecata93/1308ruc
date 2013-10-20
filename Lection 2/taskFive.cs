using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class taskFive
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your ID");
            string ID = Console.ReadLine();
            Console.WriteLine("Please enter your phone");
            string phone = Console.ReadLine();

            Console.WriteLine("Hello \"{0}\" your ID is \"{1}\" and your phone number is \"{2}\"", name, ID, phone);
        }
    }
}
