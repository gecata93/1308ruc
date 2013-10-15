			//1ва зад
            Console.WriteLine("Input your name");
            Console.WriteLine("Hello",Console.ReadLine());
            
			//2ра зад
            int sum;
            Console.WriteLine("Input your numbers");
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            sum = numOne + numTwo + numThree;
            Console.WriteLine(sum);
            
			//3та зад
            sbyte a= -115 , b= -44, c = 97, d = 112;
            byte e = 224;
            short f = -10000, g = 20000, h = 1990;
            ushort i = 52130;
            int j = 4825932, k = -1000000, l = 970700000;
            ulong r = 123456789123456789;*/

			//4та зад
             int num1, num2;
             Console.WriteLine("Input your numbers");
             num1 = int.Parse(Console.ReadLine());
             num2 = int.Parse(Console.ReadLine());
             Console.WriteLine("first number is " +num2);
             Console.WriteLine("second number is " +num1);*/
            
			
			//5та зад
            string name;
            Console.WriteLine("Input your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Hello");
			
			
			// част от 6та зад
            Console.WriteLine("Enter your number");
            string str = Console.ReadLine();
            int num;
            bool ifTrue = true;
             ifTrue=(int.TryParse(str, out num));
             if (ifTrue)
             {
                 Console.WriteLine(num);
             }
             else 
             {
                 Console.WriteLine("Wrong input data");
             }