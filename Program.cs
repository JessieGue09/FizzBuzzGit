using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i ++) // Números del 1 al 100
            {

                if (i % 3 == 0 && i % 5 == 0) // multiplo de 3 y 5
                {
                    Console.WriteLine("FizzBuzz");
                } 
                else if(i % 3 == 0) // multiplo de 3
                {
                    Console.WriteLine("Fizz");

                }
                else if (i % 5 == 0) // multiplo de 5
                {
                    Console.WriteLine("Buzz");

                } else {
                
                    Console.WriteLine(i);
                }
                //Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}